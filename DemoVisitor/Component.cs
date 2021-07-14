namespace DemoVisitor
{
    public interface Component
    {
        int GetPrice();
        string GetContent();
        void Accept(IVisitor visitor);
    }
}