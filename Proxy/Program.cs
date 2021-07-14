using System;

namespace CommandProxyPatternDemo
{
    public interface ICommand
    {
        void RunCommand(string cmd);
    }

    class Command : ICommand
    {
        public void RunCommand(string cmd)
        {
            Console.WriteLine("Running: " + cmd);
        }
    }

    class CommandProxy : ICommand
    {
        private Command _Command;
        private bool _isAdmin = false;

        public CommandProxy(bool isAd)
        {
            this._Command = new Command();
            this._isAdmin = isAd;
        }

        public void RunCommand(string cmd)
        {
            if (cmd == "apt update")
            {
                if (this.CheckAccess())
                {
                    this._Command.RunCommand(cmd);
                }
                else
                {
                    Console.WriteLine("This command is not allowed for non-admin users");
                }
            }
            else
            {
                this._Command.RunCommand(cmd);
            }
        }

        public bool CheckAccess()
        {
            if (this._isAdmin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Non-admin user: ");
            CommandProxy commandProxy = new CommandProxy(false);
            commandProxy.RunCommand("ls");
            commandProxy.RunCommand("apt update");
            Console.WriteLine("-----------------------------------------------------");

            Console.WriteLine("Admin user: ");
            CommandProxy commandProxyAdmin = new CommandProxy(true);
            commandProxyAdmin.RunCommand("ls");
            commandProxyAdmin.RunCommand("apt update");
        }
    }
}
