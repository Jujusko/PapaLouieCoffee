using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaLouieCoffee.Logic.Ingridients
{

    public enum SyropTaste
    {
        SaltyCaramel,
        Caramel,
        HazzleNut,
        Choko,
        Coconut,
        Vanila,
        Banana
    }

    public class Syrop : Ingridient, ILiquid
    {
        public Syrop(string name, double kcal, int weight, int cost, bool sugarFree, SyropTaste taste, int mililiters) : base(name, kcal, weight, cost)
        {
            Mililiters = mililiters;
            IsSugarFree = sugarFree;
            SyropTaste = taste;
        }

        public bool IsSugarFree { get; set; }
        public SyropTaste SyropTaste { get; set; }

        public int Mililiters { get; set; }

    }
}
