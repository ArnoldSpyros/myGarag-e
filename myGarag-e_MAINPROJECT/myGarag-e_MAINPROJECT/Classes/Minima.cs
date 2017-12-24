using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myGarag_e_MAINPROJECT.Classes
{
    class Minima
    {
        string sender;
        string receiver;
        string content;
        DateTime timeSent;

        public Minima()
        {

        }

        public Minima(string sender, string receiver, string content, DateTime timeSent)
        {
            this.sender = sender;
            this.receiver = receiver;
            this.content = content;
            this.timeSent = timeSent;
        }


        public string Sender
        {
            get { return sender; }
            set { sender = value; }
        }
        
        public string Receiver
        {
            get { return receiver; }
            set { receiver = value; }
        }

        public string Content
        {
            get { return content; }
            set { content = value; }
        }

        public DateTime TimeSent
        {
            get { return timeSent; }
            set { timeSent = value; }
        }



    }
}
