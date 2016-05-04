using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreditCartLibrary;

namespace PurseApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            CreditCart cr = new CreditCart(234);
            cr.ShowMoney();

            Console.ReadKey();
        }
    }
}
