using System;

namespace PeopleHub.Domain.Entities
{
    public class Relationship : Entity
    {
        public Relationship(Guid id) : base(id)
        {
        }

        public string Description { get; private set; }
    }
}