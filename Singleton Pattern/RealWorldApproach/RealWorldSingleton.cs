using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton_Pattern.RealWorldApproach
{
    public class RealWorldSingleton
    {
        public RealWorldSingleton()
        {
            LoadBalancer b1 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b2 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b3 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b4 = LoadBalancer.GetLoadBalancer();

            // Same instance?
            if (b1 == b2 && b2 == b3 && b3 == b4)
            {
                Console.WriteLine("Same instance\n");
            }

            // Load balance 15 server requests

            LoadBalancer balancer = LoadBalancer.GetLoadBalancer();

            Parallel.For( 0, 1500000, i => {
                string server = balancer.Server;
                Console.WriteLine("Dispatch Request to: " + server);
            });
            

            // Wait for user
            Console.ReadKey();

        }
    }
}
