using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyAssignment.Utils
{
    class Menu
    {
        public void FabricMenu()
        {
            Console.WriteLine("Select fabric:");
            Console.WriteLine("1. WOOL");
            Console.WriteLine("2. COTTON");
            Console.WriteLine("3. POLYESTER");
            Console.WriteLine("4. RAYON");
            Console.WriteLine("5. LINEN");
            Console.WriteLine("6. CASHMERE");
            Console.WriteLine("7. SILK");
            Console.Write(">>");
        }

        public void ColorMenu()
        {
            Console.WriteLine("Select color:");
            Console.WriteLine("1. RED");
            Console.WriteLine("2. ORANGE");
            Console.WriteLine("3. YELLOW");
            Console.WriteLine("4. GREEN");
            Console.WriteLine("5. BLUE");
            Console.WriteLine("6. INDIGO");
            Console.WriteLine("7. VIOLET");
            Console.Write(">>");
        }

        public void SizeMenu()
        {
            Console.WriteLine("Select size:");
            Console.WriteLine("1. XS");
            Console.WriteLine("2. S");
            Console.WriteLine("3. M");
            Console.WriteLine("4. L");
            Console.WriteLine("5. XL");
            Console.WriteLine("6. XXL");
            Console.WriteLine("7. XXXL");
            Console.Write(">>");
        }

        public void PaymentMethodMenu()
        {
            Console.WriteLine("Select Payment Method:");
            Console.WriteLine("1. CREDIT CARD");
            Console.WriteLine("2. BANK TRANSFER");
            Console.WriteLine("3. CASH");
        }

        
    }
}
