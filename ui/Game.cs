using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvestigationGame.newModels.agents;

namespace InvestigationGame
{
    internal class Game
    {
        //IranianAgent agent;
        //Sensor sensor;
        FootSoliderAgent footAgent;

        public void StartGame()
        {
            bool stop = true;
            while (stop)
            {
                Console.WriteLine("Welcome to the investigation game!\nA game to detect Iranian agents using sensors.\nPlease enter the type of agent you would like to activate sensors on.");
                IranianAgent agent = ServiceAgent.CreateTypeAgent(Console.ReadLine());
                agent.Activate();

                Console.WriteLine("sensor:");
                Sensor sensor = ServiceSensor.CreateTypeSensor(Console.ReadLine());
                sensor.Activate();
                SensorVulnerabilityTesting(agent, sensor);

                //string agentType = Console.ReadLine();
                //agent = new IranianAgent(agentType);
                //while (true)
                //{
                //    Console.WriteLine("Select which sensor you would like to activate on:\n(to exit enter '0')");
                //    //string[] arrSensorType = sensorType.Split(',');
                //    sensor = new Sensor(GetRandomSensors());
                //    Console.WriteLine($"Sensor: {sensor}");
                //    Console.WriteLine($"AgentType: {agent.AgentType}");
                //    Console.WriteLine($"IranianAgent: {agent}");
                //    SensorVulnerabilityTesting(sensor);
                //    Console.WriteLine($"Sensors attached: {agent.GetNumberSensorsAttached()}/{agent.GetNumberSensorsContains()}\n");

                //    int finish = agent.GetNumberSensorsContains() - agent.GetNumberSensorsAttached();
                //    if (finish <= 0)
                //    {
                //        Console.WriteLine("********************************\n");
                //        break;
                //    }
                //    string sensorType = Console.ReadLine();
                //    if (sensorType == "0")
                //    {
                //        stop = false;
                //        return;
                //    }
                //}
            }
        }

        public void SensorVulnerabilityTesting(IranianAgent agent, Sensor sensor)
        {
            List<string> list = agent.RemainedSensors;

            int contains = agent.GetNumberSensorsContains();
            int attached = agent.GetNumberSensorsAttached();
            if (contains > attached)
            {
                for (int i = 0; i < sensor.SensorsType.Length; i++)
                {
                    int index = 0;
                    bool isEqual = agent.RemoveIfEqual(sensor.SensorsType[i].Trim(), index);
                    if (isEqual)
                    {
                        index++;
                        agent.AttachingSensor();
                        Console.WriteLine(index);
                    }
                }
            }
            int newContains = agent.GetNumberSensorsContains();
            int newAttached = agent.GetNumberSensorsAttached();
            if (newContains <= newAttached)
            {
                Console.WriteLine("The agent was exposed.");
            }
        }

        //public string[] GetRandomSensors()
        //{
        //    string[] sensors = { "basic", "termi" };
        //    Random random = new Random();
        //    string[] returnSensor = { sensors[random.Next(0, sensors.Length)], sensors[random.Next(0, sensors.Length)] };
        //    return returnSensor;
        //}
    }
}
