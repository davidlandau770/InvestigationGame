using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame
{
    internal class AudioSensor : Sensor
    {
        public AudioSensor(string sensorType)
        {
            SensorType = sensorType;
        }
        public override void Activate(IranianAgent agent)
        {

        }
    }
}
