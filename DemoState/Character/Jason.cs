using DemoState.State;

namespace DemoState.Character
{
    public class Jason : BaseCharacter
    {
        public void Update()
        {
            state.update();
        }
        public void Render()
        {
            state.render();
        }

        public Jason(IState _initState)
        {
            ChangeState(_initState);
        }

    }
}