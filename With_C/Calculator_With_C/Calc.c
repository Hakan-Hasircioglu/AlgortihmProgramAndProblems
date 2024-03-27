#include <stdio.h>
#include <stdbool.h>
int main()
{
    int firstNum, secondNum, extraNum, result;
    char ope;
    bool isContinue = true;
    while (isContinue == true)
    {
        printf("Which Operation?: ! %% ^ * - + /\nYou: ");
        scanf(" %c", &ope);
        if (ope == '!')
        {
            printf("First Number: ");
            scanf("%d", &firstNum);
        }
        else if (ope == 'q')
        {
            printf("Exiting the Program \n");
            return 0;
        }
        else
        {
            printf("First Number: ");
            scanf("%d", &firstNum);
            printf("Second Number: ");
            scanf("%d", &secondNum);
        }

        switch (ope)
        {
        case '+':
            result = firstNum + secondNum;
            break;
        case '-':
            result = firstNum - secondNum;
            break;
        case '*':
            result = firstNum * secondNum;
            break;
        case '/':
            result = firstNum / secondNum;
            break;
        case '%':
            result = firstNum % secondNum;
            break;
        case '^':
            extraNum = firstNum;
            for (int i = 1; i < secondNum; i++)
            {
                firstNum *= extraNum;
            }
            result = firstNum;
            break;
        case '!':
            extraNum = 1;
            for (int i = 1; i <= firstNum; i++)
            {
                extraNum *= i;
            }
            result = extraNum;
            break;
        default:
            printf("\nUnknown Input!");
            break;
        }
        printf("\n= %d\n", result);
    }
    return 0;
}