#include <stdio.h>
int main()
{
    int i, j;
    for (i = 4; i >= 1; i--)
    {
        for (j = 0; j <= i; j++)
            printf("%c ", 65 + j);
        printf("\n");
    }
    return 0;
}