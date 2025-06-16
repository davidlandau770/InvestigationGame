using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame
{
    internal class IranianAgent : IIranianAgents
    {
        public string AgentType { get; set; }
        public int NumberSensorsContains { get; set; }
        public int NumberSensorsAttached {  get; set; }
        public List<string> SensorsType { get; set; }

        public IranianAgent(string agentType)
        {
            AgentType = agentType;
            NumberSensorsContains = CheckNumberSensorsContains();
            SensorsType = GetRandomSensorType();
        }

        static List<IranianAgent> iranianAgents = new List<IranianAgent>();

        public void Activate()
        {

        }

        public int CheckNumberSensorsContains()
        {
            if (AgentType == "Squad Leader") return 4;
            else if (AgentType == "Senior Commander") return 6;
            else if (AgentType == "Organization Leader") return 8;
            else return 2;
        }

        public List<string> GetRandomSensorType()
        {
            string[] arrSensorType = { "basic", "termi" };
            Random random = new Random();
            List<string> returnArrSensorType = new List<string>();
            for (int i = 0; i < NumberSensorsContains; i++)
            {
                returnArrSensorType.Add(arrSensorType[random.Next(0, 2)]);
            }
            return returnArrSensorType;
        }

        //public void AddToList(IranianAgent agent)
        //{
        //    iranianAgents.Add(agent);
        //} 

        public int GetNumberSensorsContains()
        {
            return NumberSensorsContains;
        }

        public int GetNumberSensorsAttached()
        {
            return NumberSensorsAttached;
        }

        public void AttachingSensor()
        {
            NumberSensorsAttached++;
        }

        public bool RemoveIfEqual(string sensor)
        {
            int index = 0;
            if (sensor.Equals(SensorsType[index])) {
                Console.WriteLine("The linkage was successful.");
                SensorsType.RemoveAt(0);
                index++;
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"{string.Join(", ", SensorsType)}";
        }
    }
}
