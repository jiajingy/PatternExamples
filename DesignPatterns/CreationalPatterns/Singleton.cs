using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.CreationalPatterns.Singleton
{
    /// <summary>
    /// Ensure a class has only one instance and provide a global point of access to it.
    /// https://www.dofactory.com/net/singleton-design-pattern
    /// </summary>
    sealed class LoadBalancer
    {
        private static readonly LoadBalancer _instance = new LoadBalancer();

        private List<Server> _servers;
        private Random _random = new Random();

        private LoadBalancer()
        {
            _servers = new List<Server>
            {
                new Server{ Name = "ServerI", IP = "120.14.220.18" },
                new Server{ Name = "ServerII", IP = "120.14.220.19" },
                new Server{ Name = "ServerIII", IP = "120.14.220.20" },
                new Server{ Name = "ServerIV", IP = "120.14.220.21" },
                new Server{ Name = "ServerV", IP = "120.14.220.22" },
            };
        }

        public static LoadBalancer GetLoadBalancer()
        {
            return _instance;
        }

        public Server NextServer
        {
            get
            {
                int r = _random.Next(_servers.Count);
                return _servers[r];
            }
        }



    }


    class Server
    {
        public string Name { get; set; }

        public string IP { get; set; }
    }
}
