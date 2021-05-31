/* Valiev Linar 220 P
Task: Chess 2
14.03.2021
*/
using System;

class Program
{
    static void Main()
    {
        string figure = Console.ReadLine();
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());
        int x1 = Convert.ToInt32(Console.ReadLine());
        int y1 = Convert.ToInt32(Console.ReadLine());

        switch (figure)
        {
            case "K":
                King king = new King(x, y);
                Console.WriteLine($"King: {king.Move(x1, y1)}");
                break;
            case "Q":
                Queen queen = new Queen(x, y);
                Console.WriteLine($"Queen: {queen.Move(x1, y1)}");
                break;
            case "B":
                Bishop bishop = new Bishop(x, y);
                Console.WriteLine($"Bishop: {bishop.Move(x1, y1)}");
                break;
            case "N":
                Knight knight = new Knight(x, y);
                Console.WriteLine($"Knight: {knight.Move(x1, y1)}");
                break;
            case "R":
                Rook rook = new Rook(x, y);
                Console.WriteLine($"Rook: {rook.Move(x1, y1)}");
                break;
            default:
                Console.WriteLine("Unknown piece code. Try again.");
                break;
        }
    }
}
class Figure
{
    protected int X;
    protected int Y;

    public Figure(int X, int Y)
    {
        this.X = X;
        this.Y = Y;
    }

    public virtual bool Move(int X1, int Y1)
    {
        return false;
    }
}

class Rook : Figure
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

class Knight : Figure
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

class Bishop : Figure
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

class Queen : Figure
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

class King : Figure
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
