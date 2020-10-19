using System;
using ComplexCalculatorService;

namespace ConsoleComplexCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string sOption ="";

            do
            {

                double firsRealValue = 0; double secondRealValue = 0; double firstImaginaryValue = 0; double secondImaginaryValue = 0;
                var ComplexCalc = new ComplexServicesClient();
                var FirstComplex = new ComplexType();
                var SecondComplex = new ComplexType();
                string result = "";

                Console.WriteLine("Console Complex Calculator\r");
                Console.WriteLine("------------------------\n");

                Console.WriteLine("Proszę wybrać opcje z listy:\n");
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts - Subtract");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Divide");
                Console.WriteLine("\taC - Complex(Add)");
                Console.WriteLine("\tsC - Complex(Subtract)");
                Console.WriteLine("\tmC - Complex(Multiply)");
                Console.WriteLine("\tdC - Complex(Divide)");
                Console.WriteLine("\tc - czyść console");
                Console.WriteLine("\te - zakończ");
                sOption = Console.ReadLine();

                if (sOption != "c" && sOption != "e")
                {
                    Console.WriteLine("Wpisz pierwszą liczbę rzeczywista");
                    firsRealValue = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Wpisz druga liczbę rzeczywista");
                    secondRealValue = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Wpisz pierwszą liczbę urojona");
                    firstImaginaryValue = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Wpisz druga liczbę urojona");
                    secondImaginaryValue = Convert.ToInt32(Console.ReadLine());
                }

                switch (sOption)
                {
                    case "a":
                        result = ComplexCalc.AddFourValueAsync(firsRealValue,secondRealValue,firstImaginaryValue,secondImaginaryValue).Result;
                        Console.WriteLine(result);
                        break;
                    case "s":
                        result = ComplexCalc.SubtractFourValue(firsRealValue, secondRealValue, firstImaginaryValue, secondImaginaryValue);
                        Console.WriteLine(result);
                        break;
                    case "m":
                        result = ComplexCalc.MultiplyFourValue(firsRealValue, secondRealValue, firstImaginaryValue, secondImaginaryValue);
                        Console.WriteLine(result);
                        break;
                    case "d":
                        result = ComplexCalc.DivisionFourValue(firsRealValue, secondRealValue, firstImaginaryValue, secondImaginaryValue);
                        Console.WriteLine(result);
                        break;
                    case "aC":
                        FirstComplex.RealValueOperation = firsRealValue;
                        FirstComplex.ImaginryValueOperation = firstImaginaryValue;
                        SecondComplex.RealValueOperation = secondRealValue;
                        SecondComplex.ImaginryValueOperation = secondImaginaryValue;
                        result = ComplexCalc.AddTwoValue(FirstComplex,SecondComplex);
                        Console.WriteLine(result);
                        break;
                    case "sC":
                        FirstComplex.RealValueOperation = firsRealValue;
                        FirstComplex.ImaginryValueOperation = firstImaginaryValue;
                        SecondComplex.RealValueOperation = secondRealValue;
                        SecondComplex.ImaginryValueOperation = secondImaginaryValue;
                        result = ComplexCalc.SubtractTwoValue(FirstComplex, SecondComplex);
                        Console.WriteLine(result);
                        break;
                    case "mC":
                        FirstComplex.RealValueOperation = firsRealValue;
                        FirstComplex.ImaginryValueOperation = firstImaginaryValue;
                        SecondComplex.RealValueOperation = secondRealValue;
                        SecondComplex.ImaginryValueOperation = secondImaginaryValue;
                        result = ComplexCalc.MultiplyTwoValue(FirstComplex, SecondComplex);
                        Console.WriteLine(result);
                        break;
                    case "dC":
                        FirstComplex.RealValueOperation = firsRealValue;
                        FirstComplex.ImaginryValueOperation = firstImaginaryValue;
                        SecondComplex.RealValueOperation = secondRealValue;
                        SecondComplex.ImaginryValueOperation = secondImaginaryValue;
                        result = ComplexCalc.DivisionTwoValue(FirstComplex, SecondComplex);
                        Console.WriteLine(result);
                        break;
                    case "c":
                        Console.Clear();
                        break;
                }


            } while (sOption != "e");
        }
    }
}
