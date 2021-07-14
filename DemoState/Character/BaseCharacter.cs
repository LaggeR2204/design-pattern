using DemoState.State;

namespace DemoState.Character
{
    public abstract class BaseCharacter : IStateChangeable
    {
        protected IState state;
        protected int stamina;

        public int Stamina { get; set; }

        public void ChangeState(IState _state)
        {
            this.state = _state;
            this.state.setContext(this);
        }
    }
}