using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PapaLouieCoffee.Logic.Ingridients
{
    /// <summary>
    /// Базовый класс ингредиента
    /// </summary>
    public class Ingridient
    {
        /// <summary>
        ///     Наименование
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Калорийность порции
        /// </summary>
        public double KCal { get; set; }

        /// <summary>
        /// Вес порции
        /// </summary>
        public int Weight { get; set; }
        /// <summary>
        /// Стоимость текущего ингредиента
        /// </summary>
        public int Cost { get; set; }

        public Ingridient(string name, double kcal, int weight, int cost ) 
        {
            Name = name;
            KCal = kcal;
            Weight = weight;
            Cost = cost;
        }
    }
}
