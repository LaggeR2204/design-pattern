using System;

namespace DemoState.State
{
    public class JasonRunState : JasonBaseState
    {
        public override void render()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Jason is running.[stamina={context.Stamina}]");
            Console.ResetColor();
        }

        public override void update()
        {
            if (context.Stamina <= 0)
                context.ChangeState(new JasonIdleState());
            else
                context.Stamina--;
        }
    }
}