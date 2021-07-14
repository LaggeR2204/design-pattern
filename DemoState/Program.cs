using System;
using System.Threading.Tasks;
using DemoState.Character;
using DemoState.State;

namespace DemoState
{
    class Program
    {
        static void Main(string[] args)
        {
            IState initState = new JasonIdleState();
            Jason main = new Jason(initState);
            bool stop = false;
            Task.Run(() =>
            {
                while (true)
                {
                    if (stop)
                        break;
                    ConsoleKeyInfo key = Console.ReadKey();

                    if (key.KeyChar == 'x')
                        main.ChangeState(new JasonJumpState());
                    if (key.KeyChar == 'q')
                        stop = true;
                }
            });
            while (true)
            {
                if (stop)
                    break;
                main.Update();
                main.Render();
            }

            Console.Read();
        }
    }
}
