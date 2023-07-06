Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

int x = number % 2;

if ( x == 0)
{
    Console.WriteLine ($"Число {number} четное");
}

if ( x > 0)
{
    Console.WriteLine ($"Число {number} нечетное");
}