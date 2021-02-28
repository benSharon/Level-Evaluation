using System;

namespace Q1_Sequences
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestMethods();
            PrintOddNumbers();
            PrintMultiplesOf2And3();
            PrintLine();
            PrintLineComplex();
            Console.WriteLine();

            PrintRectangle();
            Console.WriteLine();

            PrintRectangleComplex(5);
            Console.WriteLine();

            //PrintTriangle();
        }

        /// <summary>
        ///     This method prints all odd numbers from 0 to 10 using a loop.
        ///     You should not use an if statement
        ///     Output:
        ///     1
        ///     3
        ///     5
        ///     7
        ///     9
        /// </summary>
        public static void PrintOddNumbers()
        {
            for (int i = 0; i < 10; i++)
                if (i % 2 != 0)
                    Console.Write(i + " ");
            Console.WriteLine();
        }

        /// <summary>
        ///     This method prints the multiples of both 2 and 3
        ///     between 1 and 30 inclusively.
        ///     You must use the % (remainder) operator.
        ///     Output:
        ///     6
        ///     12
        ///     18
        ///     24
        ///     30
        /// </summary>
        public static void PrintMultiplesOf2And3()
        {
            for (int i = 1; i <= 30; i++)
                if ((i % 2 == 0) && (i % 3 == 0))
                    Console.Write(i + " ");
            Console.WriteLine();
        }


        /// <summary>
        ///     This method prints a line of 10 * with a loop
        ///     Output: **********
        /// </summary>
        public static void PrintLine()
        {
            for (int i = 0; i < 10; i++)
                Console.Write("* ");
            Console.WriteLine();
        }

        /// <summary>
        ///     This method prints a line with a length of 10
        ///     by alternating * and - with a loop
        ///     Output: *-*-*-*-*-
        /// </summary>
        public static void PrintLineComplex()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.Write("*");
                for (int k = 0; k < 1; k++)
                    Console.Write("-");
            }
            Console.WriteLine();
        }

        /// <summary>
        ///     This method prints the following shape:
        ///           ***
        ///           * *
        ///           *** 
        /// </summary>
        public static void PrintRectangle()
        {
            int n = 3;
            for (int row = 0; row  < n; row++)
            {
                for (int column = 0; column < n; column++)
                {
                    Console.Write("* ");
                    if (row == 1 && column == 0)
                    {
                        Console.Write(' ');
                        column += 2;
                        Console.Write(" * ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        /// <summary>
        ///     This method prints a shape with n lines and n columns
        ///     where n is the length parameter.
        ///     Output for 5:
        ///          *****
        ///          *   *
        ///          *   *
        ///          *   *
        ///          *****
        /// </summary>
        public static void PrintRectangleComplex(int length)
        {
            for (int row = 0; row < length; row++)
            {
                for (int column = 0; column < length; column++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        /// <summary>
        ///     This method prints a triangle
        ///     Output:
        ///            *
        ///           ***
        ///          *****
        /// </summary>
        public static void PrintTriangle()
        {
            
        }



        // ----------------------------------------------------
        // ---------- DO NOT MODIFY THE TEST SECTION ----------
        // ----------------------------------------------------
        #region TEST

        /// <summary>
        ///     This method calls all methods within the Sequences class
        /// </summary>
        public static void TestMethods()
        {
            Console.WriteLine("First 10 odd numbers:");
            PrintOddNumbers();

            Console.WriteLine();

            Console.WriteLine("First 10 multiples of 2 and 3:");
            PrintMultiplesOf2And3();

            Console.WriteLine();

            Console.WriteLine("Simple line:");
            PrintLine();

            Console.WriteLine();

            Console.WriteLine("Complex line:");
            PrintLineComplex();

            Console.WriteLine();

            Console.WriteLine("Default rectangle:");
            PrintRectangle();

            Console.WriteLine();

            Console.WriteLine("4 x 4 rectangle:");
            PrintRectangleComplex(4);

            Console.WriteLine();

            Console.WriteLine("10 x 10 rectangle:");
            PrintRectangleComplex(10);

            Console.WriteLine();

            Console.WriteLine("Default triangle:");
            PrintTriangle();
        }
        #endregion
    }
}
