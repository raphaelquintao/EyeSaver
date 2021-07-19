using System.Runtime.InteropServices;

namespace EyeSaver.Core.Models {
    [StructLayout(LayoutKind.Sequential)]
    public struct DisplayDevice {
        public uint cb;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
        public string DeviceName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string DeviceString;
        public uint StateFlags;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string DeviceID;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string DeviceKey;


        public override string ToString() {
            return $"{DeviceName}\n{DeviceString}\n{DeviceID}\n{DeviceKey}\n{StateFlags}\n";
        }

        public string HashKey() {
            return $"{DeviceName} | {DeviceString}";
        }
    }
}
