int c = 1;
for (int a = 1; a <= 499; a++)
{
    for (int b = a + 1; b <= 500; b++)
    {
        for (c = b + 1; c <= 1000; c++)
        {
            if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
            {
                if (a + b + c == 1000)
                {
                    Console.WriteLine($"{Math.Pow(a, 2)} + {Math.Pow(b, 2)} = c and {a} + {b} + {c} = {a + b + c} and a * b * c = {a * b * c}");
                    return;
                }
            }
        }
    } 
