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
        static Dictionary<string, Sensor> dictForSaveInstances = new Dictionary<string, Sensor>();

        public void StartGame()
        {
            Console.WriteLine("Welcome to the investigation game!\nA game to detect Iranian agents using sensors.\nPlease enter the type of agent you would like to activate sensors on. (default is Foot soldier)");
            IranianAgent agent = ServiceAgent.CreateTypeAgent(Console.ReadLine());
            Console.WriteLine(agent);
            while (true)
            {
                Console.WriteLine("Please enter the type of sensor you would like to activate. (default is audio)");
                string inputSensor = Console.ReadLine();

                Sensor sensor = checkInstance(inputSensor);
                SensorVulnerabilityTesting(agent, sensor);

                int finish = agent.GetNumberSensorsContains() - agent.GetNumberSensorsAttached();
                if (finish <= 0)
                {
                    Console.WriteLine("********************************\n");
                    break;
                }
            }
        }
        public Sensor checkInstance(string inputSensor)
        {
            Sensor sensor;
            string[] typeOfSensors = Sensor.GetTypeOfSensors();
            if (dictForSaveInstances.ContainsKey(inputSensor))
            {
                sensor = dictForSaveInstances[inputSensor];
                return sensor;
            }
            else
            {
                if (typeOfSensors.Contains(inputSensor))
                {
                    sensor = ServiceSensor.CreateTypeSensor(inputSensor);
                    dictForSaveInstances[inputSensor] = sensor;
                    return sensor;
                }
                else
                {
                    sensor = ServiceSensor.CreateTypeSensor("audio");
                    dictForSaveInstances[inputSensor] = sensor;
                    return sensor;
                }
            }
        }

        public void SensorVulnerabilityTesting(IranianAgent agent, Sensor sensor)
        {
            List<string> agentList = agent.RemainedSensors;
            string sensorType = sensor.SensorType;

            int attached = agent.GetNumberSensorsAttached();
            int contains = agent.GetNumberSensorsContains();
            if (contains > attached)
            {
                if (agentList.Contains(sensorType))
                {
                    agent.RemoveSensorByValue(sensorType);
                    agent.AddNumberSensorsAttached();
                    sensor.Activate(agent);
                }
            }
            int newAttached = agent.GetNumberSensorsAttached();
            int newContains = agent.GetNumberSensorsContains();
            Console.WriteLine($"start: {newAttached}/{newContains}");
            if (newContains <= newAttached)
            {
                Console.WriteLine("The agent was exposed.");
            }
        }

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


            //public string[] GetRandomSensors()
            //{
            //    string[] sensors = { "basic", "termi" };
            //    Random random = new Random();
            //    string[] returnSensor = { sensors[random.Next(0, sensors.Length)], sensors[random.Next(0, sensors.Length)] };
            //    return returnSensor;
            //}
    }
}
