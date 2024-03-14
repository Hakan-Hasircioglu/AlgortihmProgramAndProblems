#include <stdio.h>
#include <stdlib.h>
int main()
{
    int i, j;
    for (i = 1; i <= 5; i++)
    {
        for ( j = 1; j <= 5; j++)
        {
            if (i % 2 == 0)
            {
                int jEqual = j == 1 || j ==  5 ? printf("B ") : printf("  ");                
            }
            int iEqual = i % 2 == 1 && j <= 4 ? printf("B ") : printf("");
        }
        printf("\n");
    }
    return 0;
}