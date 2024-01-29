using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CNCMonitor
{
    public class TimerManager
    {
       
        
        private int durationThreshold = 2;
        CNCMachineDataAnalyzer machineDataAnalyzer;
        public TimerManager(CNCMachineDataAnalyzer machineDataAnalyzer) {
             this.machineDataAnalyzer = machineDataAnalyzer;
            
        }
        public bool CheckDuration()
        {
            if ((DateTime.Now - machineDataAnalyzer.OpenedTime) > TimeSpan.FromSeconds( durationThreshold))
            {
                return true;
            }
            return false;
        }
    }
}
