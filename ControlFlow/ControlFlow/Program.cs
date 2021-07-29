using System;

namespace ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 4, j = 5, k = 3;
            m += +j++ + ++k;
            Console.WriteLine(m);

            ////loop through 2d array using while loop and modulo
            //const int num_rows = 2;
            //const int num_cols = 5;
            //bool running = true;
            //int row = 0;
            //int col = 0;
            //int spriteno = -1;

            //while (running)
            //{
            //    spriteno = ++spriteno % (num_rows * num_cols);
            //    row = spriteno / num_cols;
            //    col = spriteno % num_cols;
            //    if (spriteno == num_cols * num_rows - 1)
            //    {
            //        running = false;
            //    }
            //}

        }

        public static bool IsEven(int num)
        {
            return num % 2 == 0;
        }

    }
}
