using System;
using System.Collections.Generic;

namespace Observers
{
    public abstract class AbstractStringSubject : ISubject<AbstractStringSubject>
    {   
        private string _item;
        public string Item 
        {   
            get => _item; 

            set
            {
                _item = value;

                foreach (var obs in _observers)
                {
                    // pull (observer)
                    obs.Update(this);
                }
            } 
        }

        private readonly ISet<IObserver<AbstractStringSubject>> _observers;
        
        
        public AbstractStringSubject()
        {
            _observers = new HashSet<IObserver<AbstractStringSubject>>();
        }


        public void RegisterObserver(IObserver<AbstractStringSubject> obs)
        {
            _observers.Add(obs);
        }


        public void RemoveObserver(IObserver<AbstractStringSubject> obs)
        {
            _observers.Remove(obs);
        }
    }
}