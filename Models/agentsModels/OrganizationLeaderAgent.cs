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
            SensorsType = GetRandomSensorType(NumberSensorsContains);
            RemainedSensors = new List<string>(SensorsType);
        }

        public override void Activate()
        {
            Console.WriteLine(AgentType);
            Console.WriteLine(NumberSensorsContains);
            Console.WriteLine(NumberSensorsAttached);
            Console.WriteLine(string.Join(",", SensorsType));
        }
    }
}
