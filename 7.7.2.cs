using System;

class HelloWorld
{
    static void Main()
    {
        double e = 2.71828,Xn = -9.38,Xk = 26.2, dx = 3.8, a = 2.35, b = 17.8;
        double x = Xn;
        double y = 1;
        Console.WriteLine("| {0,6} | {1,18} |", "x", "y");
        while(x <= Xk){
            if(x >= Math.Log(b)){
                y = Math.Pow(Math.Log(a*x),3) / (Math.Sqrt(b * x) +  1.2);
            }
            else{
                y = Math.Pow(Math.Tan(a * x), 2) + Math.Sqrt(Math.Pow(e,b*x));
            }
            x = x + dx;
            Console.WriteLine("| {0,6} | {1,18} |", x, y);
        }
    }
}
