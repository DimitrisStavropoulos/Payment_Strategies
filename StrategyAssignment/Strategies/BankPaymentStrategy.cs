using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyAssignment.Interfaces;
using StrategyAssignment.Models;

namespace StrategyAssignment.Strategies
{
    class BankPaymentStrategy:IPaymentStrategy
    {
        public void DoPayment(Tshirt tshirt)
        {
            decimal basePrice = 0.0m;

            switch (tshirt.Fabric)
            {
                case Fabric.WOOL:
                case Fabric.COTTON:
                    basePrice = 25.0m;
                    break;
                case Fabric.POLYESTER:
                case Fabric.RAYON:
                    basePrice = 20.0m;
                    break;
                case Fabric.LINEN:
                case Fabric.CASHMERE:
                case Fabric.SILK:
                    basePrice = 35.0m;
                    break;
            }

            switch (tshirt.Size)
            {
                //Price change only for L+
                case Size.L:
                case Size.XL:
                case Size.XXL:
                case Size.XXXL:
                    basePrice += basePrice * 0.07m;
                    break;
            }

            switch (tshirt.Color)
            {
                case Color.RED:
                    break;
                case Color.ORANGE:
                    break;
                case Color.YELLOW:
                    break;
                case Color.GREEN:
                    break;
                case Color.BLUE:
                    break;
                case Color.INDIGO:
                    basePrice += basePrice * 0.03m;
                    break;
                case Color.VIOLET:
                    break;
                default:
                    break;
            }

            Console.WriteLine($"The price of your TShirt is: {basePrice:0.##}\u0024");
        }

    }
}
