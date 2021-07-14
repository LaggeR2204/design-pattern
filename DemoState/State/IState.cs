using DemoState.Character;

namespace DemoState.State
{
    public interface IState
    {
        public void render();
        public void update();

        public void setContext(BaseCharacter _context);
    }
}