using System;

namespace DemoBridge
{
    class Client
    {
        public void ClientCode(Button button)
        {
            button.Render();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
             Client client = new Client();

            Button abstraction;
            
            abstraction = new Button(new Window());
            client.ClientCode(abstraction);
            
            Console.WriteLine();
            
            abstraction = new ToggleButton(new Linux());
            client.ClientCode(abstraction);
        }
    }
}
