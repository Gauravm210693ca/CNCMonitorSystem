using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNCMonitor
{
    public class DurationAlertManager:IAlertManager
    {
        public void GenerateAlert()
        {
            Console.WriteLine("duration limit exceeded");
        }
    }
}
