using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame
{
    internal class Game
    {
        IranianAgent agent;
        Sensor sensor;

        public void StartGame()
        {
            bool stop = true;
            Console.WriteLine("Welcome to the investigation game!\nA game to detect Iranian agents using sensors.\nPlease enter the type of agent you would like to activate sensors on.");
            string agentType = Console.ReadLine();
            agent = new IranianAgent(agentType);
            while (true)
            {
                Console.WriteLine("Select which sensor you would like to activate on:\n(to exit enter '0')");
                string sensorType = Console.ReadLine();
                if (sensorType == "0")
                {
                    return;
                }
                string[] arrSensorType = sensorType.Split(',');
                sensor = new Sensor(arrSensorType);
                //agent.AddToList(agent);
                Console.WriteLine($"Sensor: {sensor.ToString()}");
                Console.WriteLine($"IranianAgent: {agent.ToString()}");
                SensorVulnerabilityTesting(sensor);
                Console.WriteLine($"{agent.GetNumberSersrorsAttached()}/{agent.GetNumberSersrorsContains()}");
            }
        }

        public void SensorVulnerabilityTesting(Sensor sensor)
        {
            int contains = agent.GetNumberSersrorsContains();
            int attached = agent.GetNumberSersrorsAttached();
            if (contains > attached)
            {
                for (int i = 0; i < sensor.SensorsType.Length; i++)
                {
                    //sensor.SensorsType[i].Trim();
                    bool isEqual = agent.IsEqual(sensor.SensorsType[i].Trim());
                    if (isEqual)
                    {
                        agent.AttachingSensor();
                    }
                }
            }
            int newContains = agent.GetNumberSersrorsContains();
            int newAttached = agent.GetNumberSersrorsAttached();
            if (newContains <= newAttached)
            {
                Console.WriteLine("The agent was exposed.");
            }
        }
    }
}
