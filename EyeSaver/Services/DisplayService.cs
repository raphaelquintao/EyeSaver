using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using EyeSaver.Core;
using EyeSaver.Core.Models;
using EyeSaver.Models;

namespace EyeSaver.Services {


    class DisplayService : IDisposable {
        public List<Display> displays = new List<Display>();

        public DisplayService() {

            ListMonitors();
        }

        ~DisplayService() {
            Dispose();
        }

        private int Monitorenumproc(IntPtr hMonitor, IntPtr hdcMonitor, ref Rect param2, IntPtr dw_data) {
            // optional actually ...
            var info = new MonitorInfoEx { cbSize = (uint)Marshal.SizeOf<MonitorInfoEx>() };
            if (!Native.GetMonitorInfo(hMonitor, ref info))
                throw new InvalidOperationException();

            var device = new DisplayDevice { cb = (uint)Marshal.SizeOf<DisplayDevice>() };

            if (!Native.EnumDisplayDevices(info.DeviceName, 0, ref device, 0))
                throw new InvalidOperationException();
            
            //Debug.WriteLine(device.ToString());

            displays.Add(new Display(info, device, new GammaService(info.DeviceName)));

            return 1;
        }

        private void ListMonitors() {
            var hdc = Native.GetDC(IntPtr.Zero);
            if (hdc == IntPtr.Zero)
                throw new InvalidOperationException();
            if (!Native.EnumDisplayMonitors(hdc, IntPtr.Zero, Monitorenumproc, IntPtr.Zero))
                throw new InvalidOperationException();
            if (Native.ReleaseDC(IntPtr.Zero, hdc) == 0)
                throw new InvalidOperationException();



        }

        public void Dispose() {
            foreach (Display display in displays) {
                display.gamma_service.Dispose();
            }
        }

    }

}
