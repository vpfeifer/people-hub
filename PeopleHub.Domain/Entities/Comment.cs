using System;

namespace PeopleHub.Domain.Entities
{
    public class Comment : Entity
    {
        public Comment(Guid id, string commentText, User user) : this(id, commentText, user.Id)
        {
            User = user;
        }

        private Comment(Guid id, string commentText, Guid userId) : base(id)
        {
            CommentText = commentText;
            UserId = userId;
            CreatedDate = DateTime.Now;
        }

        public DateTime CreatedDate { get; private set; }
        public string CommentText { get; private set; }
        public Guid UserId { get; private set; }
        public virtual User User { get; private set; }
    }
}