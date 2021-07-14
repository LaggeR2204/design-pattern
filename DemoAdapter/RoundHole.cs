namespace DemoAdapter
{
    public class RoundHole
    {
        private float radius;
        public RoundHole(float r)
        {
            radius = r;
        }

        public bool fits(IRound round)
        {
            return radius >= round.GetRadius();
        }
    }
}