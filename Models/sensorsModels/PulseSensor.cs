using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
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
            Counter = 0;
        }

        public override void Activate(IranianAgent agent)
        {
            Counter++;
            if (Counter == 3)
            {
                int countTotal = 0;
                int temporaryCount = 0;
                for (int i = 0; i < agent.SensorsType.Count; i++)
                {
                    if (agent.SensorsType[i] == SensorType)
                    {
                        countTotal++;
                    }
                }
                for (int i = 0; i < agent.RemainedSensors.Count; i++)
                {
                    if (agent.RemainedSensors[i] == SensorType)
                    {
                        temporaryCount++;
                    }
                }
                int lengthLoop = countTotal - temporaryCount;
                if (lengthLoop > 0)
                {
                    for (int i = 0;i < lengthLoop; i++)
                    {
                        agent.RemainedSensors.Insert(0, SensorType);
                        agent.NumberSensorsAttached--;
                        Counter = 0;
                    }
                }
            }
        }
    }
}
