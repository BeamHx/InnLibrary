using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "454510869905";

            int[] coef = { 7, 2, 4, 10, 3, 5, 9, 4, 6, 8, 0 };
            int control = 0;
            for (int i = 0; i < str.Length - 2; i++)
            {
                control += Convert.ToInt32(char.GetNumericValue(str[i]) * coef[i]);
            }

            Console.WriteLine(control);
            int firstNumber = logicLastNumber(control);
            Console.WriteLine(firstNumber);

            int[] secondCoef = { 3, 7, 2, 4, 10, 3, 5, 9, 4, 6, 8, 0 };


            int secondControl = 0;

            for (int i = 0; i < str.Length; i++)
            {
               secondControl += Convert.ToInt32(char.GetNumericValue(str[i]) * secondCoef[i]);
            }
            Console.WriteLine(secondControl);
            int secondNumber = logicLastNumber(secondControl);
            Console.WriteLine(secondNumber);

            if (firstNumber == Convert.ToInt32(char.GetNumericValue(str[10])) && secondNumber == Convert.ToInt32(char.GetNumericValue(str[11])))
            {
                Console.WriteLine("инн верный");
            }

            
        }
        private static int logicLastNumber(int control)
        {
            int number = control % 11;
            Console.WriteLine(number);
            if (number > 9)
            {
                number /= 10;
            }
            return number;
        }
    }
}
