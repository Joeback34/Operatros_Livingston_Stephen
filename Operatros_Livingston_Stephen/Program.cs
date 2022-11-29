using System;

namespace Operatros_Livingston_Stephen
{
    class Program
    {
        static void Main(string[] args)
        {

            int intMult = 6 * 45;
            int intAdd = 55 + 66;

            Console.WriteLine($"The max of {intMult} and {intAdd} is {Math.Max(intMult, intAdd)}." +
                $"The min of two is {Math.Min(intMult, intAdd)}.");

            bool isIntGreater = intMult > intAdd;
            Console.WriteLine($"{intMult} is greater than {intAdd}, {isIntGreater}.");



        }
    }
}
