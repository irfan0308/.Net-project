using System;

namespace calculator1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("for addition press 1\n for sub press 2\n for mul press 3" +
                "\n for div press 4\n for modulus press 5\n for exponent press 6\n " +
                "for square press 7\n for sqrt press 8");

            int opr = Convert.ToInt32(Console.ReadLine());
            if (opr == 1 || opr == 2 || opr == 3 || opr == 4 || opr == 5 || opr == 6)
            {
                Console.WriteLine("enter first number :");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("enter second number :");
                double b = Convert.ToDouble(Console.ReadLine());
                if (opr == 1)
                {
                    double sum = a + b;
                    Console.WriteLine("sum is :" + sum);
                }
                else if (opr == 2)
                {
                    double sub = a - b;
                    Console.WriteLine("sub is :" + sub);
                }
                else if (opr == 3)
                {
                    double mul = a * b;
                    Console.WriteLine("mul is :" + mul);
                }
                else if (opr == 4)
                {
                    if (b == 0)
                    {
                        Console.WriteLine("Enter a non zero number");

                    }

                    double div = a / b;
                    
                    Console.WriteLine("div is :" + div);
                    
                }
               else if (opr == 5)
                {
                    double modulus = a % b;
                    Console.WriteLine("modulus is :" + modulus);
                }
                 else if (opr == 6)
                {
                    double exponent = Math.Pow(a, b);
                    Console.WriteLine("exponent is :" + exponent);
                }
            }
             else if (opr == 7 || opr == 8)
            {
                Console.WriteLine("enter a number :");
                double c = Convert.ToDouble(Console.ReadLine());
                if (opr == 7)
                {
                    double Square = c * c;
                    Console.WriteLine("sqare is :" + Square);
                }

                else if(opr==8)
                {
                    double SquareRoot = Math.Sqrt(c);
                    Console.WriteLine("sqareRoot is :" + SquareRoot);
                }
            }
            else
            {
                Console.WriteLine("invalid input");
            }
        }
    }
}
