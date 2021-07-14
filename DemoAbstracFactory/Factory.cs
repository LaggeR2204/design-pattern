namespace DemoAbstracFactory
{
    public interface IFurnitureFactory
    {
        public IChair createChair();
        public ISofa createSofa();
        public ICoffeeTable createCoffeeTable();
    }
    public class VictorianFurnitureFactory : IFurnitureFactory
    {
        public IChair createChair()
        {
            return new VictorianChair();
        }
        public ISofa createSofa()
        {
            return new VictorianSofa();
        }
        public ICoffeeTable createCoffeeTable()
        {
            return new VictorianCoffeeTable();
        }
    }
    public class ModernFurnitureFactory : IFurnitureFactory
    {
        public IChair createChair()
        {
            return new ModernChair();
        }
        public ISofa createSofa()
        {
            return new ModernSofa();
        }
        public ICoffeeTable createCoffeeTable()
        {
            return new ModernCoffeeTable();
        }
    }
}