using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCFService
{
    //[ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Single)]
    public class Users : IUsersContract
    {
        public string HelloWorld()
        {
            Console.WriteLine("123");
            return "xymhao";
        }
    }
}
