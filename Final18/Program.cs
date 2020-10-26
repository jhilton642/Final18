using System;

namespace Final18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the height you would like your triangle: ");
            int height = Convert.ToInt32(Console.ReadLine());
            Program.DrawTriangle(height);
        }
        public static void DrawTriangle(int height)
        {
            string space = " ";
            string asterisk = "*";
            int spaces = height - 1;
            int asteriskCount = 1;
            int middleSpaces = -1;
            for(int i = 1; i < height; i++)
            {
                for (int j = 0; j < spaces; j++)
                {
                    Console.Write(space);
                }
                    Console.Write(asterisk);
                for (int j = 0; j < middleSpaces; j++)
                {
                    Console.Write(space);
                }
                if (asteriskCount > 1)
                {
                    Console.Write(asterisk);
                }
                middleSpaces += 2;
                spaces--;
                Console.WriteLine();
                asteriskCount += 2;
            }
            for(int i = 0; i< asteriskCount; i++)
            {
                Console.Write(asterisk);
            }
        }
    }
}
