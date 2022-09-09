// Задача 24:
// Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int num) // метод суммирует все числа от 1 до num
{
    int sum = default;    // 0 или default - это 0 для int
    for (int i = 1; i <= num; i++)
    {
        // sum = sum + i;
        sum += i;
    }
    return sum;
}

int sumNumbers = SumNumbers(number);
Console.WriteLine($"Сумма чисел от 1 до {number} = {sumNumbers}");