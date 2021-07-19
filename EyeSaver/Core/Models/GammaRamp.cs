using System.Runtime.InteropServices;

namespace EyeSaver.Core.Models {


    [StructLayout(LayoutKind.Sequential)]
    public struct GammaRamp {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
        public readonly ushort[] Red;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
        public readonly ushort[] Green;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
        public readonly ushort[] Blue;




        public GammaRamp(int size = 256) {
            Red = new ushort[size];
            Blue = new ushort[size];
            Green = new ushort[size];
        }


    }
}