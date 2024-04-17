using COFImp.Sevices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COFImp.Employees
{
    internal class LowLevelEmployee : Employee
    {
        public override decimal OrderApprovalLimit => 1000;

        public override int Level => 1;

        public override void RequestOrderApproval(Order order)
        {
            if (order == null) return;

            if(order.Value <= OrderApprovalLimit)
            {
                new MailServices().SendEmail(string.Format("{0}.{1}@uni.lodz.pl", this.FirstName, this.LastName), "Order approval request was sent");
            }
            else if(this.Supervisor != null)
            {
                this.Supervisor.RequestOrderApproval(order);
            }
            else
            {
                Console.WriteLine("Order cannot be approved");
            }
        }
    }
}
