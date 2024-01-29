using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNCMonitor
{
    public class CNCMonitorData
    {
        public double temperature;
        public double dimension;
        public int duration;
        public string code;

        public CNCMonitorData(double temp, double dim, int duration, string code)
        {
            this.temperature = temp;
            this.dimension = dim;
            this.duration = duration;
            this.code = code;
        }
    }
}
