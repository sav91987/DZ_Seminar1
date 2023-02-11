Console.WriteLine("Введите первое число: ");
int FirstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int SecondNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int ThirdNumber = Convert.ToInt32(Console.ReadLine());

int max = FirstNumber;

if (FirstNumber == SecondNumber)
{
    if (FirstNumber == ThirdNumber)
    {
        Console.WriteLine("Числа равны");
    }
}
else
{
    if (SecondNumber > max)
    {
        max = SecondNumber;
    }
    if (ThirdNumber > max)
    {
        max = ThirdNumber;
    }

    Console.WriteLine("max = " + max);
}

