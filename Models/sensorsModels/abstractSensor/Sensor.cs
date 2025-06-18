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
        public bool RevealsSensors { get; set; }
        public bool Broken { get; set; }
        public bool CancelsAttack { get; set; }
        public int HowManyFieldsRevealing { get; set; }
        public int Counter { get; set; }

        protected Random random = new Random();

        public abstract void Activate(IranianAgent agent);

        public override string ToString()
        {
            return $"{string.Join(", ", SensorType)}";
        }
    }
}
