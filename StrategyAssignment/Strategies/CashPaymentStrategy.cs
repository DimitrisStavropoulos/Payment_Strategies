using StrategyAssignment.Interfaces;
using StrategyAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyAssignment.Strategies
{
    class CashPaymentStrategy : IPaymentStrategy
    {
        public void DoPayment(Tshirt tshirt)
        {
            decimal basePrice = 0.0m;

            switch (tshirt.Fabric)
            {
                case Fabric.WOOL:
                case Fabric.COTTON:
                    basePrice = 20.0m;
                    break;
                case Fabric.POLYESTER:
                case Fabric.RAYON:
                    basePrice = 15.0m;
                    break;
                case Fabric.LINEN:
                case Fabric.CASHMERE:
                case Fabric.SILK:
                    basePrice = 30.0m;
                    break;
            }

            switch (tshirt.Size)
            {
                //Price change only for L+
                case Size.L:
                case Size.XL:
                case Size.XXL:
                case Size.XXXL:
                    basePrice += basePrice * 0.05m;
                    break;
            }

            //Price is the same for all colors

            Console.WriteLine($"The price of your TShirt is: {basePrice:0.##}\u0024");
        }

  
    }
}
