using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using EyeSaver.Core.Models;
using EyeSaver.Models;
using EyeSaver.Services;

namespace EyeSaver.Views {
    public partial class DisplayRow : ListViewItem {
        private readonly Display display;
        public bool inner_hover = false;


        public DisplayRow(Display display) {
            InitializeComponent();
            this.display = display;

            this.Focusable = false;

            SetInfo();

            slider_bright.ValueChanged += Slider_BrightOnValueChanged;

            slider_temp.ValueChanged += Slider_TempOnValueChanged;

            this.MouseEnter += (sender, args) => { this.IsSelected = true; };

            //this.MouseLeftButtonUp += (sender, args) => { this.IsSelected = !this.IsSelected; };

            slider_bright.PreviewMouseWheel += (sender, args) => {
                args.Handled = true;
                double step = 0.01;

                if (Keyboard.IsKeyDown(Key.LeftCtrl)) step       = 0.1;
                else if (Keyboard.IsKeyDown(Key.LeftShift)) step = 0.05;

                int delta = args.Delta;
                if (delta < 0) slider_bright.Value -= step;
                if (delta > 0) slider_bright.Value += step;

                Debug.WriteLine("Bright Mouse {0}", delta);
            };


            slider_temp.PreviewMouseWheel += (sender, args) => {
                args.Handled = true;
                double step = 50;

                if (Keyboard.IsKeyDown(Key.LeftCtrl)) step       = 100;
                else if (Keyboard.IsKeyDown(Key.LeftShift)) step = 10;

                int delta = args.Delta;
                if (delta < 0) slider_temp.Value -= step;
                if (delta > 0) slider_temp.Value += step;

                Debug.WriteLine("Temp Mouse {0}", delta);
            };


            slider_bright.Background         = slider_bright.Background.Clone();
            slider_bright.Background.Opacity = 0.6;

            slider_bright.MouseEnter += (sender, args) => {
                inner_hover                      = true;
                slider_bright.Background.Opacity = 1;
            };
            slider_bright.MouseLeave += (sender, args) => {
                inner_hover                      = false;
                slider_bright.Background.Opacity = 0.6;
            };

            slider_bright.MouseDoubleClick += (sender, args) => {
                if (args.ChangedButton == MouseButton.Right) {
                    slider_bright.Value = 1;
                }
            };


            slider_temp.Background = CreateTemperatureBrush(0.6);
            slider_temp.MouseEnter += (sender, args) => {
                inner_hover                    = true;
                slider_temp.Background.Opacity = 1;
            };
            slider_temp.MouseLeave += (sender, args) => {
                inner_hover                    = false;
                slider_temp.Background.Opacity = 0.6;
            };

            slider_temp.MouseDoubleClick += (sender, args) => {
                if (args.ChangedButton == MouseButton.Right) {
                    slider_temp.Value = 6500;
                }
            };

            // Presets
            slider_temp.Ticks.Add(1200); // Ember
            slider_temp.Ticks.Add(1900); // Candle
            slider_temp.Ticks.Add(2300); // Dim Incandescent
            slider_temp.Ticks.Add(2700); // Incandescent
            slider_temp.Ticks.Add(3400); // Halogen
            slider_temp.Ticks.Add(4200); // Fluorescent
            slider_temp.Ticks.Add(5500); // Sunlight
            slider_temp.Ticks.Add(6500); // Daylight


            slider_temp.Maximum = 7500;

            slider_temp.PreviewMouseLeftButtonDown += (sender, args) => {
                //slider_temp.IsMoveToPointEnabled = false;
                slider_temp.IsSnapToTickEnabled = true;
            };

            slider_temp.PreviewMouseLeftButtonUp += (sender, args) => {
                //slider_temp.IsMoveToPointEnabled = false;
                slider_temp.IsSnapToTickEnabled = false;
            };
        }

        private LinearGradientBrush CreateTemperatureBrush(double opacity = 1) {
            RGB g1 = GammaUtils.gammas[0].gamma;
            int last = (int) slider_temp.Maximum;
            if (last > GammaUtils.gammas.Length - 1) {
                last                = GammaUtils.gammas.Length - 1;
                slider_temp.Maximum = last;
            }

            RGB g2 = GammaUtils.gammas[last].gamma;

            Color start = Color.FromRgb((byte) (255 * g1.r), (byte) (255 * g1.g), (byte) (255 * g1.b));
            Color end = Color.FromRgb((byte) (255 * g2.r), (byte) (255 * g2.g), (byte) (255 * g2.b));

            LinearGradientBrush brush = new LinearGradientBrush(start, end, 0) {MappingMode = BrushMappingMode.RelativeToBoundingBox, Opacity = opacity};
            Debug.WriteLine(start);
            Debug.WriteLine(end);
            return brush;
        }

        private void SetInfo() {
            MonitorInfoEx info = display.monitor_info;
            DisplayDevice device = display.display_device;

            t_device_name.Text = device.DeviceString;

            t_res.Text = info.rcMonitor.Resolution();

            t_primary.Text = (info.dwFlags == 1) ? "Primary" : "";
        }

        public void Bright_Up() {
            slider_bright.Value += 0.01;
        }

        public void Bright_Down() {
            slider_bright.Value -= 0.01;
        }

        public void Bright_Set(double bright) {
            slider_bright.Value = bright;
        }

        public double Bright_Get() {
            return slider_bright.Value;
        }

        public void Temp_Set(int temp) {
            slider_temp.Value = temp;
        }

        public int Temp_Get() {
            return (int) Math.Round(slider_temp.Value, 0);
        }

        public Display get_display() {
            return display;
        }


        private void SetData() {
            double bright = Math.Round(slider_bright.Value, 2);
            int temp = (int) Math.Round(slider_temp.Value, 0);

            GammaService gamma_service = display.gamma_service;

            RGB color = gamma_service.SetDisplayGamma(bright, temp);

            Debug.WriteLine("Color Changed: {0}", color);
        }

        private void Slider_BrightOnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            Slider slider = (Slider) sender;
            double value = Math.Round(slider.Value, 2);
            t_bright.Text = value.ToString(CultureInfo.InvariantCulture);

            SetData();
        }

        private void Slider_TempOnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e) {
            Slider slider = (Slider) sender;
            double value = Math.Round(slider.Value, 0);

            t_temp.Text = value.ToString(CultureInfo.InvariantCulture) + " K";

            SetData();
        }
    }
}