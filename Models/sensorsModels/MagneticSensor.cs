using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame
{
    internal class MagneticSensor : Sensor
    {
        public MagneticSensor(string sensorType)
        {
            SensorType = sensorType;
            RevealsSensors = false;
            Broken = false;
            CancelsAttack = true;
            HowManyFieldsRevealing = 0;
        }

        public override void Activate(IranianAgent agent)
        {

        }
    }
}
