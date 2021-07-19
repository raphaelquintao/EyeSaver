using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EyeSaver.Util {

    public struct SettingData {
        public double bright;
        public int temp;

        public SettingData(double bright, int temp) {
            this.bright = bright;
            this.temp = temp;
        }
        
        public override string ToString() {
            return $"Bright:{bright} Temp:{temp}";
        }
    }

    public class Settings : AppSettings<Settings> {

        public bool enabled = true;

        public Hashtable display_data = new Hashtable();

    }
}
