using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Proracuni_na_osnovu_zahteva
{
    public class Load {

        private string id;
        private DateTime Timestamp;
        private float MeasuredValue;

        public string Id { 
            get => id; 
            set => id = value; 
        }
        public DateTime Timestamp1 { 
            get => Timestamp; 
            set => Timestamp = value; 
        }
        public float MeasuredValue1 { 
            get => MeasuredValue; 
            set => MeasuredValue = value; 
        }

        public Load(string id, DateTime timestamp, float measuredValue)
        {
            this.id = id;
            Timestamp = timestamp;
            MeasuredValue = measuredValue;
        }

        public Load()
        {
        }
    }
}
