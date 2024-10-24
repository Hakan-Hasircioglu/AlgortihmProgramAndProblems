List<int> digits = new List<int>();
int a = 0;
BigInteger num = BigInteger.Pow(2, 1000);
string numString = num.ToString();
foreach (char item in numString)
{
    a += item - '0';
}
Console.WriteLine(a);
