using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame
{
    internal class MotionSensor : Sensor
    {
        public MotionSensor(string sensorType)
        {
            SensorType = sensorType;
        }
        public override void Activate(IranianAgent agent)
        {
        }
    }
}
