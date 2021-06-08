/* Valiev Linar 220 P
Task: Chess 2
14.03.2021
*/
using System;

namespace FigLib
{
    public static class FigClassMaker
    {
        public static FigClass Make(string pieceCode, int x, int y)
        {
            FigClass piece = null;

            switch (pieceCode)
            {
                case "K":
                    piece = new King(x, y);
                    break;

                case "Q":
                    piece = new Queen(x, y);
                    break;

                case "B":
                    piece = new Bishop(x, y);
                    break;

                case "N":
                    piece = new Knight(x, y);
                    break;

                case "R":
                    piece = new Rook(x, y);
                    break;

                case "P":
                    piece = new Pawn(x, y);
                    break;
            }
            return piece;
        }
    }
    public abstract class FigClass
    {
        protected int X;
        protected int Y;

        public FigClass(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public virtual bool Move(int X1, int Y1)
        {
            return false;
        }
    }

    class Rook : FigClass
    {
        public Rook(int X, int Y) : base(X, Y)
        {
        }

        public override bool Move(int X1, int Y1)
        {
            if (X == X1 || Y == Y1)
            {
                this.X = X1;
                this.Y = Y1;
                return true;
            }
            else
                return false;
        }
    }

    class Knight : FigClass
    {
        public Knight(int X, int Y) : base(X, Y)
        {
        }

        public override bool Move(int X1, int Y1)
        {
            if (Math.Abs(X1 - X) == 1 && Math.Abs(Y1 - Y) == 2 ||
            Math.Abs(X1 - X) == 2 && Math.Abs(Y1 - Y) == 1)
            {
                this.X = X1;
                this.Y = Y1;
                return true;
            }
            else
                return false;
        }
    }

    class Bishop : FigClass
    {
        public Bishop(int X, int Y) : base(X, Y)
        {
        }

        public override bool Move(int X1, int Y1)
        {
            if (Math.Abs(X1 - X) == Math.Abs(Y1 - Y))
            {
                this.X = X1;
                this.Y = Y1;
                return true;
            }
            else
                return false;
        }
    }

    class Queen : FigClass
    {
        public Queen(int X, int Y) : base(X, Y)
        {
        }

        public override bool Move(int X1, int Y1)
        {
            if (X == X1 || Y == Y1 || Math.Abs(X1 - X) == Math.Abs(Y1 - Y))
            {
                this.X = X1;
                this.Y = Y1;
                return true;
            }
            else
                return false;
        }
    }

    class King : FigClass
    {
        public King(int X, int Y) : base(X, Y)
        {
        }

        public override bool Move(int X1, int Y1)
        {
            if (Math.Abs(X1 - X) <= 1 && Math.Abs(Y1 - Y) <= 1)
            {
                this.X = X1;
                this.Y = Y1;
                return true;
            }
            else
                return false;
        }
    }

    class Pawn : FigClass
    {
        public Pawn(int X, int Y) : base(X, Y)
        {
        }

        public override bool Move(int X1, int Y1)
        {
            if (X == X1 && (Y - 1 == Y1 || Y + 1 == Y1))
            {
                this.X = X1;
                this.Y = Y1;
                return true;
            }
            else
                return false;
        }
    }
}