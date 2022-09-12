// Задача 36
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
// стоящих на нечётных позициях.

void FillArray(int[] numbers)
{
    int length = numbers.Length;
    int index = 0;
    while (index < length)
    {
        numbers[index] = new Random().Next(1, 10);
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

int sumNumbers = 0;

for (int i = 0; i < numbers.Length; i+=2)
    sumNumbers = sumNumbers + numbers[i];

Console.WriteLine($"Cумма элементов на нечётных позициях = {sumNumbers}");