using System;
using System.Collections.Generic;
using CrashOnMiss.Interfaces;
using Zenject;

namespace CrashOnMiss.Broadcasters
{
    internal abstract class EventBroadcaster<T> : IInitializable, IDisposable where T : IEventHandler
    {
        [Inject] protected List<T> EventHandlers = new List<T>();
        
        public abstract void Initialize();
        
        public abstract void Dispose();
    }
}