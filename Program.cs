using System.Threading;

static void PrintNumber() {
    for(int i = 3; i > 0; i--) {
        Console.WriteLine($"{i}");
        Thread.Sleep(1000);
    }
}

Random dice = new Random();
int roll1 = dice.Next(1,7);
int roll2 = dice.Next(1,7);
int roll3 = dice.Next(1,7);
int total = roll1 + roll2 + roll3;

PrintNumber();

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("Congratulations! All the dropped values are the same, 6 points are added to you!");
        total += 6;
    }
    else
    {
        Console.WriteLine("Congratulations! Two identical values have fallen out, 2 points have been added to you!");
        total += 2;
    }
}

Console.WriteLine($"The result is {total}");

Thread.Sleep(2000);

if (total > 9)
{
    Console.WriteLine("You're win!");
}
else
{
    Console.WriteLine("You're lose!");
}