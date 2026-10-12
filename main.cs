/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine("your first number:");
        string num1 = Console.ReadLine();

        Console.WriteLine("your second number:");
        string num2 = Console.ReadLine();
        
        // both inputs sent to divide method
        Divide(num1, num2);
    }
        // converts inputs and divides
    static void Divide(string num1, string num2)
    {
        try
        {
            
            // convert users inputs into intergers
            int number1 = Convert.ToInt32(num1);
            int number2 = Convert.ToInt32(num2);

            int result = number1 / number2;

            Console.WriteLine("result: " + result);
        }
        catch (FormatException)
        {
            Console.WriteLine("error: Please enter valid whole numbers.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("error: You cannot divide by zero.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("error: The number you entered is too large or too small.");
        }
        catch (Exception)
        {
            Console.WriteLine("error: Something unexpected happened.");
        }
    
  }
}