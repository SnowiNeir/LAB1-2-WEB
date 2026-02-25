using System;
using System.Text;
class HelloWorld
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        
        Console.WriteLine("Aga");
        Console.WriteLine("OKaK");
        Console.WriteLine("x"); // заголовок таблицы 
        int space = 0;
        for (char x = 'R'; x >= 'A'; x--)
        {
            // Создаем строку которая будет добавлять 'R' - x пробелов
            // Пример: R - R = 0(+ 0 пробелов), R - Q = 1(+1 пробел) и т.д.
            Console.WriteLine("| {0}{1} |", new string(' ', 'R' - x), x);
        }
        Console.ReadKey();
    }
}
