using System;

namespace Restaurant
{
    public interface IMealFlyweight
    {
        string Name { get; }
        void Serve(string size);
    }
}
