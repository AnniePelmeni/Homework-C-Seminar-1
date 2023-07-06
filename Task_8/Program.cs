Console.WriteLine("Введите число: ");
int number1 = int.Parse (Console.ReadLine());

if (number1 >= 0)
{
    int number2 = 2;
    while (number2 <= number1)
    {
    Console.Write(number2 + " ");
    number2 = number2 + 2;
    }
}

else
{
    int number3 = 0;
    while (number3 >= number1)
    {
    Console.Write(number3 + " ");
    number3 = number3 - 2;
    }
}
