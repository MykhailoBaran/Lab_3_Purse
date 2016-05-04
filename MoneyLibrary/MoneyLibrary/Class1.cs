using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyLibrary
{
    public class Money
    {
        private int kil;
        public Money(int kil)
        {
            this.kil = kil;
        }
        public void showKil() { Console.WriteLine("Kilkist = " + kil); }
    }
}
