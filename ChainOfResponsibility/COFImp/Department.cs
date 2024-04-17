using COFImp.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COFImp
{
    internal class Department : IOrderApprover
    {
        public required string Name { get; set; }
        public List<Employee> Employees { get; } = [];

        public decimal OrderApprovalLimit => decimal.MaxValue;

        public void RequestOrderApproval(Order order)
        {
            (Employees.Where(employee => employee.Level == 1)).ToList().ForEach(employee =>
            {
                employee.RequestOrderApproval(order);
            });
        }

    }
}
