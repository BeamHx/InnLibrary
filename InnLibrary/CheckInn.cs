using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnLibrary
{
    public class CheckInn
    {
        public static bool CorrectFillINN(string innCode)
        {
            if(innCode.Length < 12 || String.IsNullOrEmpty(innCode))
            {
                return false;
            }
            
            int[] coef = { 7, 2, 4, 10, 3, 5, 9, 4, 6, 8, 0 };
            int control = 0;
            for (int i = 0; i < innCode.Length - 2; i++)
            {
                control += Convert.ToInt32(char.GetNumericValue(innCode[i]) * coef[i]);
            }


            int firstNumber = logicLastNumber(control);


            int[] secondCoef = { 3, 7, 2, 4, 10, 3, 5, 9, 4, 6, 8, 0 };


            int secondControl = 0;

            for (int i = 0; i < innCode.Length; i++)
            {
                secondControl += Convert.ToInt32(char.GetNumericValue(innCode[i]) * secondCoef[i]);
            }

            int secondNumber = logicLastNumber(secondControl);


            if (firstNumber == Convert.ToInt32(char.GetNumericValue(innCode[10])) && secondNumber == Convert.ToInt32(char.GetNumericValue(innCode[11])))
            {
                return true;
            }
            return false;
        }

        private static int logicLastNumber(int control)
        {
            int number = control % 11;

            if (number > 9)
            {
                number %= 10;
            }
            return number;
        }
    }
}
