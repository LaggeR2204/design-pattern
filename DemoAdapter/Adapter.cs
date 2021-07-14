using System;

namespace DemoAdapter
{
    public class PegAdapter : IRound
    {
        private SquarePeg squarePeg;
        public PegAdapter(SquarePeg sp)
        {
            squarePeg = sp;
        }
        public float GetRadius()
        {
            return ((float)(squarePeg.getWidth() * Math.Sqrt(2) / 2));
        }
    }   
}