using DemoState.Character;
using System;
namespace DemoState.State
{
    public class JasonIdleState : JasonBaseState
    {
        public override void render()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Jason is idling.[stamina={context.Stamina}]");
            Console.ResetColor();
        }

        public override void update()
        {
            if (context.Stamina >= 20)
                context.ChangeState(new JasonRunState());
            context.Stamina++;
        }
    }
}