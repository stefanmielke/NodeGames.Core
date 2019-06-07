using System;

namespace NodeGames.Core
{
    public struct Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static Point operator +(Point a, Point b)
        {
            return new Point(a.X + b.X, a.Y + b.Y);
        }

        public static Point operator -(Point a, Point b)
        {
            return new Point(a.X - b.X, a.Y - b.Y);
        }

        public static Point Zero => new Point(0, 0);

        public int DistanceTo(Point finish)
        {
            float num2 = Y - finish.Y;
            float num1 = X - finish.X;
            return (int) Math.Sqrt(num1 * (double) num1 + num2 * (double) num2);
        }
    }
}