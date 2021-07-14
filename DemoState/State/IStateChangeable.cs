using DemoState.Character;

namespace DemoState.State
{
    public interface IStateChangeable
    {
        public void ChangeState(IState _state);
    }
}