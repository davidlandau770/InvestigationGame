using System;
using System.Collections.Generic;
using System.Linq;
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
