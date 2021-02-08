using StrategyAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyAssignment.Interfaces
{
    interface IPaymentStrategy
    {

        void DoPayment(Tshirt tshirt);
    }
}
