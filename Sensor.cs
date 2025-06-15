using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame
{
    internal class Sensor
    {
        public string[] SensorsType { get; private set; }
        
        public Sensor()
        {
            SensorsType = GetRandomSensorType();
        }

        public string[] GetRandomSensorType()
        {
            string[] arrSensorType = { "basic", "termi" };
            Random random = new Random();
            string[] returnArrSensorType = { arrSensorType[random.Next(0, 1)], arrSensorType[random.Next(0, 1)] };
            return arrSensorType;
        }

    }
}
