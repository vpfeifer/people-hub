using System;

namespace PeopleHub.Domain.Entities
{
    public class UserGroup
    {
        public UserGroup(DateTime createdDate,
                         bool isAdmin,
                         User user,
                         Group group) : this(createdDate, isAdmin, user.Id, group.Id)
        {
            CreatedDate = createdDate;
            IsAdmin = isAdmin;
            User = user;
            Group = group;
        }

        private UserGroup(DateTime createdDate,
                         bool isAdmin,
                         Guid userId,
                         Guid groupId)
        {
            CreatedDate = createdDate;
            IsAdmin = isAdmin;
            UserId = userId;
            GroupId = groupId;
        }

        public DateTime CreatedDate { get; private set; }
        public bool IsAdmin { get; private set; }

        public Guid UserId { get; private set; }
        public virtual User User { get; private set; }

        public Guid GroupId { get; private set; }
        public virtual Group Group { get; private set; }
    }
}