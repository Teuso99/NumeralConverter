using System;

namespace NumeralConverter
{
    static class Converter
    {
        public static void BinarytoDecimal(string number)
        {
            int result, y = 0;

            for (int x = sizeof(number) - 1; x == 0; x--)
            {
                result += (int)number[x] * Math.Pow(y, 2);
                y++;
            }

            Console.WriteLine(number + " -> " + result);
        }

        public static void DecimaltoBinary(string number)
        {
            
        }

        public static void HextoDecimal(string number)
        {
            
        }

        public static void DecimaltoHex(string number)
        {
            
        }

        public static void BinarytoHex(string number)
        {
            
        }

        public static void HextoBinary(string number)
        {
            
        }
    }
}