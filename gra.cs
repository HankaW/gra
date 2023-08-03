//ktora wartosc jest wieksza 
//using System;
//int firstValue = 500;
//int secondValue = 600;
//int largerValue;

//largerValue = (firstValue >= secondValue) ? firstValue : secondValue;
//Console.WriteLine(largerValue);

//losowanie kostki
//Random dice = new Random();
//int roll1 = dice.Next(1, 7);
//int roll2 = dice.Next(1, 7);
//int roll3 = dice.Next(1, 7);

//int total = roll1 + roll2 + roll3;

//Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");




//gra


using System.Collections;
using System.Xml.Schema;

namespace Gra
{
    public class Gra
    {
        public void start()
        {
            Console.WriteLine("RULES: \t\t13 POINTS OR THREE DUPLICATES - WIN");
            Console.WriteLine(" ");
            real();
        }
                
        public void winorlose(int bonus)
        {
            if (bonus >= 13)
            {
                Console.WriteLine(" ");
                Console.WriteLine("YOU WIN");
            }
            else
            {
                Console.WriteLine(" ");
                Console.WriteLine("YOU LOSE");
            }

        }

        public void real()
        {
            //  abc();
            //  abc(1, 2, 3);
            Random dice = new Random();
            int roll1 = dice.Next(1, 7);
            int roll2 = dice.Next(1, 7);
            int roll3 = dice.Next(1, 7);
            int total = roll1 + roll2 + roll3;
            int bonus = total + 2; 

            if (roll1 == roll2 && roll2 == roll3 && roll3 == roll1)
            {
                Console.WriteLine($"{roll1} + {roll2} + {roll3} = WIN");
                Console.WriteLine("\t Three duplicates. YOU WIN!!!).");
            }
            else
            {
                Console.WriteLine($"{roll1} + {roll2} + {roll3} = {total}");
                if (roll1 == 1)
                {
                    Console.WriteLine("\t + 2 EXTRA POINTS (first roll = 1).");
                    Console.WriteLine($"Total: {bonus}");
                    options(roll2, bonus);

                }
                else
                {

                    if (roll1 == roll2 || roll2 == roll3 || roll3 == roll1)
                    {
                        Console.WriteLine($"\tYou rolled doubles! +2 bonus to total.");
                        Console.WriteLine($"Total: {bonus} ");
                        winorlose(bonus);
                    }
                    else
                    {
                        options(roll2, total);
                    }
                }
       
            }
        }
        
        public void options(int roll2, int bonus)
        {
            if (roll2 < 4 && bonus < 13)
            {
                Console.WriteLine("\t Second roll < 4. Try again");
                real();
            }
            else
            {
                winorlose(bonus);
            }
        }

        /* public long abc(int a=0, int b=0, int c=0)
             {
                Console.WriteLine();
                return a + b + c;
             }
       */

    }
}

