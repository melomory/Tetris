using System;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(40, 30);
            Console.SetBufferSize(40, 30);

            Point p1 = new Point(2, 3, '*');
            Point p2 = new Point(4, 5, '*');
            p1.Draw();
            p2.Draw();

            Console.ReadLine();
        }

    }
}
