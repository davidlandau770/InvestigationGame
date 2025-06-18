using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame
{
    internal class OldSensor : Sensor
    {
        //IranianAgent agent;
        public string[] SensorsType { get; set; }
        
        public OldSensor(string[] sensorsType)
        {
            SensorsType = sensorsType;
        }

        public void Activate()
        {
        }

        public override string ToString()
        {
            return $"{string.Join(", ", SensorsType)}";
        }
    }
}
