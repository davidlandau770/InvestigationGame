using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvestigationGame.newModels.agents;

namespace InvestigationGame
{
    internal abstract class IranianAgent
    {
        public string AgentType { get; set; }
        public int NumberSensorsContains { get; set; }
        public int NumberSensorsAttached { get; set; } = 0;
        public int CountAttached { get; set; } = 0;
        public List<string> SensorsType { get; set; }
        public List<string> RemainedSensors { get; set; }

        protected Random random = new Random();

        public IranianAgent(string agentType)
        {
            SensorsType = new List<string>();
            RemainedSensors = new List<string>();
        }

        public abstract void Activate();

        protected List<string> GetRandomSensorType(int numberSensors)
        {
            string[] arrSensorType = Sensor.GetTypeOfSensors();
            List<string> returnArrSensorType = new List<string>();
            for (int i = 0; i < numberSensors; i++)
            {
                returnArrSensorType.Add(arrSensorType[random.Next(0, arrSensorType.Length)]);
            }
            return returnArrSensorType;
        }
        
        public void RemoveSensorByValue(string value)
        {
            RemainedSensors.Remove(value);
        }

        public void AddNumberSensorsAttached()
        {
            NumberSensorsAttached++;
        }

        public int GetNumberSensorsContains()
        {
            return NumberSensorsContains;
        }

        public int GetNumberSensorsAttached()
        {
            return NumberSensorsAttached;
        }

        public override string ToString()
        {
            return $"AgentType: {AgentType}, NumberSensorsContains: {NumberSensorsContains}, NumberSensorsAttached: {NumberSensorsAttached}, CountAttached: {CountAttached}, SensorsType: ({string.Join(", ", SensorsType)})";
        }
    }
}
