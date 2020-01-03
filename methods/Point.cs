using System;

namespace methods
{
    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        // Problem we are duplicating the same process twice
        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        // public void Move(Point newLocation)
        // {
        //     this.X = newLocation.X;
        //     this.Y = newLocation.Y;
        // }

        // calling the Move method
        public void Move(Point newLocation) // This can run into a null reference exception, how to fix? Validate
        {
            if(newLocation == null) // This is defensive programming
                throw new ArgumentNullException("newLocation");
            Move(newLocation.X, newLocation.Y);
        }
    }
}
