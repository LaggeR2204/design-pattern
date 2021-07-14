namespace DemoAbstracFactory
{
    public interface ISofa
    {
        public string hasLegs();
        public string sitOn();
    }
    public class VictorianSofa : ISofa
    {
        public string hasLegs()
        {
            return "Victorian Sofa has four long legs.";
        }
        public string sitOn()
        {
            return "Sit on Victorian Sofa.";
        }
    }
    public class ModernSofa : ISofa
    {
        public string hasLegs()
        {
            return "Modern Sofa has no legs.";
        }
        public string sitOn()
        {
            return "Sit on Modern Sofa.";
        }
    }


}