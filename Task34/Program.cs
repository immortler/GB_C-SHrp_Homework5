/*  Задача 34: 
Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2  */

int lenght = GetNumber("Enter lenght of the array:");

int GetNumber(string message)
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

void GetArrayAndCountTwoDigits(int lenght)
{
    int[] array = new int[lenght];
    Random rnd = new Random();
    Console.Write("Array [");
    int numbOfEvenNumb = 0;    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 1000);
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}] ");
        }
        if (array[i] % 2 == 0)
        {
            numbOfEvenNumb++;
        }
    }    
    string ending = "s";
    if (numbOfEvenNumb == 1)
    {
        ending = "";
    }
    if (numbOfEvenNumb == 0)
    {
        Console.WriteLine("not contains even numbers.");
    }
    else
    {
        Console.WriteLine($"contains {numbOfEvenNumb} even number{ending}.");
    }
    return;
}

GetArrayAndCountTwoDigits(lenght);
