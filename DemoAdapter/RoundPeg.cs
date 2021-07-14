namespace DemoAdapter
{
    public class RoundPeg : IRound
    {
        private float radius;

        public RoundPeg(int r)
        {
            radius = r;
        }

        public float GetRadius()
        {
            return radius;
        }
    }


}