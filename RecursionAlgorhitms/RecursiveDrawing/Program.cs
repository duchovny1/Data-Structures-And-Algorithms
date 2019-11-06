using System;

namespace RecursiveDrawing
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            DrawShape(lines);
        }

        private static void DrawShape(int lines)
        {
            if(lines <= 0)
            {
                return;
            }

            Console.WriteLine(new string('*', lines));
            DrawShape(lines - 1);

            Console.WriteLine(new string('#', lines));
        }
    }
}
