#include <stdio.h>
int main()
{
    int i, j;
    for (i = 5; i >= 1; i--)
    {
        if (i == 5 || i == 3)
            j = 5;
        else
            j = 1;
        for (j ; j >= 1; j--)
            printf("F ");
        printf("\n");
    }

    return 0;
}