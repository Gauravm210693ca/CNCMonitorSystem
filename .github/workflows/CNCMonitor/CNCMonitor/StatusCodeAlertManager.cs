using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNCMonitor
{
    public class StatusCodeAlertManager:IAlertManager
    {
        public void GenerateAlert()
        {
            Console.WriteLine("Status code Alert");
        }
    }
}
