using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton_Pattern.RealWorldApproach
{
    internal class LoadBalancer
    {
        private static LoadBalancer loadBalancer = null;
        private List<string> _servers = new List<string>();
        private Random _random = new Random();
        private static object padLock = new object();

        protected LoadBalancer()
        {
            _servers.Add("Server I");
            _servers.Add("Server II");
            _servers.Add("Server III");
            _servers.Add("Server IV");
        }


        public static LoadBalancer GetLoadBalancer()
        {
            if (loadBalancer == null)
            {
                lock (padLock)
                {
                    if(loadBalancer == null)
                    {
                        loadBalancer = new LoadBalancer();
                    }
                }
            }
            return loadBalancer;
        }


        public string Server
        {
            get
            {
                int r = _random.Next(_servers.Count);
                return _servers[r].ToString();
            }
        }

    }
}
