// See https://aka.ms/new-console-template for more information
using PapaLouieCoffee.Logic.Ingridients;


// Выбор пользователем ингредиентов
DrinkBase osnova = new DrinkBase("Мача", 13, 30, 60, DrinkType.Macha, true, 60);
Syrop syrop = new("Пина-колада", 120, 60, 120, false, SyropTaste.Coconut, 30);
Crisps ukrop = new Crisps("Укроп", 12, 15, 20);


//Создание списка ингредиентов для кухни
List<Ingridient> list = new List<Ingridient>();
list.Add(syrop);
list.Add(osnova);
list.Add(ukrop);

//Изготовление самого напитка
Drink drink = new Drink(list, "Моча первородная", DrinkSize.L);
