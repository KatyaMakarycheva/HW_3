// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

 Console.WriteLine("Введите число: ");

int a = Convert.ToInt32(Console.ReadLine());
int b = 0;
int r = a;

while (a != 0)
{
    int lastNumber = a % 10;
    a = a / 10;
    b = b * 10 + lastNumber;
}

if (r == b)
{
    Console.WriteLine("Palindrome");
}
else 
{
    Console.WriteLine("Not Palindrome");
}

