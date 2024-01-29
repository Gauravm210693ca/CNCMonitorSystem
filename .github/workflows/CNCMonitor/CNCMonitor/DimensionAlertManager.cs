using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNCMonitor
{
    public class DimensionAlertManager:IAlertManager
    {
        public void GenerateAlert()
        {
            Console.WriteLine("dimension limit exceeded");
        }
    }
}
