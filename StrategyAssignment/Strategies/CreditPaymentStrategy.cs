using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyAssignment.Interfaces;
using StrategyAssignment.Models;

namespace StrategyAssignment.Strategies
{
    class CreditPaymentStrategy:IPaymentStrategy
    {
        public void DoPayment(Tshirt tshirt)
        {
            decimal basePrice = 0.0m;

            switch (tshirt.Fabric)
            {
                case Fabric.WOOL:
                case Fabric.COTTON:
                    basePrice = 30.0m;
                    break;
                case Fabric.POLYESTER:
                case Fabric.RAYON:
                    basePrice = 25.0m;
                    break;
                case Fabric.LINEN:
                case Fabric.CASHMERE:
                case Fabric.SILK:
                    basePrice = 40.0m;
                    break;
            }

            switch (tshirt.Size)
            {
                case Size.M:
                    basePrice += basePrice * 0.05m;
                    break;
                case Size.L:
                case Size.XL:
                case Size.XXL:
                case Size.XXXL:
                    basePrice += basePrice * 0.1m;
                    break;
            }

            switch (tshirt.Color)
            {
                case Color.RED:
                case Color.BLUE:
                case Color.GREEN:
                case Color.YELLOW:
                    basePrice += basePrice * 0.03m;
                    break;
                case Color.ORANGE:
                case Color.INDIGO:
                case Color.VIOLET:
                    basePrice += basePrice * 0.07m;
                    break;
               
            }

            Console.WriteLine($"The price of your TShirt is: {basePrice:0.##}\u0024");
        }


    }
}
