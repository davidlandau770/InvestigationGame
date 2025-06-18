using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame
{
    internal class LightSensor : Sensor
    {
        public LightSensor(string sensorType)
        {
            SensorType = sensorType;
            RevealsSensors = false;
            Broken = false;
            CancelsAttack = false;
            HowManyFieldsRevealing = 2;
        }
        public override void Activate(IranianAgent agent)
        {
            Console.WriteLine(SensorType);
            Console.WriteLine(RevealsSensors);
            Console.WriteLine(Broken);
            Console.WriteLine(CancelsAttack);
            Console.WriteLine(HowManyFieldsRevealing);
        }
    }
}
