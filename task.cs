// Задача: Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, либо равна 3 
// символам. Первоначальный массив можно ввести с клавиатуры, либо задать 
// на старте выполнения алгоритма. При решении не рекомендуется пользоваться 
// коллекциями, лучше обойтись исключительно массивами.

using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Введите элементы массива, разделенные пробелом:");
        string input = Console.ReadLine();
        string[] inputArray = input.Split(' ');

        string[] outputArray = FilterArrayByLength(inputArray, 3);

        Console.WriteLine("Результат:");
        foreach (string str in outputArray)
        {
            Console.WriteLine(str);
        }
    }
     public static string[] FilterArrayByLength(string[] inputArray, int maxLength)
    {
        int count = 0;
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= maxLength)
            {
                count++;
            }
        }
    }
}