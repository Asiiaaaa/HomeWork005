// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
//Использовать рекурсию, не использовать циклы.
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите значения M и N:");
        int m = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());

        PrintNumbersInRange(m, n);
    }

    static void PrintNumbersInRange(int m, int n)
    {
        if (m <= n)
        {
            Console.WriteLine(m);
            PrintNumbersInRange(m + 1, n);
        }
    }
}



// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//using System;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Введите два неотрицательных числа m и n:");
//        int m = int.Parse(Console.ReadLine());
//        int n = int.Parse(Console.ReadLine());

//        Console.WriteLine($"Результат функции Аккермана для m={m} и n={n}: {AckermannFunction(m, n)}");
//    }

//    static int AckermannFunction(int m, int n)
//    {
//        if (m == 0)
///        {
 //           return n + 1;
//        }
//        else if (n == 0)
//        {
//            return AckermannFunction(m - 1, 1);
//        }
//        else
 //       {
//            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
//        }
//    }
//}


// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
//using System;

// class Program
//{
//    static void Main(string[] args)
//    {
//        int[] array = { 1, 2, 5, 0, 10, 34 };

//        PrintArrayReversed(array, array.Length - 1);
//    }

//    static void PrintArrayReversed(int[] arr, int index)
//    {
//        if (index >= 0)
//        {
//            Console.Write(arr[index] + " " );
//            PrintArrayReversed(arr, index - 1);
//        }
//    }
//}

