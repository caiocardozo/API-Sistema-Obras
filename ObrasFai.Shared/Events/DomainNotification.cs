﻿using System;
using ObrasFai.Shared.Events.Contracts;

namespace ObrasFai.Shared.Events
{
    public class DomainNotification : IDomainEvent
    {
        public string Key { get; private set; }
        public string Value { get; private set; }
        public DateTime DateOccurred { get; private set; }

        public DomainNotification(string key, string value)
        {
            this.Key = key;
            this.Value = value;
            this.DateOccurred = DateTime.Now;
        }
    }
}
