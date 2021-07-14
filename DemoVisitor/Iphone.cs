namespace DemoVisitor
{
    public class Iphone : Component
    {
        public string CPU { get; set; }
        public string Ram { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public string GetContent()
        {
            return "Iphone";
        }

        public int GetPrice()
        {
            return 1500;
        }
    }
}