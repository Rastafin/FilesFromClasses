using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal class CEO : BaseHandler
    {
        public override void HandleRequest(string request)
        {
            if(request == "Approve Strategy")
            {
                Console.WriteLine("CEO handled request: " + request);
            }
            else
            {
                base.HandleRequest(request);
            }
        }
    }
}
