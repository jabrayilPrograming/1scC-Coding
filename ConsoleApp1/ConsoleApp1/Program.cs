using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Calculate
            /* Console.WriteLine("Enter number:");
             string mainNumber = Console.ReadLine();
             Calculate(mainNumber);*/
            #endregion
            #region findNum
            /*Console.WriteLine("Enter number N:");
            string N = Console.ReadLine();
            Console.WriteLine("Enter number M:");
            string M = Console.ReadLine();
            findNum(N, M);*/
            #endregion

        }
        #region Calculate method
        /*static void Calculate(string mainNumber)
        {
            int sumNumbers=0;   
            for (int i = 0; i < mainNumber.ToString().Length; i++) {
                int convertNumber = int.Parse(mainNumber[i].ToString());
                sumNumbers +=convertNumber;
            }
            Console.WriteLine(sumNumbers);
            
        }*/
        #endregion
        #region findNum
        /*
        static void findNum(string num1,string num2)
        {
            double sum = 0;
            int count = 0;
            for (int i = int.Parse(num1); i < int.Parse(num2); i++)
            {
                if (i % 21 == 0)
                {
                    sum += i;
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No number divide by 21");
            } else
            {
                Console.WriteLine(sum/count);
            }
        }*/
        #endregion
     
    }
}
