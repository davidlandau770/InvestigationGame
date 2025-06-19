using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame
{
    internal class MotionSensor : Sensor, ICounter
    {
        public int Counter { get; set; }

        public MotionSensor(string sensorType)
        {
            SensorType = sensorType;
        }

        public override void Activate(IranianAgent agent)
        {
            // סליחה על האריכות, זה הרעיון הכי פשוט שעלה לי מבחינת יישום
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
                    for (int i = 0; i < lengthLoop; i++)
                    {
                        agent.RemainedSensors.Insert(0, SensorType);
                        agent.NumberSensorsAttached--;
                        Counter = 0;
                    }
                }
                if (agent.NumberSensorsAttached < 0)
                {
                    agent.NumberSensorsAttached = 0;
                }
            }

        }
    }
}
