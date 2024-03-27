#include <stdio.h>
#include <stdbool.h>
#include <string.h>

int main()
{
    char correctUserName[] = "admin";
    char correctPassword[] = "1234";
    char userName[20];
    char userPassword[20];
    int rightToTry = 3;
    bool continuee = true;

    while (continuee)
    {
        printf("User Name: ");
        scanf("%s", &userName);
        printf("Password: ");
        scanf("%s", &userPassword);
        int isEqualPassword = strcmp(correctPassword, userPassword);
        int isEqualUserName = strcmp(correctUserName, userName);
        if (rightToTry <= 0)
        {
            printf("You are failed login!!!");
            return 0;
        }
        
        if (isEqualPassword == 0 && isEqualUserName == 0)
        {
            printf("Login SuccesFull!!!");
            continuee = false;
        }
        if (isEqualUserName != 0)
        {
            printf("User Name Uncorrect!!!\n");
            rightToTry--;
        }
        else if (isEqualPassword != 0)
        {
            printf("Password Uncorrect!!!");
            rightToTry--;
        }
        printf("\tRight To Try: %d\n", rightToTry);
    }
    return 0;
}