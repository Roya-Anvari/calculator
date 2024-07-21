using System;
using System.Text.RegularExpressions;
using Microsoft.Win32;

namespace MyApp
{
     class Program
    {
        static void  Main(string[] args)
        {
          var calculator = new Calculator();
          do
          {
            Console.Clear();

            Console.WriteLine("---------------------");

            Console.WriteLine("calculator program");

            Console.WriteLine("---------------------");

            SetCalculatorOprator(calculator);

            calculator.PrintOption();

             calculator.Operand = Console.ReadLine();

            try
             {
                 calculator.Process();
                 Console.WriteLine(calculator);
              }
             catch (Exception ex)
              {
                  Console.WriteLine(ex.Message);
               } 
              Console.WriteLine("Would you like to continue?(Y = Yes , N = No) ");
            }  while (Console.ReadLine().ToUpper() == "Y" );
          Console.WriteLine("Bye!");
         }


        private static void SetCalculatorOprator(Calculator calculator)
        {
          Console.WriteLine("Enter number 1:");
          calculator.FirstOprator = Convert.ToDouble(Console.ReadLine());

          Console.WriteLine("Enter number 2:");
          calculator.SecondOprator = Convert.ToDouble(Console.ReadLine());

        }

    }

   
}