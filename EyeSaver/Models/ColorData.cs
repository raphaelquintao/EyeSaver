
using System;

namespace EyeSaver.Models {

    public struct RGB {
        public readonly double r, g, b;

        public RGB(double uniform) {
            r = g = b = uniform;
        }

        public RGB(double r, double g, double b) {
            this.r = r; this.g = g; this.b = b;
        }

        public static RGB Interpolate(double a, RGB c1, RGB c2) {
            return new RGB(
                (1 - a) * c1.r + a * c2.r,
                (1 - a) * c1.g + a * c2.g,
                (1 - a) * c1.b + a * c2.b
            );
        }

        public override string ToString() {
            return $"R:{r} G:{g} B:{b}";
        }
    }

    public struct ColorData {
        public RGB amount;
        public double bright;

        public ColorData(RGB a) {
            amount = a;
            bright = 1;
        }

        public void SetBright(double brightness) {
            bright = brightness;
        }

        public static ColorData FromTemperature(int temp) {
            // Source: http://www.tannerhelland.com/4435/convert-temperature-rgb-algorithm-code/

            double tempf = temp / 100d;

            double redi;
            double greeni;
            double bluei;

            // Red
            if (tempf <= 66)
                redi = 1;
            else
                redi = Math.Pow(tempf - 60, -0.1332047592) * 329.698727446 / 255d;

            // Green
            if (tempf <= 66)
                greeni = (Math.Log(tempf) * 99.4708025861 - 161.1195681661) / 255d;
            else
                greeni = Math.Pow(tempf - 60, -0.0755148492) * 288.1221695283 / 255d;

            // Blue
            if (tempf >= 66)
                bluei = 1;
            else {
                if (tempf <= 19)
                    bluei = 0;
                else
                    bluei = (Math.Log(tempf - 10) * 138.5177312231 - 305.0447927307) / 255d;
            }

            return new ColorData(new RGB(redi, greeni, bluei));
        }

        public override string ToString() {
            return $"Amount:{amount}\nBright:{bright}";
        }

    }

}