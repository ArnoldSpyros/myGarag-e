using System;

namespace myGarag_e_MAINPROJECT.Classes
{
    public class Minima
    {
        private User sender;
        private User receiver;
        private string content;
        private DateTime timeSet;

        public Minima(){ }

        public Minima(User sender, User receiver, string content, DateTime timeSet)
        {
            this.sender = sender;
            this.receiver = receiver;
            this.content = content;
            this.timeSet = timeSet;
        }

        public string Content { get => content; set => content = value; }
        public DateTime TimeSet { get => timeSet; set => timeSet = DateTime.Now; }
        internal User Sender { get => sender; set => sender = value; }
        internal User Receiver { get => receiver; set => receiver = value; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}