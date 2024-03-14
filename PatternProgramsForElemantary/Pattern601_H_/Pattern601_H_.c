#include <stdio.h>
int main()
{
    int i, j;
    for (i = 5; i >= 1; i--)
    {
        for ( j = 1; j <= 5; j++)
        {
            if (j == 1 || j ==5 || i == 3)
            {
                printf("H ");
            }
            else if (j < 5 || j > 1)
            {
                printf("  ");
            }
        }
        
        printf("\n");
    }

    return 0;
}