using StrategyAssignment.Interfaces;
using StrategyAssignment.Models;
using StrategyAssignment.Strategies;
using StrategyAssignment.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            CreationPricing();

            Random rand = new Random();
            List<Tshirt> tshirts = new List<Tshirt>();
            for (int i = 0; i < 40; i++)
            {
                Tshirt newTshirt = new Tshirt("Tshirt" + i, (Color)rand.Next(1, 7), (Size)rand.Next(1, 7), (Fabric)rand.Next(1, 7));
                tshirts.Add(newTshirt);
            }
            

        }

        private static void CreationPricing()
        {

            //Console.OutputEncoding = Encoding.UTF8;
            int fabric, size, color, paymentMethod;


            Menu menu = new Menu();

            while (true)
            {
                menu.FabricMenu();
                while (!(int.TryParse(Console.ReadLine(), out fabric) && (fabric >= 1 && fabric <= 7)))
                {
                    Console.WriteLine("Wrong Choice");
                    Console.WriteLine();
                    menu.FabricMenu();
                }

                menu.ColorMenu();
                while (!(int.TryParse(Console.ReadLine(), out color) && (color >= 1 && color <= 7)))
                {
                    Console.WriteLine("Wrong Choice");
                    Console.WriteLine();
                    menu.ColorMenu();
                }

                menu.SizeMenu();
                while (!(int.TryParse(Console.ReadLine(), out size) && (size >= 1 && size <= 7)))
                {
                    Console.WriteLine("Wrong Choice");
                    Console.WriteLine();
                    menu.SizeMenu();
                }

                Tshirt tshirt = new Tshirt("menuTshirt", (Color)(color - 1), (Size)(size - 1), (Fabric)(fabric - 1));

                menu.PaymentMethodMenu();
                while (!(int.TryParse(Console.ReadLine(), out paymentMethod) && (paymentMethod >= 1 && paymentMethod <= 3)))
                {
                    Console.WriteLine("Wrong Choice");
                    Console.WriteLine();
                    menu.PaymentMethodMenu();
                }

                IPaymentStrategy paymentStrategy = null;
                switch (paymentMethod)
                {

                    case 1:
                        paymentStrategy = new CreditPaymentStrategy();
                        break;
                    case 2:
                        paymentStrategy = new BankPaymentStrategy();
                        break;
                    case 3:
                        paymentStrategy = new CashPaymentStrategy();
                        break;

                }
                tshirt.SetPaymentStrategy(paymentStrategy);
                tshirt.Pay();

                Console.WriteLine();
                Console.WriteLine("Do you want to buy another Tshirt? Press 'yes'/'y'  to buy or any key to continue.");
                string answer = Console.ReadLine();
                if (!(answer.Equals("yes", StringComparison.InvariantCultureIgnoreCase) || answer.Equals("y", StringComparison.InvariantCultureIgnoreCase)))
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
