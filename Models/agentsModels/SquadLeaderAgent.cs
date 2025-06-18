using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame.newModels.agents
{
    internal class SquadLeaderAgent : IranianAgent
    {
        public SquadLeaderAgent(string agentType) : base(agentType)
        {
            AgentType = agentType;
            NumberSensorsContains = 4;
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
                RemainedSensors.Insert(0, SensorsType[random.Next(0,numberOfSensorAttachments)]);
                NumberSensorsAttached--;
                if (NumberSensorsAttached < 0)
                {
                    NumberSensorsAttached = 0;
                }
            }
        }
    }
}
