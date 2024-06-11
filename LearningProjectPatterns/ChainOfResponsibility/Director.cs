using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal class Director : BaseHandler
    {
        public override void HandleRequest(string request)
        {
            if (request == "Approve Project")
            {
                Console.WriteLine("Director handled request: " + request);
            }
            else
            {
                base.HandleRequest(request);
            }
        }
    }
}
