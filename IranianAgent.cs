using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
        public List<string> RemainedIdentifiable { get; set; }

        public IranianAgent(string agentType)
        {
            AgentType = agentType == "Squad Leader" ? "Squad Leader" : agentType == "Senior Commander" ? "Senior Commander" : agentType == "Organization Leader" ? "Organization Leader" : "Foot Soldier";
            NumberSensorsContains = CheckNumberSensorsContains();
            SensorsType = GetRandomSensorType();
            RemainedIdentifiable = new List<string>(SensorsType);
        }

        Random random = new Random();
        
        public void Activate()
        {
            int count = 0;
            count++;
            if (AgentType == "Squad Leader")
            {
                if (count == 3)
                {
                    string[] arrSensorType = { "basic", "termi" };
                    RemainedIdentifiable.Insert(0, arrSensorType[random.Next(0, 2)]);

                }
            } else if (AgentType == "Senior Commander")
            {
                
            } else if (AgentType == "Organization Leader")
            {
                if (count == 3)
                {
                    string[] arrSensorType = { "basic", "termi" };
                    RemainedIdentifiable.Insert(0, arrSensorType[random.Next(0, 2)]);
                }
            }
            else
            {

            }
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
            try
            {
                if (sensor.Equals(RemainedIdentifiable[index]))
                {
                    Console.WriteLine("The linkage was successful.");
                    RemainedIdentifiable.RemoveAt(0);
                    Activate();
                    index++;
                    return true;
                }
            }
            catch (Exception ex)
            {
            }
            return false;
        }

        public override string ToString()
        {
            return $"{string.Join(", ", SensorsType)}";
        }
    }
}
