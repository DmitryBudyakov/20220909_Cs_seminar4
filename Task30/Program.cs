// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

void FillArray(int[] array) // заполняем значениями массив, изменится массив, передаваемый в метод
{
    int count = array.Length;
    Random rnd = new Random();
    for (int i = 0; i < count; i++)
    {
        array[i] = rnd.Next(0, 2);
    }
}

void PrintArray(int[] array)    // выводим массив в консоль
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        if (i == 0) Console.Write($"[{array[i]}, ");
        else if (i == count - 1) Console.Write($"{array[i]}]");
        else Console.Write($"{array[i]}, ");
    }
}

// Console.Clear();
int[] arr = new int[8];

FillArray(arr);
PrintArray(arr);
