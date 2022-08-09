using System;

namespace FourthSeminar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
            // [345, 897, 568, 234] -> 2


            Console.WriteLine($"Программа выдает количество чётных чисел в массиве:\n");
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




        }
    }
}
