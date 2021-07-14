using System;

namespace CommandPatternDemo
{
    public class Light
    {
        public void SwitchOn()
        {
            Console.WriteLine("Switch light on");
        }
        public void SwitchOff()
        {
            Console.WriteLine("Switch light off");
        }
    }
    public interface ICommand
    {
        void Execute();
    }

    class CommandOff : ICommand
    {
        private Light _light;

        public CommandOff(Light light)
        {
            this._light = light;
        }

        public void Execute()
        {
            _light.SwitchOff();
        }
    }

    class CommandOn : ICommand
    {
        private Light _light;

        public CommandOn(Light light)
        {
            this._light = light;
        }

        public void Execute()
        {
            _light.SwitchOn();
        }
    }

    class RemoteControl
    {
        private ICommand _command;
        public void SetCommand(ICommand command)
        {
            this._command = command;
        }

        public void PressButton()
        {
            _command.Execute();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            RemoteControl rc = new RemoteControl();
            Light light = new Light();
            ICommand c1 = new CommandOff(light);
            ICommand c2 = new CommandOn(light);
            rc.SetCommand(c1);
            rc.PressButton();

            rc.SetCommand(c2);
            rc.PressButton();
        }
    }
}
