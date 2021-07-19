using EyeSaver.Core;
using EyeSaver.Models;
using System;
using System.Linq;
using EyeSaver.Core.Models;

namespace EyeSaver.Services {

    public class GammaService : IDisposable {

        private readonly IntPtr _dc;

        public GammaService(String device_name) {
            _dc = Native.CreateDC("DISPLAY", device_name, null, IntPtr.Zero);
        }

        ~GammaService() {
            Dispose(false);
        }

        public GammaRamp GetDisplayGammaRamp() {
            Native.GetDeviceGammaRamp(_dc, out GammaRamp ramp);
            return ramp;
        }


        public void SetDisplayGammaLinear(ColorData colorData) {
            GammaRamp ramp = new GammaRamp(256);
            int multiply = 256;

            for (int i = 1; i < 256; i++) {
                double tmp_r = (i * multiply * colorData.amount.r);
                double tmp_g = (i * multiply * colorData.amount.g);
                double tmp_b = (i * multiply * colorData.amount.b);

                tmp_r *= colorData.bright;
                tmp_g *= colorData.bright;
                tmp_b *= colorData.bright;

                if (tmp_r > 65535) tmp_r = 65535;
                if (tmp_g > 65535) tmp_g = 65535;
                if (tmp_b > 65535) tmp_b = 65535;

                if (tmp_r < 0) tmp_r = 0;
                if (tmp_g < 0) tmp_g = 0;
                if (tmp_b < 0) tmp_b = 0;

                ramp.Red[i] = (ushort)tmp_r;
                ramp.Green[i] = (ushort)tmp_g;
                ramp.Blue[i] = (ushort)tmp_b;

            }


            Native.SetDeviceGammaRamp(_dc, ref ramp);
        }

        public RGB SetDisplayGamma(double bright, int temp) {
            GammaRamp ramp = new GammaRamp(256);

            double alpha = (temp % 100) / 100.0d;
            int index = ((temp - 1000) / 100);
            int next = index + 1;

            TempGamma[] gammas = GammaUtils.gammas;


            RGB white_point;

            //if (alpha > 0) {
            if (next > gammas.Length - 1) next = index;
            white_point = RGB.Interpolate(alpha, gammas[index].gamma, gammas[next].gamma);
            //} else {
            //white_point = gammas[index].gamma;
            //}

            RGB tweak = new RGB(1, 1, 1);


            int multiply = 256;
            for (int i = 0; i < 256; i++) {
                double tmp_r = (Math.Pow((double)i / multiply, 1.0d / tweak.r));
                double tmp_g = (Math.Pow((double)i / multiply, 1.0d / tweak.g));
                double tmp_b = (Math.Pow((double)i / multiply, 1.0d / tweak.b));

                tmp_r *= UInt16.MaxValue * white_point.r * bright;
                tmp_g *= UInt16.MaxValue * white_point.g * bright;
                tmp_b *= UInt16.MaxValue * white_point.b * bright;

                //if (tmp_r > 65535) tmp_r = 65535;
                //if (tmp_g > 65535) tmp_g = 65535;
                //if (tmp_b > 65535) tmp_b = 65535;

                //if (tmp_r < 0) tmp_r = 0;
                //if (tmp_g < 0) tmp_g = 0;
                //if (tmp_b < 0) tmp_b = 0;

                ramp.Red[i] = (ushort)tmp_r;
                ramp.Green[i] = (ushort)tmp_g;
                ramp.Blue[i] = (ushort)tmp_b;

            }


            Native.SetDeviceGammaRamp(_dc, ref ramp);

            return white_point;
        }


        public void RestoreDefault() {
            GammaRamp ramp = new GammaRamp(256);
            int multiply = 256;
            for (ushort i = 1; i < 256; i++) {
                ramp.Red[i] = (ushort)(i * multiply);
                ramp.Green[i] = (ushort)(i * multiply);
                ramp.Blue[i] = (ushort)(i * multiply);
            }

            //SetDisplayGammaRamp(ramp);
            Native.SetDeviceGammaRamp(_dc, ref ramp);

            //SetDisplayGammaLinear(new ColorData(1));
            //SetDisplayGammaLinear(new ColorData(1.00393));
            //SetDisplayGammaLinear(1.00393, 1.00393, 1.00393);
        }

        protected void Dispose(bool disposing) {
            RestoreDefault();
            Native.DeleteDC(_dc);
        }

        public void Dispose() {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
