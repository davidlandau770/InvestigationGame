using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame
{
    internal interface IIranianAgents
    {
        string AgentType { get; set; }
        List<string> SensorsType { get; set; }
        
        void Activate();
    }
}
