using System;

namespace DemoBridge
{
    public interface IPlatform
    {
        void Render();
    }

    public class Window : IPlatform
    {
        public void Render()
        {
            Console.WriteLine("Window render");
        }
    }

    public class Linux : IPlatform
    {
        public void Render()
        {
            Console.WriteLine("Linux render");
        }
    }
}