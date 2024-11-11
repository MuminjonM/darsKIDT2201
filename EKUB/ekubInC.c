#include <stdio.h>

int EKUB(int a, int b) 
{
    while (b != 0) 
    {
        int temp = b;
        b = a % b;
        a = temp;
    }

    return a;
}

int main() 
{
    int num1, num2;
    
    printf("Enter two integers: ");
    scanf("%d %d", &num1, &num2);
    
    int result = EKUB(num1, num2);
    
    printf("EKUB: %d %d %d\n", num1, num2, result);
    
    return 0;
}
