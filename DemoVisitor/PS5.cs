namespace DemoVisitor
{
    public class PS5 : Component
    {
        public string Power { get; set; }
        public string Weight { get; set; }
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public string GetContent()
        {
            return "PS5";
        }

        public int GetPrice()
        {
            return 1000;
        }
    }
}