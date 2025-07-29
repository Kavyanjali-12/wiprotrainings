/*class SwitchCase
{
    static void Main()
    {
        Console.WriteLine("Enter Your 1 to chrck for prime/ 2 to check odd/ 3 for to check even");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
            Console.WriteLine("Enter Number");
            int num = Convert.ToInt32(Console.ReadLine());
                bool b = true;
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        b = false;
                    }
                }
                if(b)
                { 
                    Console.WriteLine(num + " is PRIME Number");
                }
                else
                {
                    Console.WriteLine(num + " is Not Prime Number");
                }
                break;
            case 2:
            Console.WriteLine("Enter Number");
            int num2 = Convert.ToInt32(Console.ReadLine());
                if (num2 % 2 != 0)
                {
                    Console.WriteLine(num2 + " Is ODD Number");
                }
                else
                {
                    Console.WriteLine(num2 + " Is Not ODD Number");
                }
                break;
            case 3:
            Console.WriteLine("Enter Number");
            int num1 = Convert.ToInt32(Console.ReadLine());
                if (num1 % 2 == 0)
                {
                    Console.WriteLine(num1 + " Is EVEN Number");
                }
                else
                {
                    Console.WriteLine(num1 + " Is Not EVEN Number");
                }
                break;
            default:
                if (choice != 1 || choice != 2 || choice != 3)
                    Console.WriteLine("Enter Proper Number");
                break;
        }
    }
}*/
