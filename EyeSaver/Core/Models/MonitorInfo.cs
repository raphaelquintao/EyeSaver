using System.Runtime.InteropServices;

namespace EyeSaver.Core.Models {
    [StructLayout(LayoutKind.Sequential)]
    public struct MonitorInfoEx {
        public uint cbSize;
        public Rect rcMonitor;
        public Rect rcWork;
        public uint dwFlags;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string DeviceName;


        public override string ToString() {
            return $"{DeviceName}\n{cbSize}\n{rcMonitor}\n{rcWork}\n{dwFlags}\n";
        }

    }
}
