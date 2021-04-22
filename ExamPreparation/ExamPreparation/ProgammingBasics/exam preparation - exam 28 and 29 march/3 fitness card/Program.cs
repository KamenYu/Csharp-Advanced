using System;
namespace _3_fitness_card
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пол      Gym          Boxing        Yoga         Zumba      Dances      Pilates
            //мъж	  $42           $41          $45             $34         $51            $39
            //жена    $35           $37          $42             $31         $53            $37

            //Всички цени на карти за ученици(възраст под 19 години вкл.) са с 20 % намаление.

            //•	Сумата, с която разполагаме - реално число в интервала[10.00…1000.00]
            //•	Пол - символ('m' за мъж и 'f' за жена)
            //•	Възраст - цяло число в интервала[5…105]
            //•	Спорт - текст(една от възможностите в таблицата)

            //•	Ако сумата е достатъчна:
            //"You purchased a 1 month pass for {sport}."
            //където { sport} е въведения тип спорт
            //•	Ако сумата не е достатъчна трябва да се пресметне колко още пари са необходими, за да се закупи карта:
            //"You don't have enough money! You need ${money} more."
            //където { money} e оставащата сума нужна, за да се закупи картата, форматирана до втория знак след десетичната запетая.

            double moneyAmount = double.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine()); // m or f
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine(); // Gym, Boxing, Yoga, Zumba, Dances, Pylates
            double sum = 0;
            

            if (age <= 19)
            {
                if (gender == 'm')
                {
                    if (sport == "Gym")
                    {
                        sum = 42 - (42 * 0.2);
                    }
                    else if (sport == "Boxing")
                    {
                        sum = 41 - (41 * 0.2);
                    }
                    else if (sport == "Yoga")
                    {
                        sum = 45 - (45 * 0.2);
                    }
                    else if (sport == "Zumba")
                    {
                        sum = 34 - (34 * 0.2);
                    }
                    else if (sport == "Dances")
                    {
                        sum = 51 - (51 * 0.2);
                    }
                    else if (sport == "Pilates")
                    {
                        sum = 39 - (39 * 0.2);
                    }
                }
                else if (gender == 'f')
                {
                    if (sport == "Gym")
                    {
                        sum = 35 - (35 * 0.2);
                    }
                    else if (sport == "Boxing")
                    {
                        sum = 37 - (37 * 0.2);
                    }
                    else if (sport == "Yoga")
                    {
                        sum = 42 - (42 * 0.2);
                    }
                    else if (sport == "Zumba")
                    {
                        sum = 31 - (31 * 0.2);
                    }
                    else if (sport == "Dances")
                    {
                        sum = 53 - (53 * 0.2);
                    }
                    else if (sport == "Pilates")
                    {
                        sum = 37 - (37 * 0.2);
                    }
                }
            }
            else
            {
                if (gender == 'm')
                {
                    if (sport == "Gym")
                    {
                        sum = 42;
                    }
                    else if (sport == "Boxing")
                    {
                        sum = 41;
                    }
                    else if (sport == "Yoga")
                    {
                        sum = 45;
                    }
                    else if (sport == "Zumba")
                    {
                        sum = 34;
                    }
                    else if (sport == "Dances")
                    {
                        sum = 51;
                    }
                    else if (sport == "Pilates")
                    {
                        sum = 39;
                    }
                }
                else if (gender == 'f')
                {
                    if (sport == "Gym")
                    {
                        sum = 35;
                    }
                    else if (sport == "Boxing")
                    {
                        sum = 37;
                    }
                    else if (sport == "Yoga")
                    {
                        sum = 42;
                    }
                    else if (sport == "Zumba")
                    {
                        sum = 31;
                    }
                    else if (sport == "Dances")
                    {
                        sum = 53;
                    }
                    else if (sport == "Pilates")
                    {
                        sum = 37;
                    }
                }
            }

            double money = Math.Abs(sum - moneyAmount);

            if (sum <= moneyAmount)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else
            {
                Console.WriteLine($"You don't have enough money! You need ${money:f2} more.");
            }
        }
    }
}
