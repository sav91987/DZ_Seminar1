Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int count = 0;

while (count < N-1)
{
    Console.Write(count + 2 + " ");
    count = count + 2;
}