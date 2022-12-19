/*  Задача 38: 
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76  */

int lenght = GetLenght("Enter lenght of the array:");
double[] array = new double[lenght];

int GetLenght(string message)
{
    bool isCorrect = false;
    int result = 0;

    while (!isCorrect)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Error: wrong entered data.");
        }
    }
    return result;
}

double GetNumber(string message)
{
    bool isCorrect = false;
    double result = 0;

    while (!isCorrect)
    {
        Console.WriteLine(message);

        if (double.TryParse(Console.ReadLine(), out result))
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Error: wrong entered data.");
        }
    }
    return result;
}

double[] GetArray(string message)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = GetNumber($"{message} {i + 1}:");
    }
    return array;
}

void DifOfMaxAndMin(double[] array)
{
    double min = 0;
    double max = 0;
    if (array[0] < array[1])
    {
        min = array[0];
        max = array[1];
    }
    else
    {
        min = array[1];
        max = array[0];
    }
    Console.Write($"Difference of maximum and minimum elements of array [");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        else if (array[i] < min)
        {
            min = array[i];
        }
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}] ");
        }
    }
    Console.WriteLine($"is {max - min}.");
    return;
}

array = GetArray("Enter element");
DifOfMaxAndMin(array);
