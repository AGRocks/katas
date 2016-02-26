﻿namespace tennis_kata.core.Model
{
    public struct Score
    {
        private readonly Points receiver;
        private readonly Points server;

        public Score(Points server, Points receiver)
        {
            this.server = server;
            this.receiver = receiver;
        }

        public Points Receiver
        {
            get
            {
                return receiver;
            }
        }

        public Points Server
        {
            get
            {
                return server;
            }
        }
    }
}
