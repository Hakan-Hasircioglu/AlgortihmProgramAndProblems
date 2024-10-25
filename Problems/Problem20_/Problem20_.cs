using System.Numerics;
List<int> digits = new List<int>();
int a = 0;
BigInteger num = 1;
for (BigInteger i = 1; i <= 100; i++)
{
    num *= i;
}
string numString = num.ToString();
foreach (char item in numString)
{
    a += item - '0';
}
Console.WriteLine(a);
