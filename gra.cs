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

Console.WriteLine("RULES: \t11 POINTS - WIN");
Console.WriteLine(" ");
Random dice = new Random(); 

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

if(roll1==1)
{
    Console.WriteLine($"{roll1} + {roll2} + {roll3} = {total} \t+ 2 EXTRA POINTS (roll1=1). Total: {total+2}");
    if(total>=11)
    {
        Console.WriteLine("You win");
    }
    else
    {
        Console.WriteLine("You lose");
    }
}
else
{
    Console.WriteLine($"{roll1} + {roll2} + {roll3} = {total}");
    if (roll1 == roll2 || roll2 == roll3 || roll3 == roll1)
    {
        Console.WriteLine($"You rolled doubles! +2 bonus to total. Total: {total+=2} ");
        if (total >= 11)
        {
            Console.WriteLine("You win");
        }
        else
        {
            Console.WriteLine("You lose");
        }
    }
    else
    {
        if (total >= 11)
        {
            Console.WriteLine("You win");
        }
        else
        {
            Console.WriteLine("You lose");
        }
    }
}
