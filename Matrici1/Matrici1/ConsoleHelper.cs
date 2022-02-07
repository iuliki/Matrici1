using System;
using System.Collections.Generic;
using System.Text;

namespace Matrici1
{
    public static class ConsoleHelper
    {
        public static int ReadNumber(string label, int maxTries, int defaltValue)
        {
            int currentTry = 0;
            do
            {
                Console.WriteLine(label);
                string valueAsString = Console.ReadLine();
                int valueAsNumber;
                bool isNumber = int.TryParse(valueAsString, out valueAsNumber);

                if (isNumber)
                {
                    return valueAsNumber;
                }
                currentTry++;
            } while (currentTry < maxTries);

            return defaltValue;
           
           
        }
    }
}
