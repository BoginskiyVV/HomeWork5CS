// //                            Задача 34
// // Задайте массив заполненный случайными положительными трёхзначными числами. 
// // Напишите программу, которая покажет количество чётных чисел в массиве.

void FillArray(int[] numbers)
{
    int length = numbers.Length;
    int index = 0;
    while (index < length)
    {
        numbers[index] = new Random().Next(100, 1000);
        index++;
    }
}

void PrintArray(int[] num)
{
    int count = num.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(num[position]);
        position++;
    }
}

Console.Write("Введите количество элементов массива: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[N];
FillArray(numbers);
PrintArray(numbers);

int count = 0;

for (int i = 0; i < numbers.Length; i++)
if (numbers[i] % 2 == 0)
count++;
Console.WriteLine($"В данном массиве находится {count} положительных числа");
