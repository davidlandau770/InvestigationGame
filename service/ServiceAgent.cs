using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvestigationGame.newModels.agents;

namespace InvestigationGame
{
    internal class ServiceAgent
    {
        public static IranianAgent CreateTypeAgent(string agentType)
        {
            if (agentType == "Squad Leader")
            {
                return new SquadLeaderAgent(agentType);
            }
            else if (agentType == "Senior Commander")
            {
                return new SeniorCommanderAgent(agentType);
            }
            else if (agentType == "Organization Leader")
            {
                return new OrganizationLeaderAgent(agentType);
            }
            else
            {
                return new FootSoliderAgent("Foot Soldier");
            }
        }
    }
}
