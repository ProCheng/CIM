using CIM.IServers.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIM.Servers.Test
{
    public class Test1Servers : ITest1Servers
    {
        public void Add()
        {
            Console.WriteLine("Test1");
        }
    }
}
