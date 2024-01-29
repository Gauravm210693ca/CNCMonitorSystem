using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNCMonitor
{
    public class CNCMachineDataAnalyzer
    {
        private double temperatureThreshold = 35.0;
        private double dimensionThreshold = 0.05;
        private string statusCode = "0xFF";
        CNCMonitorData CNCMonitorObj;
        public event Action actionEvent;
        public DateTime OpenedTime;
        TimerManager timerObj;
        public CNCMachineDataAnalyzer(CNCMonitorData data) {
            this.CNCMonitorObj = data;
            
        }
        public void AnalyzeTemperature()
        {
            if (CNCMonitorObj.temperature > temperatureThreshold)
            {
                
                if (actionEvent != null)
                {
                    actionEvent.Invoke();
                }
            }
        }
        public void AnalyzeDuration()
        {
            OpenedTime = DateTime.Now;
            timerObj = new TimerManager(this);
            if (timerObj.CheckDuration())
            {
                if (actionEvent != null)
                {
                    actionEvent.Invoke();
                }
            }

        }
        public void AnalyzeDimension()
        {
            if (CNCMonitorObj.dimension > dimensionThreshold)
            {
                 if (actionEvent != null)
                 {
                      actionEvent.Invoke();
                 }
                
            }
        }
        public void AnalyzeStatusCode()
        {
            if (CNCMonitorObj.code != statusCode)
            {
                if (actionEvent != null)
                {
                    actionEvent.Invoke();
                }
            }
        }
    }
}
