using System;
using System.Collections.Generic;
using System.Text;

namespace DessignPatterns.Factory_Pattern.Abstract_Factory
{
    internal class Coffee : IHotDrink
    {
        public void Consume()
        {
            Console.WriteLine("This coffee is sensational!");
        }
    }
}
