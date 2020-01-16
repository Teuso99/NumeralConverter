using System;

namespace NumeralConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;
            string number;
            
            Console.WriteLine("1- Binary to Decimal");
            Console.WriteLine("2- Decimal to Binary");
            Console.WriteLine("3- Hexadecimal to Decimal");
            Console.WriteLine("4- Decimal to Hexadecimal");
            Console.WriteLine("5- Binary to Hexadecimal");
            Console.WriteLine("6- Hexadecimal to Binary");
            option = Console.ReadLine();

            switch (option)
            {
                case 1:
                    Console.WriteLine("Number: ");
                    number = Console.ReadLine();
                    Converter.BinarytoDecimal(number);
                    break;
                case 2:
                    Console.WriteLine("Number: ");
                    number = Console.ReadLine();
                    Converter.DecimaltoBinary(number);
                    break;
                case 3:
                    Console.WriteLine("Number: ");
                    number = Console.ReadLine();
                    Converter.HextoDecimal(number);
                    break;
                case 4:
                    Console.WriteLine("Number: ");
                    number = Console.ReadLine();
                    Converter.DecimaltoHex(number);
                    break;
                case 5:
                    Console.WriteLine("Number: ");
                    number = Console.ReadLine();
                    Converter.BinarytoHex(number);
                    break;
                case 6:
                    Console.WriteLine("Number: ");
                    number = Console.ReadLine();
                    Converter.HextoBinary(number);
                    break;    
            }

            Console.ReadLine();
        }
    }
}