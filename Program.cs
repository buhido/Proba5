// See https://aka.ms/new-console-template for more information
//using System.Drawing;

//Console.WriteLine("Hello, World!");





using System.Drawing;

bool isWork = true;


while (isWork)
{
    string command = Console.ReadLine();

    switch (command)
    {
        case "task34": Task34(); break;
        case "task36": Task36(); break;
        case "task38": Task38(); break;
        case "exit": isWork = false; break;
    }
}


void Task34()
{
    //Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
    //Напишите программу, которая покажет количество чётных чисел в массиве.
    //[345, 897, 568, 234] -> 2

    Console.WriteLine("Введите длину массива:  ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] numbers = new int[size];
    RandomNumbers(numbers);
    Console.WriteLine("В этом массиве: ");
    PrintArray(numbers);

    void RandomNumbers(int[] numbers)                //случайные числа       
    {
        for (int i = 0; i < size; i++)
        {
            numbers[i] = new Random().Next(100, 1000);
        }
    }

    int count = 0;

    for (int x = 0; x < numbers.Length; x++)          //цикл счетчика четных чисел    
    {
        if (numbers[x] % 2 == 0)                       
            count++;
    }
    Console.WriteLine($"из {numbers.Length} чисел, {count} четных");


    void PrintArray(int[] numbers)                 
    {
        Console.Write("[");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.Write("]");
        Console.WriteLine();
    }
}


void Task36()
{
    //Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
    //[3, 7, 23, 12] => 19
    //[-4, -6, 89, 6] => 0
    Console.WriteLine("Введите размер массива  ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] numbers = new int[size];
    FillArrayRandomNumbers(numbers);
    Console.WriteLine("Наш массив: ");
    PrintArray(numbers);
    int sum = 0;

    for (int i = 1; i < numbers.Length; i += 2)
    {
        sum = sum + numbers[i];
        Console.WriteLine($"на нечетной позиции => {numbers[i]}");
    }
    Console.WriteLine($"Сумма элементов, cтоящих на нечётных позициях = {sum}");
    
    void FillArrayRandomNumbers(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1, 15);
        }
    }
    void PrintArray(int[] numbers)
    {
        Console.Write("[ ");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.Write("]");
        Console.WriteLine();
    }
}


void Task38()
{
 //Задача 38: Задайте массив вещественных чисел. Найдите разницу между
 //максимальным и минимальным элементов массива.
 //[3 7 22 2 78] -> 76

int size = 5;
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

double max = numbers[0];
double min = numbers[0];

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
    else if (numbers[i] < min)
    {
        min = numbers[i];
    }
}

Console.WriteLine($"Минимальный элемент: {min}");
Console.WriteLine($"Максимальный элемент: {max}");
Console.WriteLine($"Разница между максимальным и минимальным элементом: {max - min}");

void FillArrayRandomNumbers(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble() * 100;
    }
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "   ");
    }
    Console.WriteLine();
}
}
    
    