using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using EyeSaver.Core;
using EyeSaver.Models;
using EyeSaver.Services;
using EyeSaver.Util;
using EyeSaver.Views;
using Microsoft.Win32;

namespace EyeSaver {
    public partial class TrayWindow : Window {
        private RegistryKey reg_key;

        private Settings settings;
        private DisplayService display_service;

        private System.Windows.Forms.ContextMenu cmenu;
        private System.Windows.Forms.NotifyIcon notifyIcon;

        private bool can_close = false;
        private IntPtr my_hWnd;

        public TrayWindow() {
            InitializeComponent();

            Init();
        }

        private void Init() {
            AssemblyTitleAttribute attributes = (AssemblyTitleAttribute)
                Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(AssemblyTitleAttribute), false);

            Title = attributes.Title;

            reg_key = Registry.CurrentUser.OpenSubKey("Software", true)?.CreateSubKey("QEyeSaver");


            settings        = Settings.Load();
            display_service = new DisplayService();
            ListMonitor();
            LoadSettings();

            cmenu = new System.Windows.Forms.ContextMenu();
            cmenu.MenuItems.Add("Toggle", (sender, args) => { this.ToggleMe(); });
            cmenu.MenuItems.Add("-");
            cmenu.MenuItems.Add("Close", (sender, args) => { this.CloseMe(); });


            notifyIcon = new System.Windows.Forms.NotifyIcon {Icon = System.Drawing.Icon.ExtractAssociatedIcon(Assembly.GetExecutingAssembly().Location), Text = this.Title, Visible = true, ContextMenu = cmenu};

            notifyIcon.MouseClick += (sender, args) => {
                if ((args.Button & System.Windows.Forms.MouseButtons.Left) != 0) {
                    ToggleMe();
                }
            };


            this.Closing += (sender, args) => {
                if (!can_close) {
                    args.Cancel = true;
                    this.HideMe();
                }
            };

            this.Loaded += (sender, args) => {
                GetHWND();
                reg_key.SetValue("hwnd", my_hWnd);
            };


            //DisplayList.PreviewMouseWheel += (sender, args) => {
            //    DisplayRow item = (DisplayRow)DisplayList.SelectedItem;

            //    if (item != null) {
            //        if (item.inner_hover) return;

            //        int delta = args.Delta;
            //        if (delta < 0) item.Bright_Down();
            //        if (delta > 0) item.Bright_Up();

            //        Debug.WriteLine("List Mouse {0}", delta);
            //    }
            //};

            btn_save.Click += (sender, args) => { SaveSettings(); };

            btn_default.Click += (sender, args) => {
                foreach (DisplayRow item in DisplayList.Items) {
                    item.Bright_Set(1);
                    item.Temp_Set(6500);
                }
            };

            btn_restore.Click += (sender, args) => {
                settings = Settings.Load();
                LoadSettings();
            };
        }

        public IntPtr GetHWND() {
            WindowInteropHelper wih = new WindowInteropHelper(this);
            my_hWnd = wih.Handle;

            Debug.WriteLine("HWND: {0}", my_hWnd);

            return my_hWnd;
        }

        private bool IsVisibleMe() {
            bool visible = Native.IsWindowVisible(my_hWnd);
            return visible;
        }

        private void ShowMe() {
            Native.ShowWindow(my_hWnd, 1);
            Native.SetForegroundWindow(my_hWnd);
        }

        private void HideMe() {
            Native.ShowWindow(my_hWnd, 0);
        }

        private void ToggleMe() {
            if (this.IsVisibleMe() && this.WindowState != WindowState.Minimized) {
                this.HideMe();
            } else this.ShowMe();
        }

        private void CloseMe() {
            can_close          = true;
            notifyIcon.Visible = false;
            this.Close();
        }

        private void WindowHeader_MouseDown(object sender, MouseButtonEventArgs e) {
            if (!e.Handled && e.ChangedButton == MouseButton.Left) this.DragMove();
        }

        private void WindowClose(object sender, MouseButtonEventArgs e) {
            e.Handled = true;
            if (e.ButtonState == MouseButtonState.Released) {
                if (e.ChangedButton == MouseButton.Left) {
                    this.Close();
                } else if (e.ChangedButton == MouseButton.Right) {
                    this.CloseMe();
                }
            }
        }

        private void WindowMinimize(object sender, MouseButtonEventArgs e) {
            e.Handled = true;
            if (e.ButtonState == MouseButtonState.Released && e.ChangedButton == MouseButton.Left)
                this.WindowState = WindowState.Minimized;
        }

        private void ListMonitor() {
            foreach (Display display in display_service.displays) {
                //Debug.WriteLine(display.display_device.HashKey());

                DisplayList.Items.Add(new DisplayRow(display));
            }
        }

        private void LoadSettings() {
            foreach (DisplayRow item in DisplayList.Items) {
                string key = item.get_display().display_device.HashKey();
                if (settings.display_data.Contains(key)) {
                    Dictionary<string, object> data = (Dictionary<string, object>) settings.display_data[key];
                    item.Bright_Set(double.Parse(data["bright"].ToString()));
                    item.Temp_Set(int.Parse(data["temp"].ToString()));
                } else {
                    settings.display_data[key] = new SettingData(1, 6500);
                }
            }
        }

        private void SaveSettings() {
            foreach (DisplayRow item in DisplayList.Items) {
                string key = item.get_display().display_device.HashKey();
                settings.display_data[key] = new SettingData(item.Bright_Get(), item.Temp_Get());
            }

            settings.Save();
        }
    }
}