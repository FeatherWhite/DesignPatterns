using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework;
using IDCard;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory = new IDCardFactory();
            Product card1 = factory.Create("小明");
            Product card2= factory.Create("小红");
            Product card3 = factory.Create("小刚");
            card1.Use();
            card2.Use();
            card3.Use();
            Console.ReadLine();
        }
    }
}
