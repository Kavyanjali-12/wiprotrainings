using System; //package name -- > imported the built in package

namespace CalculatorOperations // --> namespace declaration

{

    internal class Program
    {
        //main is the entry point of your program
        static void Main(string[] args)
        {

          //  unsafe
            {
                int number = 456;
                //   int* ptr = &number;

                int a = 10;
                int b = 20;
                string s = "Hello";
                char ch = 'B';
                //Int16
                short num1 = 234;
                //Int32

                //Int64 
                long num = 5767;

                double price = 45.00;

                Decimal marks = 45.7M;

                Console.WriteLine($"Value : {number} ");
             //   Console.WriteLine($"The address : {(int)ptr}");


                Console.WriteLine("Char : " + ch);
                Console.WriteLine("Equivalent Number : " + (byte)ch);
                Console.WriteLine("The minimum and maximum value size : " + char.MinValue + " " + char.MaxValue);
                Console.WriteLine("The char size : " + sizeof(char));

                Console.WriteLine("Sum of 2 numbers : " + (a+b));
                Console.ReadKey();
            }
        }


    }
}

