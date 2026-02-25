using System;

class HelloWorld
{
    static void Main()
    {
        Int32  a;
        Console.WriteLine("Введите Целое Число: ");
        a = Convert.ToInt32(Console.ReadLine());

        if (a % 3 == 0) { //  Если остаток от 3 равень 0
            Console.WriteLine("Число: " + a + " Кратное(KRATNOE) трем");
        }
        else { //  Если остаток от 3 неравень 0
            Console.WriteLine("Число: " + a + " Некратное(Nekratnoe) трем");
        }
        Console.ReadKey();
    }
}
