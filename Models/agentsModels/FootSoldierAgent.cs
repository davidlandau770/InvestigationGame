using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame
{
    internal class FootSoliderAgent : IranianAgent
    {
        public FootSoliderAgent(string agentType) : base(agentType)
        {
            AgentType = agentType;
            NumberSensorsContains = 2;
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
