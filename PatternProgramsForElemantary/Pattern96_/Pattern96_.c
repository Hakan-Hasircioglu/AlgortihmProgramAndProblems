#include <stdio.h>

int main()
{
    int i, j, k;
    for (i = 1; i <= 5; i++)
    {
        for (k = 4; k >= i; k--)
            printf(" ");
        for (j = 1; j <= i; j++)
            printf("%d" , i);
        printf("\n");
    }

    return 0;
}