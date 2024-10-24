uint currentNum = 0;
int Chain = 0, longestChain = 0, longestChainNum = 0;
for (int i = 1; i <= 1_000_000; i++)

{
    currentNum = (uint) i;
    do
	{
        if (currentNum % 2 == 0)
        {
            currentNum /= 2;
        }
        else
        {
            currentNum = (3 * currentNum) + 1; 
        }
        Chain++;
    } while (currentNum != 1);
    Chain++;
    if (Chain > longestChain )
    {
        longestChain = Chain;
        longestChainNum = i;
    }
    Chain = 0;
}
Console.WriteLine($"{longestChainNum}");
