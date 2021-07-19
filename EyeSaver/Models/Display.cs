using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EyeSaver.Core.Models;
using EyeSaver.Services;

namespace EyeSaver.Models {
    public class Display {
        public MonitorInfoEx monitor_info;
        public DisplayDevice display_device;
        public GammaService gamma_service;

        public Display(MonitorInfoEx monitor_info, DisplayDevice display_device, GammaService gamma_service) {
            this.monitor_info = monitor_info;
            this.display_device = display_device;
            this.gamma_service = gamma_service;
        }


    }
}
