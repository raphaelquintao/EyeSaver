
using System;
using System.Runtime.InteropServices;
using System.Text;
using EyeSaver.Core.Models;

namespace EyeSaver.Core {

    internal static class Native {

        //[DllImport("user32.dll", EntryPoint = "SetWinEventHook", SetLastError = true)]
        //public static extern IntPtr SetWinEventHook(
        //    uint eventMin, uint eventMax,
        //    IntPtr hmodWinEventProc, WinEventHandler lpfnWinEventProc,
        //    uint idProcess, uint idThread, uint dwFlags);

        //[DllImport("user32.dll", EntryPoint = "UnhookWinEvent", SetLastError = true)]
        //public static extern bool UnhookWinEvent(IntPtr hWinEventHook);

        [DllImport("user32.dll", EntryPoint = "GetDC", SetLastError = true)]
        public static extern IntPtr GetDC(IntPtr hWnd);

        [DllImport("user32.dll", EntryPoint = "ReleaseDC", SetLastError = true)]
        public static extern int ReleaseDC(IntPtr hWnd, IntPtr hDC);

        [DllImport("gdi32.dll", EntryPoint = "CreateDC", CharSet = CharSet.Auto)]
        public static extern IntPtr CreateDC(string lpszDriver, string lpszDevice, string lpszOutput, IntPtr lpInitData);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto)]
        public static extern bool DeleteDC([In] IntPtr hdc);

        [DllImport("gdi32.dll", EntryPoint = "SetDeviceGammaRamp", SetLastError = true)]
        public static extern bool SetDeviceGammaRamp(IntPtr hMonitor, ref GammaRamp ramp);

        [DllImport("gdi32.dll", EntryPoint = "GetDeviceGammaRamp", SetLastError = true)]
        public static extern bool GetDeviceGammaRamp(IntPtr hMonitor, out GammaRamp ramp);

        [DllImport("user32.dll", EntryPoint = "GetMonitorInfo")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetMonitorInfo([In] IntPtr hMonitor, ref MonitorInfoEx lpmi);

        [DllImport("user32.dll", EntryPoint = "EnumDisplayMonitors")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumDisplayMonitors([In] IntPtr hdc, [In] IntPtr lprcClip, MONITORENUMPROC lpfnEnum, IntPtr dwData);

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate int MONITORENUMPROC(IntPtr param0, IntPtr param1, ref Rect param2, IntPtr param3);

        [DllImport("user32.dll", EntryPoint = "EnumDisplayDevices")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumDisplayDevices([In] string lpDevice, [In] uint iDevNum, ref DisplayDevice display_device, uint dwFlags);


        [DllImport("user32.dll")]
        public static extern int ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll")]
        public static extern int SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        public static extern int IsIconic(IntPtr hWnd);



        [DllImport("user32.dll", EntryPoint = "RegisterHotKey", SetLastError = true)]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vk);

        [DllImport("user32.dll", EntryPoint = "UnregisterHotKey", SetLastError = true)]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        [DllImport("user32.dll", EntryPoint = "GetForegroundWindow", SetLastError = true)]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll", EntryPoint = "GetDesktopWindow", SetLastError = true)]
        public static extern IntPtr GetDesktopWindow();

        [DllImport("user32.dll", EntryPoint = "GetShellWindow", SetLastError = true)]
        public static extern IntPtr GetShellWindow();

        [DllImport("user32.dll", EntryPoint = "GetWindowRect", SetLastError = true)]
        public static extern bool GetWindowRect(IntPtr hWindow, out Rect rect);

        [DllImport("user32.dll", EntryPoint = "GetClientRect", SetLastError = true)]
        public static extern bool GetWindowClientRect(IntPtr hWindow, out Rect rect);

        [DllImport("user32.dll", EntryPoint = "IsWindowVisible", SetLastError = true)]
        public static extern bool IsWindowVisible(IntPtr hWindow);

        [DllImport("user32.dll", EntryPoint = "GetClassName", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern int GetClassName(IntPtr hWindow, StringBuilder className, int maxCount);

    }
}
