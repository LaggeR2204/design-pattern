namespace DemoBridge
{
    public class Button
    {
        protected IPlatform _platform;

        public Button(IPlatform platform)
        {
            this._platform = platform;
        }

        public virtual void Render()
        {
            _platform.Render();
        }
    }

    public class ToggleButton : Button
    {
        public ToggleButton(IPlatform platform) : base(platform)
        {
            
        }
        public override void Render()
        {
            base.Render();
        }

        public bool Enable {get; set;}
    }
}