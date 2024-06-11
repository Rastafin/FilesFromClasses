using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal class Manager : BaseHandler
    {
        public override void HandleRequest(string request)
        {
            if(request == "Approve Budget")
            {
                Console.WriteLine("Manager handled request: " + request);
            }
            else
            {
                base.HandleRequest(request);
            }
        }
    }
}
