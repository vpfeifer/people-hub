using System;

namespace PeopleHub.Domain.Entities
{
    public abstract class Entity
    {
        public Guid Id { get; private set; }
    }
}