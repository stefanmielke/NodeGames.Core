namespace NodeGames.Core
{
    public struct Rectangle
    {
        public Rectangle(int x, int y, int width, int height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }

        public Rectangle(Point location, Point size)
        {
            X = location.X;
            Y = location.Y;
            Width = size.X;
            Height = size.Y;
        }

        public int Height;
        public int X;
        public int Y;
        public int Width;

        public Point Location => new Point(X, Y);
        public int Bottom => Y + Height;
        public Point Size => new Point(Width, Height);

        public void Offset(Point amount)
        {
            X += amount.X;
            Y += amount.Y;
        }

        public bool Contains(Point value)
        {
            if (X <= value.X && value.X < X + Width && Y <= value.Y)
                return value.Y < Y + Height;
            
            return false;
        }
    }
}
