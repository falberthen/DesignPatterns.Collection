using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Creational.Singleton
{
    internal sealed class LoadBalancer
    {
        //Thread-Safe Singleton
        private static Lazy<LoadBalancer> Instance = new Lazy<LoadBalancer>(() => new LoadBalancer());

        private readonly List<Server> _servers;
        private readonly Random _random = new Random();

        /// <summary>
        /// Default constructor
        /// </summary>
        private LoadBalancer()
        {
            _servers = new List<Server>
            {
                 new Server{ Id = Guid.NewGuid(), Name = "Server", IP = "120.14.220.18" },
                 new Server{ Id = Guid.NewGuid(), Name = "Server", IP = "120.14.220.19" },
                 new Server{ Id = Guid.NewGuid(), Name = "Server", IP = "120.14.220.20" },
                 new Server{ Id = Guid.NewGuid(), Name = "Server", IP = "120.14.220.21" },
                 new Server{ Id = Guid.NewGuid(), Name = "Server", IP = "120.14.220.22" },
            };
        }

        /// <summary>
        /// Instance getter
        /// </summary>
        /// <returns></returns>
        public static LoadBalancer GetLoadBalancer()
        {
            return Instance.Value;
        }

        /// <summary>
        /// Returns the next random server
        /// </summary>
        public Server NextServer
        {
            get
            {
                var r = _random.Next(_servers.Count);
                return _servers[r];
            }
        }
    }
}
