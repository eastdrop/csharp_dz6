/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3*/

int[] InputArr(string text)
{
    Console.WriteLine(text);
    return Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
}

void PrintArray(int[] array)
{
    Console.WriteLine("[" + string.Join(", ", array) + "]");
}

void PositiveCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) { count++; }
    }
    Console.WriteLine(count);
}

int[] newArray = InputArr("Введите массив: ");
PrintArray(newArray);
PositiveCount(newArray);