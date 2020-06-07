using System;

namespace PeopleHub.Domain.Entities
{
    public class Friend
    {
        public Friend(Guid userId, User user, Guid friendId, User userFriend)
        {
            UserId = userId;
            User = user;
            FriendId = friendId;
            UserFriend = userFriend;
        }

        public Guid UserId { get; private set; }
        public virtual User User { get; private set; }
        public Guid FriendId { get; private set; }
        public virtual User UserFriend { get; private set; }
    }
}