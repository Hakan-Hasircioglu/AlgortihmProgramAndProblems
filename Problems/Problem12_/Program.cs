using System.Diagnostics;
using System.Numerics;

Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();
int sum = 0; int divisorCounter = 0;
// Start With 500th triangle number
sum = (500 * 501)/2;
for (int i = 501; ; i++)
{
    sum += i;
    for (int j = 1; j <= sum; j++)
    {
        if (sum % j == 0)
        {
            divisorCounter++;
        }
        if (divisorCounter > 500)
        {
            stopwatch.Stop();
            Console.WriteLine($"{i}th triangle number");
            TimeSpan elapsed = stopwatch.Elapsed;
            Console.WriteLine($"Elapsed Time:{elapsed.Minutes:00}.{elapsed.Seconds:00}.{elapsed.Milliseconds:00}m");

            Console.WriteLine($"num: {sum}");
            Console.WriteLine($"Divisors Count: {divisorCounter}\n");
            return;
        }
    }
    if (divisorCounter > 300)
    {
        Console.WriteLine($"{i}th triangle number");
        TimeSpan elapsed = stopwatch.Elapsed;
        Console.WriteLine($"Elapsed Time:{elapsed.Minutes:00}.{elapsed.Seconds:00}.{elapsed.Milliseconds:00}m");


        Console.WriteLine($"num: {sum}");
        Console.WriteLine($"Divisors Count: {divisorCounter}\n");

    }
    divisorCounter = 0;
}
