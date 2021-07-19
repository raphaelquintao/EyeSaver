using System.Runtime.InteropServices;

namespace EyeSaver.Core.Models {
    [StructLayout(LayoutKind.Sequential)]
    public struct Rect {
        public readonly int Left;
        public readonly int Top;
        public readonly int Right;
        public readonly int Bottom;


        public int Width {
            get {
                return Right - Left;
            }
        }

        public int Height {
            get {
                return Bottom - Top;
            }
        }

        public Rect(int left, int top, int right, int bottom) {
            Left = left;
            Top = top;
            Right = right;
            Bottom = bottom;
        }

        public override string ToString() {
            return $"L:{Left} T:{Top} R:{Right} B:{Bottom}";
        }

        public string Resolution() {
            return $"{Width}x{Height}";
        }

    }
}
