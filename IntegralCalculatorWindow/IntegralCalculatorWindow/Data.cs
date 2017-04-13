using System;
using System.Collections.Generic;

namespace IntegralCalculatorWindow
{
    class Data
    {
        public List<double> Coefficients = new List<double>();  //list for coefficients
        public int CountX { get; set; }             //count of coefficients
        public int CountOfTrapeze { get; set; }     //count of trapeze
        public double LimitDown { get; set; }       //down limit of integral
        public double LimitUp { get; set; }         //up limit of integral
        public double OnePartOfIntegral { get; set; } 

        public void CompletionFunction(string data)    //comlete information about integral
        {
            /*
            try
            {
                Console.SetCursorPosition(0, 8);
                Console.Write("Podaj stopień wielomianu: ");
                CountX = (Convert.ToInt32(Console.ReadLine()));

                for (int i = CountX; i >= 0; i--)
                {
                    Console.Write("\nPodaj współczynnik dla X^" + i + " : ");
                    Coefficients.Add(Convert.ToDouble(Console.ReadLine()));
                }

                Console.Write("\nGranica dolna: ");
                LimitDown = Convert.ToDouble(Console.ReadLine());
                Console.Write("\nGranica górna: ");
                LimitUp = Convert.ToDouble(Console.ReadLine());
                if (LimitDown > LimitUp) Interface.Work();  //if true program restart

                Console.Write("\nIle trapezów: ");
                CountOfTrapeze = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception E)
            {
                Interface.Work();
            }
            */
            //new function

            try
            {
                Coefficients.Add(Convert.ToDouble(data));
            }
            catch
            {
                //add error window
            }


        }

        public void PrintInfo() //method print all information about function
        {
            Console.Clear();
            Interface.FixWindow();
            Console.SetCursorPosition(0, 8);
            Console.Write("Twoja funkcja to: F(x) = ");
            int i = CountX;
            foreach (double X in Coefficients)
            {
                Console.Write("(" + X + ")" + "X^" + i);
                if (i >= 1) Console.Write(" + ");
                i--;
            }
            Console.WriteLine(" ");
            Console.WriteLine("Granica od: " + LimitDown + "; do: " + LimitUp);
            Console.WriteLine("Ilość trapezów: " + CountOfTrapeze);
        }
    }
}
