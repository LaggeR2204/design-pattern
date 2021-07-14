using System;

namespace DemoState.State
{
    public class JasonJumpState : JasonBaseState
    {
        private int height = 100;
        public override void render()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Jason is jumping [Height={height}]");
            Console.ResetColor();
        }

        public override void update()
        {
            if (height == 0)
                context.ChangeState(new JasonRunState());
            else
                height--;

        }
    }
}