using System;
class Program
{
    static void f1()
    {
        //zadanie 1
        Console.WriteLine("Program do obliczania pola koła");

        Console.Write("Podaj promień: ");
        string input = Console.ReadLine();

        if (double.TryParse(input, out double radius) && radius >= 0)
        {
            double area = Math.PI * radius * radius;
            Console.WriteLine($"Pole kola o promieniu {radius} wynosi {area:F2}");
        }
        else
        {
            Console.WriteLine("niepoprawne dane");
        }
    }

    static void f2()
    {

        //zadanie 2
        Console.Write("podaj dlugosc pierwszego boku: ");
        string a = Console.ReadLine();
        Console.Write("podaj drugi bok: ");
        string b = Console.ReadLine();

        if (double.TryParse(a, out double bok1) && double.TryParse(b, out double bok2) && bok1 >= 0 && bok2 >= 0)
        {
            double pole = bok1 * bok2;
            Console.WriteLine($"pole prostokata o bokach {bok1} i {bok2} wynosi {pole:F2}");

            if (bok1 == bok2)
            {
                Console.WriteLine("to jest kwadrat");

            }
            else
            {
                Console.WriteLine("to nie jest kwadrat");
            }



        }
    }
    //zadanie 3
    static void f3()
    {
        Console.Write("podaj liczbe: ");
        string input = Console.ReadLine();

        if(int.TryParse(input, out int x))
        {
            if(x%2==0)
            {
                Console.WriteLine("liczba jest parzysta");

            }
            else
            {
                Console.WriteLine("liczba nie jest parzysta");
            }
        }

    }
    //zadanie 4
    static void f4()
    {
        Console.Write("pierwsza liczba: ");
        string input1 = Console.ReadLine();
        Console.Write("druga liczba: ");
        string input2 = Console.ReadLine();
        Console.Write("trzecia liczba: ");
        string input3 = Console.ReadLine();

        if(double.TryParse(input1, out double a) && double.TryParse(input2, out double b) && double.TryParse(input3, out double c))
        {
            double max = a;
            if(b>max)
            {
                max = b;
            }
            if(c>max)
            {
                max = c;
            }
            Console.WriteLine($"najwieksza to: {max}");
        }
        else
        {
            Console.WriteLine("niepoprawne dane");
        }
    }
    static void f5()
    {
        Console.WriteLine("rownanie posatci ax^2 + bx +c =0");

        Console.Write("podaj a: ");
        string inputa = Console.ReadLine();
        Console.Write("podaj b: ");
        string inputb = Console.ReadLine();
        Console.Write("podaj c: ");
        string inputc = Console.ReadLine();

        if(double.TryParse(inputa, out double a) && double.TryParse(inputb, out double b) && double.TryParse(inputc, out double c))
        {
            double delta = b * b - 4 * a * c;

            if(delta>0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"miejsca zerowe to: x1={x1} i x2={x2}");

            }
            else if(delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"miejsce zerowe x = {x}");
            }
            else
            {
                double r = -b / (2 * a);
                double i = Math.Sqrt(-delta) / (2 * a);
                Console.WriteLine($"miejsca zerowe to: x1={r} + {i:F2}i oraz x2={r} - {i:F2}i");

            }
        }
    }

    static void Main()
    {
        f1();
        f2();
        f3();
        f4();
        f5();

    }
}



