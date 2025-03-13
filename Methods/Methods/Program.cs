using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Metn:"); 
        string metn = Console.ReadLine();

        string tersmetn = new
            string(metn.Reverse().ToArray());
        Console.WriteLine("Metnin tersi:"+tersmetn);
    }
}