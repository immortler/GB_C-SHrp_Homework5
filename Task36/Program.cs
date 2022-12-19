/*  Задача 36: 
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0  */

int lenght = GetNumber("Enter lenght of the array:", true);
int[] array = new int[lenght];

int GetNumber(string message, bool natural)
{
    bool isCorrect = false;
    int result = 0;

    while (!isCorrect)
    {
        Console.WriteLine(message);
        if (natural == true)
        {
            if (int.TryParse(Console.ReadLine(), out result) && result > 0)
            {
                isCorrect = true;
            }
            else
            {
                Console.WriteLine("Error: wrong entered data.");
            }
        }
        else
        {
            if (int.TryParse(Console.ReadLine(), out result))
            {
                isCorrect = true;
            }
            else
            {
                Console.WriteLine("Error: wrong entered data. Try again.");
            }
        }
    }
    return result;
}

int[] GetArray(string message)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = GetNumber($"{message} {i + 1}:", false);
    }
    return array;
}

void SumOfEvenIndexNumbs(int[] array)
{
    int sumOfEvenIndexNumbs = 0;
    Console.Write($"Sum of elements with uneven indexes from array [");
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0)
        {
            sumOfEvenIndexNumbs = sumOfEvenIndexNumbs + array[i];
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
    Console.WriteLine($"is {sumOfEvenIndexNumbs}.");
    return;
}


array = GetArray("Enter element");
SumOfEvenIndexNumbs(array);