using System;
using System.Collections.Generic;
using System.Threading;

namespace DemoObserver
{
    public interface ISubscriber
    {
        void Update(IPublisher publisher);
    }

    public interface IPublisher
    {
        void Attach(ISubscriber subcriber);

        void Detach(ISubscriber subcriber);

        void Notify();
    }

    public class Store : IPublisher
    {
        public int State { get; set; } = 0;

        private List<ISubscriber> _subcribers = new List<ISubscriber>();


        public void Attach(ISubscriber subcriber)
        {
            Console.WriteLine("Store: Attached an subcriber.");
            this._subcribers.Add(subcriber);
        }

        public void Detach(ISubscriber subcriber)
        {
            this._subcribers.Remove(subcriber);
            Console.WriteLine("Store: Detached an subcriber.");
        }

        public void Notify()
        {
            Console.WriteLine("Store: Notifying observers...");

            foreach (var subcriber in _subcribers)
            {
                subcriber.Update(this);
            }
        }


        public void Import(int amount)
        {
            Console.WriteLine($"\nStore: Nhap hang vao kho, so luong ={amount}");
            this.State = amount;

            Thread.Sleep(15);

            this.Notify();
        }
    }

    class Customer : ISubscriber
    {
        public void Update(IPublisher publisher)
        {
            if ((publisher as Store).State > 0)
            {
                Console.WriteLine("Customer: Chuan bi xin tien` me mua Iphone nao`.");
            }
        }
    }

    class Agency : ISubscriber
    {
        public void Update(IPublisher publisher)
        {
            if ((publisher as Store).State > 5)
            {
                Console.WriteLine("Agency: Chuan bi nhap hang` ve` ban' nao`.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // The client code.
            var publisher = new Store();
            var customer = new Customer();

            publisher.Attach(customer);

            var agency = new Agency();
            publisher.Attach(agency);

            publisher.Import(3);
            publisher.Import(9);

            publisher.Detach(agency);

            publisher.Import(1);
        }
    }
}
