using System;
using System.Text;

class HelloWorld
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        int[] array = new int[12];
        Random rnd = new Random();

        Console.WriteLine("Не Масcив: ");
        for (int i = 0; i < 12; i++)
        {
            array[i] = rnd.Next(71);
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();

        int arif = 0, count = 0;
        double geom = 1;

        for (int i = 0; i < 12; i++)
        {
            if (array[i] % 2 != 0)
            {
                arif += array[i];
                geom *= array[i];
                count++;
            }
        }

        Console.WriteLine("Cреднее арифметическое нечетных элементов: " + arif / count);
        Console.WriteLine("Cреднее геометрическое нечетных элементов: " + Math.Pow(geom, 1.0 / count)); // 1.0 надо, чтобы при 1/3 получилось 0.(3) и т.д., а не 0
        Console.ReadKey();
    }
}
