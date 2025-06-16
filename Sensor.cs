using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame
{
    internal class Sensor : ISensors
    {
        //IranianAgent agent;
        public string[] SensorsType { get; set; }
        
        public Sensor(string[] sensorsType)
        {
            SensorsType = sensorsType;
        }

        public void Activate()
        {
            //    int i = 0;
            //    while (i < agent.NumberSensors)
            //    {
            //        string sensorOfAgent = agent.GetSensorsTypeByIndex(i);
            //        if (sensorOfAgent = )
            //        i++;
            //    }
        }

        public override string ToString()
        {
            return $"{string.Join(", ", SensorsType)}";
        }
    }
}
