using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task 3
            //    int[,] arr1 = new int[3,4];
            //    int[] arr2 = new int[5];
            //    Console.WriteLine("enter numbers");
            //    for (int i = 0; i < arr2.Length; i++)
            //    {
            //        Console.Write($"Елемент {i + 1}: ");
            //        arr2[i] = Convert.ToInt16(Console.ReadLine());
            //    }

            //    Console.WriteLine("Array A:");
            //    foreach (var num in arr2)
            //    {
            //        Console.Write(num + " ");
            //    }
            //    Console.WriteLine();
            //    for (int i = 0; i < arr1.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < arr1.GetLength(1); j++)
            //        {
            //            arr1[i, j] = i * j * 2 + 5;
            //        }
            //    }
            //    Console.WriteLine("Array B:");
            //    for (int i = 0; i <= arr1.GetUpperBound(0); i++)
            //    {
            //        for (int j = 0; j <= arr1.GetUpperBound(1); j++)
            //        {
            //            Console.Write(arr1[i, j] + " ");
            //        }
            //        Console.WriteLine();
            //    }
            //    int maxA = arr2[0];
            //    int minA = arr2[0];
            //    int maxB = arr1[0, 0];
            //    int minB = arr1[0, 0];
            //    foreach(var num in arr2)
            //{
            //        if (num > maxA) maxA = num;
            //        if (num < minA) minA = num;
            //    }

            //    for (int i = 0; i < arr1.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < arr1.GetLength(1); j++)
            //        {
            //            if (arr1[i, j] > maxB) maxB = arr1[i, j];
            //            if (arr1[i, j] < minB) minB = arr1[i, j];
            //        }
            //    }
            //    int sumA = 0;
            //    int productA = 1;
            //    foreach (var num in arr2)
            //    {
            //        sumA += num;
            //        productA *= num;
            //    }

            //    int sumB = 0;
            //    foreach (var num in arr1)
            //    {
            //        sumB += num;
            //    }

            //    Console.WriteLine($"Max element of A: {maxA}");
            //    Console.WriteLine($"Min element of A: {minA}");
            //    Console.WriteLine($"Max element of B: {maxB}");
            //    Console.WriteLine($"Min element of B: {minB}");
            //    Console.WriteLine($"Sum of all elements of A: {sumA}");
            //    Console.WriteLine($"Sum of all elements of B: {sumB}");
            //    Console.WriteLine($"Product of all elements of A: {productA}");
            //task4
            //Random rnd = new Random();
            //int[,] array = new int[5, 5];
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        array[i, j] = rnd.Next(-100, 101);
            //    }
            //}
            //Console.WriteLine("Array:");
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        Console.Write(array[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            //int max = array[0, 0];
            //int min = array[0, 0];
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        if (array[i, j] > max) max = array[i, j];
            //        if (array[i, j] < min) min = array[i, j];
            //    }
            //}
            //Console.WriteLine($"Min element of A: {min}");
            //Console.WriteLine($"Max element of B: {max}");
            //int sum = 0;
            //bool startedSum = false;
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        if (array[i, j] == min)
            //        {
            //            startedSum = true;
            //        }
            //        if (startedSum)
            //        {
            //            sum += array[i, j];
            //        }
            //        if (array[i, j] == max) 
            //        {
            //            startedSum = false;
            //        }
            //    }
            //}
            //Console.WriteLine($"Sum of elements between min and max: {sum}");

        
        }
    }
}