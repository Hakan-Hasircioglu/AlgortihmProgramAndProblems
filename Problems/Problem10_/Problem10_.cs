using System.Numerics;

BigInteger sum = 0;
bool notPrime = false;
for (int num = 2; num < 2000000; num++)
{
	for (int j = 2; j <= Math.Sqrt(num); j++)
	{
        if (num % j == 0)
		{
			notPrime = true;
			break;
		}
	}
    if (!notPrime)
    {
		  sum += num;
    }
	notPrime = false;
}
Console.WriteLine($"Sum of The Prime Numbers: {sum}");
