using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame
{
    internal class PulseSensor : Sensor
    {
        public PulseSensor(string sensorType)
        {
            SensorType = sensorType;
            RevealsSensors = false;
            Broken = true;
            CancelsAttack = false;
            HowManyFieldsRevealing = 0;
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
