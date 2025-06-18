using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame
{
    internal class SignalSensor : Sensor
    {
        public SignalSensor(string sensorType)
        {
            SensorType = sensorType;
            RevealsSensors = false;
            Broken = false;
            CancelsAttack = false;
            HowManyFieldsRevealing = 1;
        }
        public override void Activate()
        {
            Console.WriteLine(SensorType);
            Console.WriteLine(RevealsSensors);
            Console.WriteLine(Broken);
            Console.WriteLine(CancelsAttack);
            Console.WriteLine(HowManyFieldsRevealing);
        }
    }
}
