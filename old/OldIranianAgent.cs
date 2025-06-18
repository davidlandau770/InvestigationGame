using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame
{
    internal class OldIranianAgent
    {
        public string AgentType { get; set; }
        public int NumberSensorsContains { get; set; }
        public int NumberSensorsAttached {  get; set; }
        public int CountAttached { get; set; } = 0;
        public List<string> SensorsType { get; set; }
        public List<string> RemainedIdentifiable { get; set; }

        public OldIranianAgent(string agentType)
        {
            AgentType = agentType == "Squad Leader" ? "Squad Leader" : agentType == "Senior Commander" ? "Senior Commander" : agentType == "Organization Leader" ? "Organization Leader" : "Foot Soldier";
            NumberSensorsContains = CheckNumberSensorsContains();
            SensorsType = GetRandomSensorType();
            RemainedIdentifiable = new List<string>(SensorsType);
        }

        Random random = new Random();
        
        public void Activate()
        {
            CountAttached++;
            Console.WriteLine($"CountAttached: {CountAttached}");
            Console.WriteLine($"RemainedIdentifiable: {string.Join(", ", RemainedIdentifiable)}");
            if (AgentType == "Squad Leader")
            {
                if (CountAttached % 3 == 0)
                {
                    Console.WriteLine("########################################################################");
                    string[] arrSensorType = { "basic", "termi" };
                    ReturnSensor();
                    //CountAttached = 0;
                }
            } else if (AgentType == "Senior Commander")
            {
                
            } else if (AgentType == "Organization Leader")
            {
                if (CountAttached % 3 == 0)
                {
                    Console.WriteLine("########################################################################");
                    string[] arrSensorType = { "basic", "termi" };
                    ReturnSensor();
                    //CountAttached = 0;
                }
                Console.WriteLine($"----RemainedIdentifiable: {RemainedIdentifiable.Count}");
            }
            else
            {

            }
        }

        public void ReturnSensor()
        {
            int indexToAdd = SensorsType.Count - RemainedIdentifiable.Count - 1;
            if (indexToAdd >= 0)
            {
                RemainedIdentifiable.Insert(0, SensorsType[indexToAdd]);
            }

            Console.WriteLine(string.Join(", ", RemainedIdentifiable));

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
            return NumberSensorsAttached = SensorsType.Count - RemainedIdentifiable.Count;
        }

        public void AttachingSensor()
        {
            NumberSensorsAttached++;
        }

        public bool RemoveIfEqual(string sensor, int index)
        {
            //int index = 0;
            Console.WriteLine(index);
            try
            {
                if (sensor.Equals(RemainedIdentifiable[index]))
                {
                    Console.WriteLine("The linkage was successful.");
                    RemainedIdentifiable.RemoveAt(0);
                    Activate();
                    //index++;
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
            return $"{string.Join(", ", RemainedIdentifiable)}";
        }
    }
}
