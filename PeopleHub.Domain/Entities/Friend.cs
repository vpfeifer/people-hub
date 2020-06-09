using System;

namespace PeopleHub.Domain.Entities
{
    public class Friend
    {
        public Friend(User user, User userFriend) : this(user.Id, userFriend.Id)
        {
            User = user;
            UserFriend = userFriend;
        }

        private Friend(Guid userId, Guid friendId)
        {
            UserId = userId;
            FriendId = friendId;
        }

        public Guid UserId { get; private set; }
        public virtual User User { get; private set; }
        public Guid FriendId { get; private set; }
        public virtual User UserFriend { get; private set; }
    }
}