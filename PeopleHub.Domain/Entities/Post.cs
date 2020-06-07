using System;

namespace PeopleHub.Domain.Entities
{
    public class Post : Entity
    {
        public Post(Guid id,
                    string message,
                    User user,
                    Group group) : this(id, message,user.Id, group.Id)
        {
            CreatedDate = DateTime.Now;
            Message = message;
            User = user;
            Group = group;
        }

        private Post(Guid id,
                    string message,
                    Guid userId,
                    Guid groupId) : base(id)
        {
            CreatedDate = DateTime.Now;
            Message = message;
            UserId = userId;
            GroupId = groupId;
        }

        public DateTime CreatedDate { get; private set; }
        public string Message { get; private set; }
        public Guid UserId { get; private set; }
        public virtual User User { get; private set; }
        public Guid GroupId { get; private set; }
        public virtual Group Group { get; private set; }
    }
}