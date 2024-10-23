int sum = 0,divisorCounter = 0, altSum = 0;
// Start With 500th triangle number
sum = (500 * 501) / 2;
for (int i = 1; ; i++)
{
    sum += i;
    altSum = sum;

    divisorCounter = Priming(altSum);
    if (divisorCounter > 500)
    {
        Console.WriteLine($"Sum: {sum}\nDivison Count: {divisorCounter}");
        return;
    }
}


int Priming(int a)
{
    int b = 1;
    for (int i = 2; i <= Math.Sqrt(a); i++)
    {
        var counter = 0;
        if (IsPrime(i))
        {
            while (a % i == 0)
            {
                a /= i;
                counter++;
            }
            b *= (counter + 1);
        }
    }
    if (IsPrime(a))
    {
        b *= 2;
    }
    return b;
}
bool IsPrime(int n)
{
    if (n < 2) return false;
    if (n == 2) return true;
    if (n % 2 == 0) return false;


    var i = 3;
    while (i * i <= n)
    {
        if (n % i == 0) return false;
        i += 2;
    }
    return true;
}
