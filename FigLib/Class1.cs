using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigLib
{
    public class FigMaker
    {
        public static FigClass Make(string FigClassCode, int x, int y)
        {
            FigClass FigClass = null;

            switch (FigClassCode)
            {
                case "King":
                    FigClass = new King(x, y);
                    break;

                case "Queen":
                    FigClass = new Queen(x, y);
                    break;

                case "Bishop":
                    FigClass = new Bishop(x, y);
                    break;

                case "Knight":
                    FigClass = new Knight(x, y);
                    break;

                case "Rook":
                    FigClass = new Rook(x, y);
                    break;

                case "Pawn":
                    FigClass = new Pawn(x, y);
                    break;
            }
            return FigClass;
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
    class King : FigClass
    {
        public King(int newX, int newY) : base(newX, newY)
        {
        }

        public override bool Move(int newX, int newY)
        {
            return (Math.Abs(X - newX) <= 1 && Math.Abs(Y - newY) <= 1);
        }
    }

    class Queen : FigClass
    {
        public Queen(int newX, int newY) : base(newX, newY)
        {
        }

        public override bool Move(int newX, int newY)
        {
            return (X == newX || Y == newY || Math.Abs(X - newX) == Math.Abs(Y - newY));
        }
    }

    class Bishop : FigClass
    {
        public Bishop(int newX, int newY) : base(newX, newY)
        {
        }

        public override bool Move(int newX, int newY)
        {
            return (Math.Abs(X - newX) == Math.Abs(Y - newY));
        }
    }

    class Knight : FigClass
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

    class Rook : FigClass
    {
        public Rook(int newX, int newY) : base(newX, newY)
        {
        }

        public override bool Move(int newX, int newY)
        {
            return (X == newX || Y == newY);
        }
    }

    class Pawn : FigClass
    {
        public Pawn(int newX, int newY) : base(newX, newY)
        {
        }

        public override bool Move(int newX, int newY)
        {
            return (X == newX && (Y - 1 == newY || Y + 1 == newY));
        }
    }
}



