using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace InvestigationGame
{
    internal abstract class Sensor
    {
        public string SensorType { get; set; }
        
        protected Random random = new Random();

        public abstract void Activate(IranianAgent agent);

        public static string[] GetTypeOfSensors()
        {
            string[] typeOfSensors = { "audio", "thermal", "pulse", "motion", "magnetic", "signal", "light" };
            return typeOfSensors;
        }

        public override string ToString()
        {
            return $"{string.Join(", ", SensorType)}";
        }
    }
}
