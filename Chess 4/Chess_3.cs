using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_4
{
    // Аретемьев Егор 220П 
    // Шахматы 3
    using System;

    class Chess_3
    {
        static void Main()
        {
            string chess = Console.ReadLine();
            Figure test;
            bool isRightMove = false;

            switch (chess)
            {
                case "K":
                    test = new King(1, 1);
                    isRightMove = test.IsRightMove(2, 1);
                    break;
                case "Q":
                    test = new Queen(1, 1);
                    isRightMove = test.IsRightMove(2, 1);
                    break;
                case "B":
                    test = new Bishop(1, 1);
                    isRightMove = test.IsRightMove(2, 1);
                    break;
                case "N":
                    test = new Knight(1, 1);
                    isRightMove = test.IsRightMove(2, 1);
                    break;
                case "R":
                    test = new Rook(1, 1);
                    isRightMove = test.IsRightMove(2, 1);
                    break;
                default:
                    Console.WriteLine("Unknown piece code. Try again.");
                    break;
            }

            Console.WriteLine(isRightMove ? "YES" : "NO");


        }
    }
    public class Figure
    {
        protected int x;
        protected int y;

        public Figure(int a, int b)
        {
            x = a;
            y = b;
        }

        public virtual bool IsRightMove(int x, int y)
        {
            return true;
        }
    }

    public class King : Figure
    {
        public King(int x, int y) : base(x, y)
        {

        }

        public override bool IsRightMove(int x1, int y1)
        {
            return (Math.Abs(x - x1) <= 1 && Math.Abs(y - y1) <= 1);
        }
    }

    public class Rook : Figure
    {
        public Rook(int x, int y) : base(x, y)
        {

        }

        public override bool IsRightMove(int x1, int y1)
        {
            return (x == x1 || y == y1);
        }
    }

    public class Bishop : Figure
    { 
        public Bishop(int x, int y) : base(x, y)
        {

        }

        public override bool IsRightMove(int x1, int y1)
        {
            return (Math.Abs(x - x1) == Math.Abs(y - y1));
        }
    }

    public class Queen : Figure
    {
        public Queen(int x, int y) : base(x, y)
        {

        }

        public override bool IsRightMove(int x1, int y1)
        {
            return (x == x1 || y == y1 ||
                     Math.Abs(x - x1) == Math.Abs(y - y1));
        }
    }

    public class Knight : Figure
    {
        public Knight(int x, int y) : base(x, y)
        {

        }

        public override bool IsRightMove(int x1, int y1)
        {
            return ((Math.Abs(x - x1) == 2 && Math.Abs(y - y1) == 1) ||
                    (Math.Abs(x - x1) == 1 && Math.Abs(y - y1) == 2));
        }
    }


}
