using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame.newModels.agents
{
    internal class OrganizationLeaderAgent : IranianAgent
    {
        public OrganizationLeaderAgent(string agentType) : base(agentType)
        {
            AgentType = agentType;
            NumberSensorsContains = 8;
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
                RemainedSensors.Insert(0, SensorsType[0]);
                NumberSensorsAttached--;
                if (NumberSensorsAttached < 0)
                {
                    NumberSensorsAttached = 0;
                }
            }
            if (Counter % 10 == 0)
            {
                Console.WriteLine("In the \"Organization Leader\" agent, after 10 attempts, all sensors are returned.");
                RemainedSensors = new List<string>(SensorsType);
                NumberSensorsAttached = 0;
            }
        }
    }
}
