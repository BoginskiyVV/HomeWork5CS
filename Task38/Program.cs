//Задача 38 
//Задайте массив вещественных чисел. Найдите разницу между максимальным
//и минимальным элементов массива.

void FillArray(double[] numbers)
{
    int length = numbers.Length;
    int index = 0;
    while (index < length)
    {
        numbers[index] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        index++;
    }
}

void PrintArray(double[] num)
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
double[] numbers = new double[N];
FillArray(numbers);
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int j = 0; j < numbers.Length; j++)
{
    if (numbers[j] > max)
        {
            max = numbers[j];
        }
    if (numbers[j] < min)
        {
            min = numbers[j];
        }
}
Console.WriteLine($"Максимальный элемент = {max}; минимальный элемент = {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементами = {max - min}");
