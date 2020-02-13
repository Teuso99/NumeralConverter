using System;

namespace NumeralConverter
{
    static class Converter
    {
        public static int BinarytoDecimal(int number)
        {
            int result = 0 , x = 0, aux;

            while(number != 0)
            {
                aux = number % 10;
                number /= 10;
                result += aux * (int)Math.Pow(2, x);
                x++;
            }

            return result;
        }

        public static int DecimaltoBinary(int number)
        {
            int aux, x = 1, result = 0;
            
            
            while(number != 0)
            {
                aux = number % 2;
                number /= 2;
                result += aux * x;
                x *= 10;
            }

            return result;
        }

        public static int HextoDecimal(string number)
        {
            int result = int.Parse(number, System.Globalization.NumberStyles.HexNumber);
            
            return result;
        }

        public static string DecimaltoHex(int number)
        {
            string result = number.ToString("X");
            
            return result;
        }

        public static string BinarytoHex(int number)
        {
            string result;
            int aux;

            aux = Converter.BinarytoDecimal(number);
            result = Converter.DecimaltoHex(aux);

            return result; 
        }

        public static int HextoBinary(string number)
        {
            int result, aux;

            aux = Converter.HextoDecimal(number);
            result = Converter.DecimaltoBinary(aux);
            
            return result;
        }
    }
}