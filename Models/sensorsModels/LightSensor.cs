using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame
{
    internal class LightSensor : Sensor
    {
        public LightSensor(string sensorType)
        {
            SensorType = sensorType;
            //RevealsSensors = false;
            //Broken = false;
            //CancelsAttack = false;
            HowManyFieldsRevealing = 2;
        }
        public override void Activate(IranianAgent agent)
        {
            Console.WriteLine($"Exposure: The agent's rank is: {agent.AgentType}\nExposure: The sensors you have left to attach to the agent: {string.Join(", ",agent.RemainedSensors)}");
        }
    }
}
