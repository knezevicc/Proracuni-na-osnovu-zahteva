using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Proracuni_na_osnovu_zahteva
{
    [DataContract]
    public class Audit
    {
        private static int next_id = 1;
        public Audit()
        {
            id = next_id++;
        }

        //*da li ce id biti INT ili STRING
        private int id;
        private DateTime Timestamp;
        private string MessageType;
        private string message;

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
        public string MessageType1 { 
            get => MessageType; 
            set => MessageType = value; 
        }
        [DataMember]
        public string Message { 
            get => message; 
            set => message = value; 
        }

        public Audit(int id, DateTime timestamp, string messageType, string message, DateTime timestamp1)
        {
            this.id = id;
            Timestamp = timestamp;
            MessageType = messageType;
            this.message = message;
            Timestamp1 = timestamp1;
        }

        /*
        public Audit()
        {
        }
        */
    }
}
