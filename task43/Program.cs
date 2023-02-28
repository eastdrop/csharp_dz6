/*Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
 * значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)*/

double[] InputArr(string text)
{
    Console.WriteLine(text);
    return Array.ConvertAll(Console.ReadLine().Split(), double.Parse);
}


void DotCross(double[] array)
{
    double x = (array[2] - array[0]) / (array[1] - array[3]);
    double y = (array[1] * x + array[0]);
    System.Console.WriteLine($"({x};{y})");
}

double[] numbers = InputArr("Input b1, k1, b2, k2: ");
DotCross(numbers);