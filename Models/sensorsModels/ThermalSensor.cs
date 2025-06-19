using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame
{
    internal class ThermalSensor : Sensor
    {
        public ThermalSensor(string sensorType)
        {
            SensorType = sensorType;
        }
        public override void Activate(IranianAgent agent)
        {
            if (agent.RemainedSensors.Count > 0)
            {
                Console.WriteLine($"Exposure: The next sensor is: {agent.RemainedSensors[0]}");
            }
        }
    }
}
