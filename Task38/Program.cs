/*

Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76

*/

double[] InitArray()
{
    double[] result = new double[10];
    Random rnd = new Random();
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.NextDouble();
    }

    return result;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

// first is MAX number, second is MIN number
(double MAX, double MIN) MAXandMINnumber (double[] array) {
    double MIN = array[0];
    double MAX = array[0];
    for (int i = 1; i < array.Length; i++) {
        if (MIN > array[i]) MIN = array[i];
        if (MAX < array[i]) MAX = array[i];
    }
    return (MAX, MIN);
}

double[] array = InitArray();

PrintArray(array);

var myTuple = MAXandMINnumber(array); 

Console.WriteLine($"Максимальное число в массиве равно {myTuple.MAX}.");
Console.WriteLine($"Минимальное число в массиве равно {myTuple.MIN}.");
