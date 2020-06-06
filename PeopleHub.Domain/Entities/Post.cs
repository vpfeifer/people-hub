using System;

namespace PeopleHub.Domain.Entities
{
    public class Post : Entity
    {
        public Post(Guid id, string message) : base(id)
        {
            CreatedDate = DateTime.Now;
            Message = message;
        }

        public DateTime CreatedDate { get; private set; }
        public string Message { get; private set; }
        public Guid UserId { get; set; }
        public virtual User User { get; set; }
    }
}