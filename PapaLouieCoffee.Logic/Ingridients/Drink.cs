using System.Drawing;
using System.Linq;

namespace PapaLouieCoffee.Logic.Ingridients
{

    public enum DrinkSize
    {
        S,
        M,
        L,
        XXL
    }
    public class Drink
    {
        public string Name { get; private set; }

        public List<Ingridient> Ingridients { get; set; }

        private DrinkSize _size;

        private int _drink_V;

        private int _totalCost;
        private double _totalKcal;
        public Drink(List<Ingridient> ingridients, string name, DrinkSize size)
        {
            Name = name;
            Ingridients = ingridients;
            _size = size;

            AssemblyDrink(ingridients);
            WriteDataForUser();
        }

     

        private void AssemblyDrink(List<Ingridient> ingrs)
        {
            if (ingrs.Any(x => x is DrinkBase))
            {
                DrinkBase @base = ingrs.First(x => x is DrinkBase) as DrinkBase;
                Console.WriteLine($"В основе у нас будет находиться {@base.Name}");

                _totalCost += @base.Cost;
                _totalKcal += @base.KCal;

                _drink_V += @base.Mililiters;

                ingrs.Remove(@base);

            }

            //Добавляем оставшиеся ингредиенты
            foreach (Ingridient ingr in ingrs)
            {

                _totalKcal += ingr.KCal;
                _totalCost += ingr.Cost;

                if (ingr is ILiquid)
                {
                    _drink_V += (ingr as ILiquid).Mililiters;
                }

                Console.WriteLine($"К основе мы добавляем {ingr.Name}");
            }


            //Надбавка к стоимости продукта за работу 
            var baristaTaxes = _totalCost * 0.4;

            //Надбавка к стоимости за аренду помещения
            var placeTaxes = _totalCost * 0.1;

            switch (_size)
            {
                case (DrinkSize.S):
                    {
                        _totalCost += 50;
                        _drink_V += 200;
                        break;
                    }
                case (DrinkSize.M):
                    {
                        _totalCost += 80;
                        _drink_V += 300;
                        break;
                    }
                case (DrinkSize.L):
                    {
                        _totalCost += 100;
                        _drink_V += 400;
                        break;
                    }
                case (DrinkSize.XXL):
                    {
                        _totalCost += 120;
                        _drink_V += 500;
                        break;
                    }
            }


            _totalCost += (int)baristaTaxes;
            _totalCost += (int)placeTaxes;
        }

        /// <summary>
        /// Вывести дату о готовом напитке для пользователя
        /// </summary>
        private void WriteDataForUser()
        {
            Console.WriteLine($"Напиток {Name} готов к подаче. Калорийность напитка: {_totalKcal} и объёмом {_drink_V} миллилитров. Плати {_totalCost} денег.");
        }
    }
}