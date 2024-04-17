using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COFImp
{
    internal interface IOrderApprover
    {
        decimal OrderApprovalLimit {  get; }
        void RequestOrderApproval(Order order);
    }
}
