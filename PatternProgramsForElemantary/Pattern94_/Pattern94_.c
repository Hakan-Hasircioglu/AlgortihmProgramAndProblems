#include <stdio.h>

int main()
{
    int i,j,k;
    k = 65;
    for (i = 1; i <= 5; i++)
    {
        for (j = 0; j < i; j++)
            printf("%c ", k + j);
        printf("\n");
        k+=i;
    }
    
    return 0;
}