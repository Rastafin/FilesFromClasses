using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class Handler3 : Handler
    {
        public override void HandleRequest(Request request)
        {
            if (request.Value > 100 && request.Value < 1000)
            {
                Console.WriteLine("Request {0} was handled by {1}", request.Name, this);
            }
            else if (successor != null && request != null)
            {
                successor.HandleRequest(request);
            }
            else
            {
                Console.WriteLine("Request cannot be handled");
            }
        }
    }
}
