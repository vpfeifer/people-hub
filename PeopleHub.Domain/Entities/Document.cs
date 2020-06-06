using System;
using PeopleHub.Domain.Enums;

namespace PeopleHub.Domain.Entities
{
    public class Document : Entity
    {
        public Document(Guid id, DocumentType type, string number) : base(id)
        {
            Type = type;
            Number = number;
        }

        public DocumentType Type { get; private set; }

        public string Number { get; private set; }

        public Guid UserId { get; private set; }

        public virtual User User { get; set; }
    }
}