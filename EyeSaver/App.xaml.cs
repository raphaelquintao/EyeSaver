using System;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using EyeSaver.Core;
using Microsoft.Win32;

namespace EyeSaver {
    public partial class App : Application {
        private Window main;

        public App() {
            Debug.WriteLine("OPS!");
        }

        protected override void OnStartup(StartupEventArgs e) {
            base.OnStartup(e);
            Process proc = Process.GetCurrentProcess();

            Process[] processes = Process.GetProcessesByName(proc.ProcessName);

            int count = processes.Count();
            if (count > 1) {
                try {
                    string value = (string) Registry.CurrentUser.OpenSubKey("Software", true)
                                                    ?.CreateSubKey("QEyeSaver")
                                                    ?.GetValue("hwnd", IntPtr.Zero);

                    if (value != null) {
                        IntPtr hwnd = (IntPtr) Int32.Parse(value);

                        Native.ShowWindow(hwnd, 1);
                        Native.SetForegroundWindow(hwnd);
                    }
                } catch (Exception) {
                    // ignored
                }

                App.Current.Shutdown();
            } else {
                main = new TrayWindow();
                main.Show();
            }
        }


        protected override void OnExit(ExitEventArgs e) {
            base.OnExit(e);
        }
    }
}