using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace SubpixelFontgenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");

            string inputString = Console.ReadLine();
            Bitmap bitmap = new Bitmap(inputString.Length * 2, inputString.Split('\n').Count() * 5);

            int column = 0;

            int letterCount = 0;

            foreach (char c in inputString)
            {
                bool[] letterCoding = Letters(c);

                int row = 0; column = letterCount * 2;

                for(int i = 0; i < letterCoding.Length; i+=6)
                {
                    bitmap.SetPixel(column, row, Color.FromArgb(255, 255 * Convert.ToInt32(letterCoding[i] == true), 255 * Convert.ToInt32(letterCoding[i + 1] == true), 255 * Convert.ToInt32(letterCoding[i + 2] == true)));
                    bitmap.SetPixel(column + 1, row, Color.FromArgb(255, 255 * Convert.ToInt32(letterCoding[i + 3] == true), 255 * Convert.ToInt32(letterCoding[i + 4] == true), 255 * Convert.ToInt32(letterCoding[i + 5] == true)));
                    row++;
                }
                
                letterCount++;
            }

            bitmap.Save("test.bmp");
        }



        static private bool[] Letters(char c)
        {
            switch(c)
            {
                case ' ': return new bool[]{
                        false,false,false,false,false,false,
                        false,false,false,false,false,false,
                        false,false,false,false,false,false,
                        false,false,false,false,false,false,
                        false,false,false,false,false,false};

                case 'A':
                    return new bool[]{

                        false,false,true,false,false,false,
                        false,true,false,true,false,false,
                        true,false,false,false,true,false,
                        true,true,true,true,true,false,
                        true,false,false,false,true,false };
                case 'B':
                    return new bool[]{
                        true,true,true,true,false,false,
                        true,false,false,false,true,false,
                        true,true,true,true,false,false,
                        true,false,false,false,true,false,
                        true,true,true,true,false,false};
                case 'C':
                    return new bool[]{
                        true,true,true,true,true,false,
                        true,false,false,false,false,false,
                        true,false,false,false,false,false,
                        true,false,false,false,false,false,
                        true,true,true,true,true,false};
                case 'D':
                    return new bool[]{
                        true,true,true,true,false,false,
                        true,false,false,false,true,false,
                        true,false,false,false,true,false,
                        true,false,false,false,true,false,
                        true,true,true,true,false,false};

                case 'E':
                    return new bool[]{
                        true,true,true,true,true,false,
                        true,false,false,false,false,false,
                        true,true,true,true,false,false,
                        true,false,false,false,false,false,
                        true,true,true,true,true,false};
                case 'F':
                    return new bool[]{
                        true,true,true,true,true,false,
                        true,false,false,false,false,false,
                        true,true,true,true,false,false,
                        true,false,false,false,false,false,
                        true,false,false,false,false,false};
                case 'G':
                    return new bool[]{
                        false,true,true,true,false,false,
                        true,false,false,false,false,false,
                        true,false,true,true,true,false,
                        true,false,false,false,true,false,
                        false,true,true,true,false,false};
                case 'H':
                    return new bool[]{
                        true,false,false,false,true,false,
                        true,false,false,false,true,false,
                        true,true,true,true,true,false,
                        true,false,false,false,true,false,
                        true,false,false,false,true,false};
                case 'I':
                    return new bool[]{
                        false,true,true,true,false,false,
                        false,false,true,false,false,false,
                        false,false,true,false,false,false,
                        false,false,true,false,false,false,
                        false,true,true,true,false,false};
                case 'J':
                    return new bool[]{
                        false,true,true,true,true,false,
                        false,false,false,true,false,false,
                        false,false,false,true,false,false,
                        true,false,false,true,false,false,
                        false,true,true,false,false,false};
                case 'K':
                    return new bool[]{
                        true,false,false,false,true,false,
                        true,false,false,true,false,false,
                        true,true,true,false,false,false,
                        true,false,false,true,false,false,
                        true,false,false,false,true,false};
                case 'L':
                    return new bool[]{
                        true,false,false,false,false,false,
                        true,false,false,false,false,false,
                        true,false,false,false,false,false,
                        true,false,false,false,false,false,
                        true,true,true,true,true,false};
                case 'M':
                    return new bool[]{
                        true,false,false,false,true,false,
                        true,true,false,true,true,false,
                        true,false,true,false,true,false,
                        true,false,false,false,true,false,
                        true,false,false,false,true,false};
                case 'N':
                    return new bool[]{
                        true,false,false,false,true,false,
                        true,true,false,false,true,false,
                        true,false,true,false,true,false,
                        true,false,false,true,true,false,
                        true,false,false,false,true,false};
                case 'O':
                    return new bool[]{
                        false,true,true,true,false,false,
                        true,false,false,false,true,false,
                        true,false,false,false,true,false,
                        true,false,false,false,true,false,
                        false,true,true,true,false,false};
                case 'P':
                    return new bool[]{
                        true,true,true,true,false,false,
                        true,false,false,false,true,false,
                        true,true,true,true,false,false,
                        true,false,false,false,false,false,
                        true,false,false,false,false,false};

                case 'Q':
                    return new bool[]{
                        false,true,true,true,false,false,
                        true,false,false,false,true,false,
                        true,false,false,false,true,false,
                        true,false,false,true,true,false,
                        false,true,true,true,true,false};
                case 'R':
                    return new bool[]{
                        true,true,true,true,false,false,
                        true,false,false,false,true,false,
                        true,true,true,true,false,false,
                        true,false,false,true,false,false,
                        true,false,false,false,true,false};

                case 'S':
                    return new bool[]{

                        false,true,true,true,true,false,
                        true,false,false,false,false,false,
                        false,true,true,true,false,false,
                        false,false,false,false,true,false,
                        true,true,true,true,false,false};

                case 'T':
                    return new bool[]{
                        true,true,true,true,true,false,
                        false,false,true,false,false,false,
                        false,false,true,false,false,false,
                        false,false,true,false,false,false,
                        false,false,true,false,false,false};

                case 'U':
                    return new bool[]{
                        true,false,false,false,true,false,
                        true,false,false,false,true,false,
                        true,false,false,false,true,false,
                        true,false,false,false,true,false,
                        false,true,true,true,false,false};
                case 'V':
                    return new bool[]{
                        true,false,false,false,true,false,
                        true,false,false,false,true,false,
                        true,false,false,false,true,false,
                        false,true,false,true,false,false,
                        false,false,true,false,false,false};
                case 'W':
                    return new bool[]{
                        true,false,false,false,true,false,
                        true,false,false,false,true,false,
                        true,false,true,false,true,false,
                        true,true,false,true,true,false,
                        true,false,false,false,true,false};
                case 'X':
                    return new bool[]{
                        true,false,false,false,true,false,
                        false,true,false,true,false,false,
                        false,false,true,false,false,false,
                        false,true,false,true,false,false,
                        true,false,false,false,true,false};
                case 'Y':
                    return new bool[]{
                        true,false,false,false,true,false,
                        false,true,false,true,false,false,
                        false,false,true,false,false,false,
                        false,false,true,false,false,false,
                        false,false,true,false,false,false};
                case 'Z':
                    return new bool[]{
                        true,true,true,true,true,false,
                        false,false,false,false,true,false,
                        false,false,true,true,false,false,
                        false,true,false,false,false,false,
                        true,true,true,true,true,false};

                default: return null;


            }
        }


    }
}
