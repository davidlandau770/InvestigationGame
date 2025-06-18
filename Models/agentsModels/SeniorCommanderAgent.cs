using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame.newModels.agents
{
    internal class SeniorCommanderAgent : IranianAgent
    {
        public SeniorCommanderAgent(string agentType) : base(agentType)
        {
            AgentType = agentType;
            NumberSensorsContains = 6;
            Counter = 0;
            SensorsType = GetRandomSensorType(NumberSensorsContains);
            RemainedSensors = new List<string>(SensorsType);
        }

        public override void Activate()
        {
            Counter++;
            if (Counter % 3 == 0)
            {
                int numberOfSensorAttachments = NumberSensorsContains - NumberSensorsAttached;
                RemainedSensors.Insert(0, SensorsType[random.Next(0, numberOfSensorAttachments)]);
                RemainedSensors.Insert(0, SensorsType[random.Next(0, numberOfSensorAttachments)]);
                NumberSensorsAttached -= 2;
            }
        }
    }
}
