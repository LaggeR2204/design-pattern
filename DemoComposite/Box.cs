using System.Collections.Generic;

namespace DemoComposite
{
    public class Box : Component
    {
        // public bool HasBill { get; set; }
        // public string Sender { get; set; }
        // public string Receiver { get; set; }
        // public bool hasPayed { get; set; }

        private List<Component> _children = new List<Component>();

        public void Add(Component component)
        {
            this._children.Add(component);
        }
        public void Remove(Component component)
        {
            this._children.Remove(component);
        }
        public string GetContent()
        {
            int i = 0;
            string result = "Box(";

            foreach (Component cp in _children)
            {
                result += cp.GetContent();
                if (i != _children.Count - 1)
                    result += "+";
                i++;
            }
            return result += ")";
        }

        public int GetPrice()
        {
            int total = 0;
            foreach (Component cp in _children)
            {
                total += cp.GetPrice();
            }
            return total;
        }
    }
}