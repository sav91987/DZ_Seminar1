﻿Console.WriteLine("Введите первое число: ");
int FirstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int SecondNumber = Convert.ToInt32(Console.ReadLine());

if (FirstNumber > SecondNumber)
{
    Console.WriteLine("max = " + FirstNumber);
}
else
{
    if (FirstNumber < SecondNumber)
    {
        Console.WriteLine("max = " + SecondNumber);
    }
    else
    {
        Console.WriteLine("Числа равны");
    }
}

