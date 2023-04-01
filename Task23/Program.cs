Console.WriteLine("Введите Число: ");
int num = int.Parse(Console.ReadLine()!);

for ( int i = 0; i <= num; i = i+1 )
{
     
    Console.Write(Math.Pow(i, 3) + ",");
}

