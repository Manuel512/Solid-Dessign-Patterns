using System;
using System.Collections.Generic;
using System.Text;

namespace DessignPatterns.Factory_Pattern.Abstract_Factory
{
    public interface IHotDrinkFactory
    {
        IHotDrink Prepare(int amount);
    }
}
