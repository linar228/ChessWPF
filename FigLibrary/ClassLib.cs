using System;

namespace Library
{
    public class ClassLib
    {
        public static Figure Make(string figureCode, int x, int y)
        {
            Figure figure = null;

            switch (figureCode)
            {
                case "K":
                    figure = new King(x, y);
                    break;

                case "Q":
                    figure = new Queen(x, y);
                    break;

                case "B":
                    figure = new Bishop(x, y);
                    break;

                case "N":
                    figure = new Knight(x, y);
                    break;

                case "R":
                    figure = new Rook(x, y);
                    break;

                case "P":
                    figure = new Pawn(x, y);
                    break;
            }
            return figure;
        }
    }

    public abstract class Figure
    {
        protected int X;
        protected int Y;

        public Figure(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public abstract bool Move(int X, int Y);

        public bool PreMove(int X, int Y)
        {
            if (Move(X, Y))
            {
                this.X = X;
                this.Y = Y;
                return true;
            }
            return false;
        }
    }
    class King : Figure
    {
        public King(int newX, int newY) : base(newX, newY)
        {
        }

        public override bool Move(int newX, int newY)
        {
            return (Math.Abs(X - newX) <= 1 && Math.Abs(Y - newY) <= 1);
        }
    }

    class Queen : Figure
    {
        public Queen(int newX, int newY) : base(newX, newY)
        {
        }

        public override bool Move(int newX, int newY)
        {
            return (X == newX || Y == newY || Math.Abs(X - newX) == Math.Abs(Y - newY));
        }
    }

    class Bishop : Figure
    {
        public Bishop(int newX, int newY) : base(newX, newY)
        {
        }

        public override bool Move(int newX, int newY)
        {
            return (Math.Abs(X - newX) == Math.Abs(Y - newY));
        }
    }

    class Knight : Figure
    {
        public Knight(int newX, int newY) : base(newX, newY)
        {
        }

        public override bool Move(int newX, int newY)
        {
            return ((Math.Abs(X - newX) == 2 && Math.Abs(Y - newY) == 1) ||
                    (Math.Abs(X - newX) == 1 && Math.Abs(Y - newY) == 2));
        }
    }

    class Rook : Figure
    {
        public Rook(int newX, int newY) : base(newX, newY)
        {
        }

        public override bool Move(int newX, int newY)
        {
            return (X == newX || Y == newY);
        }
    }

    class Pawn : Figure
    {
        public Pawn(int newX, int newY) : base(newX, newY)
        {
        }

        public override bool Move(int newX, int newY)
        {
            return ((X == newX && Y == 7 && newY == 5) ||
                    (X == newX && Y == 2 && newY == 4) ||
                    (X == newX && (Y - 1 == newY || Y + 1 == newY)));
        }
    }
}


