using System;
using System.Collections.Generic;

namespace PeopleHub.Domain.Entities
{
    public class Group : Entity
    {
        public Group(Guid id,
                     string name,
                     string description,
                     string photoUrl) : base(id)
        {
            Name = name;
            Description = description;
            PhotoUrl = photoUrl;
            Posts = new List<Post>();
        }

        public string Name { get; private set; }
        public string Description { get; private set; }
        public string PhotoUrl { get; private set; }
        public virtual ICollection<Post> Posts { get; private set; }
        public virtual ICollection<UserGroup> Groups { get; private set; }
    }
}