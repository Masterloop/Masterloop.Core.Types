namespace Masterloop.Core.Types.LiveConnect
{
    public class LiveConnectionDetails
    {
        public string Server { get; set; }

        public int Port { get; set; }

        public bool UseSsl { get; set; }

        public string VirtualHost { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string QueueName { get; set; }

        public string ExchangeName { get; set; }
    }
}
