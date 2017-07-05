using System;
using System.Collections.Generic;
using ObrasFai.Shared.Events.Contracts;

namespace ObrasFai.Shared
{
    public interface IHandler<T> : IDisposable where T : IDomainEvent
    {
        void Handle(T args);
        IEnumerable<T> Notify();
        bool HasNotifications();
    }
}
