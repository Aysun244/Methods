//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//Console.WriteLine("Metn:");
//string metn = Console.ReadLine();

//        string tersmetn = new
//            string(metn.Reverse().ToArray());
//        Console.WriteLine("Metnin tersi:"+tersmetn);
//    }
//}

//using System;
//using System;
//class Proqram
//{
//    static void Main()
//    {
//        int num = 34575;
//        int num1 = num % 12;
//        int num2 = num / 12;
//        if (num >= 12)
//        {
//            Console.WriteLine("Ay:" + num1);
//            Console.WriteLine("Il:" + num2);
//        }
//        else
//        {
//            Console.WriteLine("Ay;" + num);
//        }
//    }
//}

//using System;
//using System;
//using System.ComponentModel.Design;
//class Proqram
//{
//    static void Main()
//    {
//        int num = 6;
//        int factorial = 1;
//        for (int i = num; i > 0; i--)
//        {
//            factorial *= i;
//        }

//        Console.WriteLine("Factorial:" + factorial);
//    }

//}



using System;
using System;
using System.ComponentModel.Design;
using System.Diagnostics;
class Proqram
{
    static void Main()
    {
        Console.WriteLine("Metn:");
        string metn = Console.ReadLine();

        string result = RemoveSpaces(metn);
        Console.WriteLine(result);
    }
    static string RemoveSpaces(string input)
    {
        return input.Replace(" ", "");
    }
}
















