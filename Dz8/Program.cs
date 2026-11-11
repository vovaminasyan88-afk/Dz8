using System;

class Program
{
    static void Main()
    {
       
        int[] originalArray = { 10, 20, 30, 40, 50 };

      
        Console.Write("Исходный массив: ");
        for (int i = 0; i < originalArray.Length; i++)
        {
            Console.Write(originalArray[i] + " ");
        }
        Console.WriteLine();

        
        int[] revers = new int[originalArray.Length];

        
        for (int i = 0; i < originalArray.Length; i++)
        {
            revers[i] = originalArray[originalArray.Length - 1 - i];
        }

        // Вывод перевёрнутого массива
        Console.Write("Перевернутый массив: ");
        for (int i = 0; i < revers.Length; i++)
        {
            Console.Write(revers[i] + " ");
        }
        Console.WriteLine();

        Console.ReadKey();
    }
}