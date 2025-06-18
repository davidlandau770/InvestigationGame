using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvestigationGame.newModels.agents;

namespace InvestigationGame
{
    internal class ServiceSensor
    {
        public static Sensor CreateTypeSensor(string sensorType)
        {
            if (sensorType == "thermal")
            {
                return new ThermalSensor(sensorType);
            }
            else if (sensorType == "pulse")
            {
                return new PulseSensor(sensorType);
            }
            else if (sensorType == "motion")
            {
                return new MotionSensor(sensorType);
            }
            else if (sensorType == "magnetic")
            {
                return new MagneticSensor(sensorType);
            }
            else if (sensorType == "signal")
            {
                return new SignalSensor(sensorType);
            }
            else if (sensorType == "light")
            {
                return new LightSensor(sensorType);
            }
            else
            {
                return new AudioSensor("audio");
            }
        }
    }
}
