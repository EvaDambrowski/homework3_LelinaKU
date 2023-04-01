//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначное Число: ");
int num = int.Parse(Console.ReadLine()!);

int remineder, sum = 0;
int temp = num;
while (num > 0)
{
    remineder = num % 10;
    sum = (sum*10) + remineder;
    num = num / 10;
    //Console.WriteLine(sum);
    
}
if (sum == temp)
{
    Console.WriteLine($"Число {sum} является плиндромом");
}
else
{
    Console.WriteLine($"Число {sum} не является плиндромом");
}