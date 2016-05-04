using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCartLibrary
{
    public class CreditCart
    {
        private int money;

        public CreditCart(int money)
        {
            this.money = money;
        }

        public void ShowMoney()
        {
            Console.WriteLine("Money = " + money);
        }
    }
}
