using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Proracuni_na_osnovu_zahteva
{
    [DataContract]
    public class Load {
        //generisanje jedinstveog id za svaki unos:
        private static int next_id = 1;
        public Load() { 
            id = next_id++; 
        }

        //*da li ce id biti INT ili STRING
        private int id;
        private DateTime Timestamp;
        private float MeasuredValue;

        [DataMember]
        public int Id { 
            get => id; 
            set => id = value; 
        }
        [DataMember]
        public DateTime Timestamp1 { 
            get => Timestamp; 
            set => Timestamp = value; 
        }
        [DataMember]
        public float MeasuredValue1 { 
            get => MeasuredValue; 
            set => MeasuredValue = value; 
        }
        public Load(int id, DateTime timestamp, float measuredValue)
        {
            this.id = id;
            Timestamp = timestamp;
            MeasuredValue = measuredValue;
        }

        /*
        public Load()
        {
        }
        */
    }
}
