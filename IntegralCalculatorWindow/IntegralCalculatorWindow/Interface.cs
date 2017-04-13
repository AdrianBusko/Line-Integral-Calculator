using System;

namespace IntegralCalculatorWindow
{
    class Interface
    {
        static public void Work()
        {
            while (true)
            {
                Console.Clear();
                Integral In = new Integral();
                FixWindow();
                //In.CompletionFunction();    //set information about function
                In.PrintInfo();

                In.CountIntegral();
                Console.ReadKey(true);  //program wait to user
            }
        }

        static public void FixWindow()  //method set information about program
        {
            Console.WindowWidth = 120;
            Console.WindowHeight = 30;
            Console.Title = "©Adrian Buśko           Integral calculator";
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Program napisał Adrian Buśko");
            Console.ResetColor();
            Console.WriteLine("Witaj, program ten oblicza całki oznaczone");
            Console.WriteLine("Zasady Działania:");
            Console.WriteLine("-By dodać liczbę niecałkowitą należy posłużyć się znakiem [,]");
            Console.WriteLine("-By dodać liczbę ujemną należy posłużyć się znakiem [-] przed daną liczbą");
            Console.WriteLine("-W razie podania zmiennej złego typu program rozpocznie się ponownie");
            Console.WriteLine("-Wszystkie wprowadzone dane należy zatwierdzać klawiszem [ENTER]");
        }
    }
}
