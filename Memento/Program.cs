using System;
using System.Collections.Generic;
using System.Linq;

namespace MementoPatternDemo
{
    public interface Memento
    {
        string GetState();
    }

    class ConcreteMemento : Memento
    {
        private string _state;

        public ConcreteMemento(string state)
        {
            this._state = state;
        }
        public string GetState()
        {
            return this._state;
        }
    }

    class Originator
    {
        private string _state;

        public void SetState(string state)
        {
            this._state = state;
        }

        public string GetState()
        {
            return this._state;
        }

        public Memento SaveState()
        {
            return new ConcreteMemento(this._state);
        }

        public void UndoState(Memento memento)
        {
            this._state = memento.GetState();
        }
    }

    class Caretaker
    {
        private List<Memento> mementoList = new List<Memento>();

        private Originator origin = null;

        public Caretaker(Originator originator)
        {
            this.origin = originator;
        }

        public void Save()
        {
            this.mementoList.Add(this.origin.SaveState());
        }

        public void Undo()
        {
            if (mementoList.Count != 0)
            {
                origin.UndoState(this.mementoList.Last());
                mementoList.RemoveAt(mementoList.Count - 1);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Originator originator = new Originator();
            Caretaker careTaker = new Caretaker(originator);
            careTaker.Save();

            originator.SetState("State #1");
            originator.SetState("State #2");
            careTaker.Save();

            originator.SetState("State #3");
            careTaker.Save();

            originator.SetState("State #4");
            Console.WriteLine("Current State: " + originator.GetState());

            careTaker.Undo();
            Console.WriteLine("Current State: " + originator.GetState());

            careTaker.Undo();
            Console.WriteLine("Current State: " + originator.GetState());

            careTaker.Undo();
            careTaker.Undo();
            careTaker.Undo();
            Console.WriteLine("Current State: " + originator.GetState());
        }
    }
}
