using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame
{
    internal class SignalSensor : Sensor, IRevealingFields
    {
        public int HowManyFieldsRevealing { get; set; }

        public SignalSensor(string sensorType)
        {
            SensorType = sensorType;
            HowManyFieldsRevealing = 1;
        }
        public override void Activate(IranianAgent agent)
        {
            Console.WriteLine($"Exposure: The agent's rank is: {agent.AgentType}");
        }
    }
}
