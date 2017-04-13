using System;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;

namespace IntegralCalculatorWindow
{
    class Integral : Data    //that class have methods to count Integral
    {
        double OnePartOfIntegral;   //far of one step on OX (basis of trapeze)

        public void CountIntegral()
        {
            //FarOfTrapeze();
            Console.WriteLine("\nWynik podanej całki to: " + CountAllTrapeze());
        }
        /*
        private void FarOfTrapeze()  //count of basis of one trapeze
        {
            OnePartOfIntegral = (LimitUp - LimitDown) / CountOfTrapeze;
        }
        */
        private double CountAllTrapeze()
        {
            double Score = 0;
            for (int i = 0; i < CountOfTrapeze; i++)
            {

                //Score = Score + CountOneTrapeze((i * OnePartOfIntegral) + LimitDown);
            }
            return Score;
        }

        private double CountOneTrapeze(double StartPunkt)    //method count one trapez
        {
            double Base = CountOneWall(StartPunkt) + CountOneWall(StartPunkt + OnePartOfIntegral);
            double Score = (Base * OnePartOfIntegral) / 2;  //main patern for trapeze
            return Score;
        }

        public double CountOneWall(double ActualX)  //count value y for actual x
        {
            double Score = 0;   //value of y
            int Count = CountX;

            for (int i = 0; i < CountX; i++)   //calculation of the whole function for one x
            {
                double I = Coefficients[i]; //save one of coefficient
                Score += (I * PowerOfX(ActualX, Count - 1));
                Count--;    //that give us access to the coefficient
            }
            return Score;
        }

        private double PowerOfX(double ActualX, int CountOfPower)   //count one of the power
        {
            double Score = ActualX;

            for (int i = 0; i < CountOfPower - 1; i++)
            {
                Score = Score * ActualX;
            }
            try
            {
                if (CountOfPower == 0) Score = 1; //Coefficients[CountX - 1];    //if x^0 then score = last coefficients 
            }
            catch (Exception EX)
            {
                //Interface.Work();
            }
            return Score;
        }
    }
}
