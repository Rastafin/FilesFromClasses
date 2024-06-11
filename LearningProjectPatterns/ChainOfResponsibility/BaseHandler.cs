using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal abstract class BaseHandler : IHandler
    {
        private IHandler? _nextHandler;
        public virtual void HandleRequest(string request)
        {
            if(_nextHandler != null)
            {
                _nextHandler.HandleRequest(request);
            }
            else
            {
                Console.WriteLine("Request cannot be handled");
            }
        }

        public IHandler SetNext(IHandler handler)
        {
            _nextHandler = handler;
            return handler;
        }
    }
}
