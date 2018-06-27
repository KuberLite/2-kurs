namespace Task4_1_
{
    public class Server
    {
        private static Server server;

        public string ServerName { get; private set; }

        public string IPAdress { get; private set; }

        protected Server (string _serverName, string _IPAdress)
        {
            this.ServerName = _serverName;
            this.IPAdress = _IPAdress;
        }

        public static Server GetServer(string _serverName, string _IPAdress)
        {

        }
    }
}