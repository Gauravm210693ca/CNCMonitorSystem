using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNCMonitor
{
    public class Program
    {
        static void Main(string[] args)
        {

            CNCMonitorData data = new CNCMonitorData(40.5, 0.03, 2, "0xFF");
            CNCMachineDataAnalyzer cNCMachineDataAnalyzer = new CNCMachineDataAnalyzer(data);

            IAlertManager tempAlertObj = new TemperatureAlertManager();  
            IAlertManager dimensionAlertObj = new DimensionAlertManager();  
            IAlertManager durationAlertObj = new DurationAlertManager(); 
            IAlertManager statusCodeAlertObj = new StatusCodeAlertManager();
            
            
            
            Action tempAction = new Action(tempAlertObj.GenerateAlert);
            cNCMachineDataAnalyzer.actionEvent += tempAction;
            
            Action durationAction = new Action(durationAlertObj.GenerateAlert);
            cNCMachineDataAnalyzer.actionEvent += durationAction;
            
            Action dimensionAction = new Action(dimensionAlertObj.GenerateAlert);
            cNCMachineDataAnalyzer.actionEvent += dimensionAction;
            
            Action statusAction = new Action(statusCodeAlertObj.GenerateAlert);
            cNCMachineDataAnalyzer.actionEvent += statusAction;

            cNCMachineDataAnalyzer.AnalyzeTemperature();
            cNCMachineDataAnalyzer.AnalyzeDuration();
            cNCMachineDataAnalyzer.AnalyzeDimension();
            cNCMachineDataAnalyzer.AnalyzeStatusCode();
            Console.ReadLine();
        }
    }
}
