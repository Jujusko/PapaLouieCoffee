using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaLouieCoffee.Logic.Ingridients
{
    public enum DrinkType
    {
        BlackTea,
        GreenTea,
        Macha,
        Arabica,
        Robusta,
        Default
    }
    public class DrinkBase : Ingridient, ILiquid
    {
        public DrinkType DrinkType { get; set; }
        public bool CaffeineFree { get; set; }
        public int CaffeinePerDose { get; set; }
        public int Mililiters { get; set; }

        public DrinkBase(string name, double kcal, int weight, int cost, DrinkType type, bool caffeintFree, int mililiters, int caffeineInDose = 0) 
            : base(name, kcal, weight, cost)
        {
            DrinkType = type;
            CaffeineFree = caffeintFree;
            Mililiters = mililiters;
            CaffeinePerDose = caffeineInDose;
        }

    }
}
