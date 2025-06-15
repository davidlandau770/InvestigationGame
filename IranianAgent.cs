using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame
{
    internal class IranianAgent
    {
        public string AgentType { get; private set; }
        public int NumberSensors { get; private set; }
        public Sensor[] SensorsType { get; private set; }

        public IranianAgent(string agentType, int numberSensors, Sensor[] sensorsType)
        {
            AgentType = agentType;
            NumberSensors = 2;
            SensorsType = sensorsType;
        }
    }
}
