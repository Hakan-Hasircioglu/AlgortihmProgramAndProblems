#include <stdio.h>

int main()
{
    int i, j;
    for (i = 5; i >= 1; i--)
    {
        if (i % 2 == 1)
        {
            j = 5;
        }
        else
        {
            j = 1;
        }
        
        for (j ; j >= 1; j--)
        {
            printf("E ");
        }
        printf("\n");
    }

    return 0;
}