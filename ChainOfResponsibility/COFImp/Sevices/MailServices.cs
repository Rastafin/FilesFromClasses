using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COFImp.Sevices
{
    internal class MailServices
    {
        public void SendEmail(string email, string body)
        {
            Console.WriteLine("Email with request {0} was sent to {1}", email, body);
        }
    }
}
