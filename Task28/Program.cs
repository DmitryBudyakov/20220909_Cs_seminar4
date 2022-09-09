// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int MultNumbers(int num)
{
    if (num > 0)
    {
        int sum = 1;
        for (int i = 1; i <= num; i++)
        {
            sum *= i;
        }
        return sum;
    }
    return 1;
}

// Console.Clear();
Console.Write("Введите неотрицательное целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 0)
{
    int multNumbers = MultNumbers(number);
    Console.WriteLine($"{number}! = {multNumbers}");
}
else Console.WriteLine("Ошибка ввода. Введите неотрицательное целое число.");
