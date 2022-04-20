using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // number equal or not equal

            Console.WriteLine("Enter first number");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int n2 = Convert.ToInt32(Console.ReadLine());
            if (n1 == n2)
            {
                Console.WriteLine(n1 + " and "+ n2 + "are equal");
            }
            else if(n1!=n2)
            {
                Console.WriteLine(n1 + " and " + n2 + "are not equal");
            }
            else {
                Console.WriteLine("Invalid"); 
            }
            Console.ReadLine( );




            // +ve or -ve number
            Console.WriteLine("Enter number");
            int n=Convert.ToInt32(Console.ReadLine());
            if(n>0)
            {
                Console.WriteLine(n+ " is positive number");
            }
            else if (n<0)
            {
                Console.WriteLine(n+ " is negative number ");
            }
            Console.ReadLine();


            // operations
            

            int number1, number2, result;
            char operation;
            Console.Write("Enter the first number :");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number :");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose the operation");
            Console.WriteLine("1:- +");
            Console.WriteLine("2:- - ");
            Console.WriteLine("3:- * ");
            Console.WriteLine("4:- % ");
            operation = Convert.ToChar(Console.ReadLine());
            switch (operation)
            {
                case '1':
                    result = number1 + number2;
                    Console.WriteLine("The addition of two number is : {0}", result);
                    break;
                case '2':
                    result = number1 - number2;
                    Console.WriteLine("The subtraction of two number is : {0}", result);
                    break;
                case '3':
                    result = number1 * number2;
                    Console.WriteLine("The multiplication of two number is : {0}", result);
                    break;
                case '4':
                    result = number1 / number2;
                    Console.WriteLine("The division of two number is : {0}", result);
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;


            }
            Console.ReadLine();
        }
    }
}
