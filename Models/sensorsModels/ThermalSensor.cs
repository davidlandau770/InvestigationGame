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
            RevealsSensors = true;
            Broken = false;
            CancelsAttack = false;
            HowManyFieldsRevealing = 0;
        }
        public override void Activate(IranianAgent agent)
        {
            Console.WriteLine($"Exposure: The next sensor is: {agent.RemainedSensors[0]}");
        }
    }
}
