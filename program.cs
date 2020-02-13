using System;

namespace NumeralConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            int option, number, result;
            string hexNum, hexResult;
            
            Console.WriteLine("1- Binary to Decimal");
            Console.WriteLine("2- Decimal to Binary");
            Console.WriteLine("3- Hexadecimal to Decimal");
            Console.WriteLine("4- Decimal to Hexadecimal");
            Console.WriteLine("5- Binary to Hexadecimal");
            Console.WriteLine("6- Hexadecimal to Binary");
            option = Int32.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Number: ");
                    number = Int32.Parse(Console.ReadLine());
                    result = Converter.BinarytoDecimal(number);
                    Console.WriteLine(number + " -> " + result);
                    break;
                case 2:
                    Console.WriteLine("Number: ");
                    number = Int32.Parse(Console.ReadLine());
                    result = Converter.DecimaltoBinary(number);
                    Console.WriteLine(number + " -> " + result);
                    break;
                case 3:
                    Console.WriteLine("Number: ");
                    hexNum = Console.ReadLine();
                    result = Converter.HextoDecimal(hexNum);
                    Console.WriteLine(hexNum + " -> " + result);
                    break;
                case 4:
                   Console.WriteLine("Number: ");
                   number = Int32.Parse(Console.ReadLine());
                   hexResult = Converter.DecimaltoHex(number);
                   Console.WriteLine(number + " -> " + hexResult);
                    break;
                case 5:
                   Console.WriteLine("Number: ");
                   number = Int32.Parse(Console.ReadLine());
                   hexResult = Converter.BinarytoHex(number);
                   Console.WriteLine(number + " -> " + hexResult);
                    break;
                case 6:
                   Console.WriteLine("Number: ");
                   hexNum = Console.ReadLine();
                   result = Converter.HextoBinary(hexNum);
                   Console.WriteLine(hexNum + " -> " + result);
                    break;    
            }

            Console.ReadLine();
        }
    }
}