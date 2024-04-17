using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class Handler2 : Handler
    {
        public override void HandleRequest(Request request)
        {
            if (request.Value > 10 && request.Value < 100)
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
