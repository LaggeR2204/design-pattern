using DemoState.Character;

namespace DemoState.State
{
    public abstract class JasonBaseState : IState
    {
        protected BaseCharacter context;
        public abstract void render();

        public void setContext(BaseCharacter _context)
        {
            this.context = _context;
        }

        public abstract void update();
    }
}