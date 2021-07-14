using System;

namespace DemoMediator
{
    public class Event
    {
        public string Name { get; set; }
        public string Data { get; set; }
    }
    // The Mediator interface declares a method used by components to notify the
    // mediator about various events. The Mediator may react to these events and
    // pass the execution to other components.
    public interface IMediator
    {
        void Notify(object sender, Event ev);
    }

    // Concrete Mediators implement cooperative behavior by coordinating several
    // components.
    class FormDialog : IMediator
    {
        private TextBox _tbField;
        private Button _btnSubmit;

        public FormDialog(TextBox filed, Button submit)
        {
            this._tbField = filed;
            this._tbField.SetMediator(this);
            this._btnSubmit = submit;
            this._btnSubmit.SetMediator(this);
        }

        public void Notify(object sender, Event ev)
        {
            if (ev.Name == "Click")
            {
                if (_btnSubmit.IsActive)
                    Console.WriteLine("Submit form");
                else
                    Console.WriteLine("You have fill the text box");
            }
            if (ev.Name == "TextChange")
            {
                if (_tbField.Text != "")
                    _btnSubmit.IsActive = true;
                else
                    _btnSubmit.IsActive = false;
            }
        }
    }

    // The Base Component provides the basic functionality of storing a
    // mediator's instance inside component objects.
    class BaseComponent
    {
        protected IMediator _mediator;

        public BaseComponent(IMediator mediator = null)
        {
            this._mediator = mediator;
        }

        public void SetMediator(IMediator mediator)
        {
            this._mediator = mediator;
        }
    }

    // Concrete Components implement various functionality. They don't depend on
    // other components. They also don't depend on any concrete mediator
    // classes.
    class Button : BaseComponent
    {
        public bool IsActive { get; set; }
        public void Click()
        {
            this._mediator.Notify(this, new Event() { Name = "Click" });
        }
    }

    class TextBox : BaseComponent
    {
        private string _text;

        public string Text
        {
            get => _text;
            set
            {
                _text = value;
                onTextChanged();
            }
        }
        public void onTextChanged()
        {
            this._mediator.Notify(this, new Event() { Name = "TextChange", Data = _text });
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // The client code.
            Button submit = new Button();
            TextBox field = new TextBox();
            new FormDialog(field, submit);

            Console.WriteLine("Client click button.");
            submit.Click();

            Console.WriteLine("Client change text.");
            field.Text = "Text ne";

            Console.WriteLine();

            Console.WriteLine("Client click button.");
            submit.Click();

            Console.ReadKey();
        }
    }
}