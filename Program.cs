﻿using System;

namespace FourthSeminar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
            // [345, 897, 568, 234] -> 2

            /*
            Console.WriteLine($"Программа выдает количество чётных чисел в массиве ");
            int[] numbers = new int[10];

            void FillArray(int[] array, int min, int max){
            for (int i = 0; i<array.Length; i++ ){
                array[i] = new Random().Next(min, max);
            }
            }

            void WriteArray(int[] array){
                for (int i = 0; i<array.Length; i++ ){
                Console.Write(array[i] + " ");
            }
            }

            int QuantityOfPositive(int[] array){
                int quantity = 0;
                for (int i = 0; i<array.Length; i++ ){
                if (array[i] % 2 == 1)
                {
                quantity++;
                }
            }
            return quantity;
            }

            FillArray(numbers, 100, 1000);
            WriteArray(numbers);
            Console.WriteLine();

            int quantity = QuantityOfPositive(numbers);
            Console.WriteLine($"Количество чётных чисел в массиве: {quantity}");
            */

            // Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
            // [3, 7, 23, 12] -> 19
            // [-4, -6, 89, 6] -> 0


            Console.WriteLine($"Программа считает сумму элементов, стоящих на нечётных позициях ");
            Console.Write($"Введите количество элементов массива ");
            int numberElements = Convert.ToInt32(Console.ReadLine()); 

            int RandomNumbers(int numberElements, int min, int max){
            int[] randomNumbers = new int[numberElements];
            int sumElements = 0;
            Console.Write("Получившийся массив: ");

                for (int i = 0; i <randomNumbers.Length; i++ ){
                randomNumbers[i] = new Random().Next(min, max);

                Console.Write(randomNumbers[i] + " ");

                if (i % 2 != 1)
                {
                    sumElements = sumElements + randomNumbers[i];
                }
                }

            return sumElements;
            }

            int randomNumbers =  RandomNumbers(numberElements, 1, 10);
            Console.WriteLine();
            Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {randomNumbers}");



        }
    }
}
