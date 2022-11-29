using System;

namespace Operatros_Livingston_Stephen
{
    class Program
    {
        static void Main(string[] args)
        {
            // INTEGERS
            int intMult = 6 * 45; // Initializes an integer that multiplies two integers

            int intAdd = 55 + 66;  // Initialized an integer that adds to integers

            Console.WriteLine($"The max of {intMult} and {intAdd} is {Math.Max(intMult, intAdd)}." + // Prints the maximum and minimum of the two integer variable
                $"The min of two is {Math.Min(intMult, intAdd)}.");

            bool isIntGreater = intMult > intAdd; // Initializes boolean to see if inMult is greater than inAdd

            Console.WriteLine($"{intMult} is greater than {intAdd}, {isIntGreater}."); // Prints if inMult is greater than inAdd

            // SHORTS
            short shortMult = 6 * 45; // Initializes an shorteger that multiplies two shortegers

            short shortAdd = 55 + 66;  // Initialized an shorteger that adds to shortegers

            Console.WriteLine($"The max of {shortMult} and {shortAdd} is {Math.Max(shortMult, shortAdd)}." + // Prints the maximum and minimum of the two short variable
                $"The min of two is {Math.Min(shortMult, shortAdd)}.");

            bool isshortGreater = shortMult > shortAdd; // Initializes boolean to see if inMult is greater than inAdd

            Console.WriteLine($"{shortMult} is greater than {shortAdd}, {isshortGreater}."); // Prints if inMult is greater than inAdd

            // LONG
            long longMult = 6 * 45; // Initializes an longthat multiplies two long

            long longAdd = 55 + 66;  // Initialized an long that adds to long

            Console.WriteLine($"The max of {longMult} and {longAdd} is {Math.Max(longMult, longAdd)}." + // longs the maximum and minimum of the two long variable
                $"The min of two is {Math.Min(longMult, longAdd)}.");

            bool islongGreater = longMult > longAdd; // Initializes boolean to see if inMult is greater than inAdd

            Console.WriteLine($"{longMult} is greater than {longAdd}, {islongGreater}."); // Prlongs if inMult is greater than inAdd

            // FLOAT
            float floatMult = 6.5f * 45.24f; // Initializes an floa thatt multiplies two float

            float floatAdd = 55.35f + 66.15f;  // Initialized an float that adds to float

            Console.WriteLine($"The max of {floatMult} and {floatAdd} is {Math.Max(floatMult, floatAdd)}." + // floats the maximum and minimum of the two float variable
                $"The min of two is {Math.Min(floatMult, floatAdd)}.");

            bool isfloatGreater = floatMult > floatAdd; // Initializes boolean to see if inMult is greater than inAdd

            Console.WriteLine($"{floatMult} is greater than {floatAdd}, {isfloatGreater}."); // floats if inMult is greater than inAdd

            // DOUBLE
            double doubleMult = 6.69 * 45.58; // Initializes an doubleeger that multiplies two doubleegers

            double doubleAdd = 55.48 + 66.15;  // Initialized an doubleeger that adds to doubleegers

            Console.WriteLine($"The max of {doubleMult} and {doubleAdd} is {Math.Max(doubleMult, doubleAdd)}." + // doubles the maximum and minimum of the two double variable
                $"The min of two is {Math.Min(doubleMult, doubleAdd)}.");

            bool isdoubleGreater = doubleMult > doubleAdd; // Initializes boolean to see if inMult is greater than inAdd

            Console.WriteLine($"{doubleMult} is greater than {doubleAdd}, {isdoubleGreater}."); // doubles if inMult is greater than inAdd

            // DECIMAL
            decimal decimalMult = (decimal)(6.25 * 45.15); // Initializes an decimal that multiplies two decimal

            decimal decimalAdd = (decimal)(55.66 + 66.55);  // Initialized an decimal that adds to decimal

            Console.WriteLine($"The max of {decimalMult} and {decimalAdd} is {Math.Max(decimalMult, decimalAdd)}." + // Prdecimals the maximum and minimum of the two decimal variable
                $"The min of two is {Math.Min(decimalMult, decimalAdd)}.");

            bool isdecimalGreater = decimalMult > decimalAdd; // Initializes boolean to see if inMult is greater than inAdd

            Console.WriteLine($"{decimalMult} is greater than {decimalAdd}, {isdecimalGreater}."); // Prdecimals if inMult is greater than inAdd





        }
    }
}
