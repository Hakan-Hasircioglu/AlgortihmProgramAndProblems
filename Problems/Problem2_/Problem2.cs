ulong a = 1; ulong b = 1; ulong c = 0; ulong sum = 0;
for (ulong i = 0; i < 100; i++)
{
    a = b; b = c; c = a + b; 
    if (c <= 4000000) {if (c % 2 == 0) {sum = sum + c;Console.WriteLine(sum);}}              
}
