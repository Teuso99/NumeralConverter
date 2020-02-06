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

        public static int HextoDecimal(int number)
        {
            return -1;
        }

        public static int DecimaltoHex(int number)
        {
            return -1;
        }

        public static int BinarytoHex(int number)
        {
            return -1; 
        }

        public static int HextoBinary(int number)
        {
            return -1;
        }
    }
}