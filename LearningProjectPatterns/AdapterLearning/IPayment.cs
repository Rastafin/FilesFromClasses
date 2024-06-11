using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterLearning
{
    internal interface IPayment
    {
        void Pay(int amount);
    }
}
