using System;

namespace NumeralConverter
{
    static class Converter
    {
        public static void BinarytoDecimal(string number)
        {
            int result = 0 , y = 0;

            for (int x = number.Length - 1; x == 0; x--)
            {
                result += (int)number[x] * (int)Math.Pow(y, 2);
                y++;
            }

            Console.WriteLine(number + " -> " + result);
        }

        public static void DecimaltoBinary(string number)
        {
            /*
            int aux, y = 0, result;
            bool greaterThan = true;
            //string binary;

            aux = Int32.Parse(number);

            //implementar métodos/recursão
            while(greaterThan)
            {
                if(aux > Math.Pow(2,y))
                {
                    y++;
                }
                else if(aux == Math.Pow(2,y))
                {
                    result = (int)Math.Pow(10, y);
                    greaterThan = false;
                }
                else if(aux < Math.Pow(2,y))
                {
                    aux = (int)Math.Pow(2,y) - aux;
                    //binary = " ";
                    y--;
                }
            }
            */
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