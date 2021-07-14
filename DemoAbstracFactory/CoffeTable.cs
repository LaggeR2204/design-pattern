namespace DemoAbstracFactory
{
    public interface ICoffeeTable
    {
        public string hasLegs();
        public string sitOn();
    }
    
   public class VictorianCoffeeTable : ICoffeeTable
    {
        public string hasLegs()
        {
            return "Victorian Coffee Table has four long legs.";
        }
        public string sitOn()
        {
            return "Sit on Victorian Coffee Table.";
        }
    }
   public class ModernCoffeeTable : ICoffeeTable
    {
        public string hasLegs()
        {
            return "Modern Coffee Table has no legs.";
        }
        public string sitOn()
        {
            return "Sit on Modern Coffee Table.";
        }
    }
}