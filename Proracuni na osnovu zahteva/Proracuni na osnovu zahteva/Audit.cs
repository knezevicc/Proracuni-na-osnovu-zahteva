using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proracuni_na_osnovu_zahteva
{
    public class Audit
    {
        private string id;
        private DateTime Timestamp;
        private string MessageType;
        private string message;

        public string Id {
            get => id; 
            set => id = value; 
        }
        public DateTime Timestamp1 { 
            get => Timestamp; 
            set => Timestamp = value; 
        }
        public string MessageType1 { 
            get => MessageType; 
            set => MessageType = value; 
        }
        public string Message { 
            get => message; 
            set => message = value; 
        }

        public Audit(string id, DateTime timestamp, string messageType, string message, DateTime timestamp1)
        {
            this.id = id;
            Timestamp = timestamp;
            MessageType = messageType;
            this.message = message;
            Timestamp1 = timestamp1;
        }

        public Audit()
        {
        }
    }
}
