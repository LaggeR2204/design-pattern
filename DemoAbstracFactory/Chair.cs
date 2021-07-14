namespace DemoAbstracFactory
{
    public interface IChair
    {
        public string hasLegs();
        public string sitOn();
    }
   public class VictorianChair : IChair
    {
        public string hasLegs()
        {
            return "Victorian Chair has four long legs.";
        }
        public string sitOn()
        {
            return "Sit on Victorian Chair.";
        }
    }
   public class ModernChair : IChair
    {
        public string hasLegs()
        {
            return "Modern Chair has no legs.";
        }
        public string sitOn()
        {
            return "Sit on Modern Chair.";
        }
    }
   
}