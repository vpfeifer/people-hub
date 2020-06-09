using System;
using System.Collections.Generic;
using PeopleHub.Domain.Enums;
using PeopleHub.Domain.ValueObjects;

namespace PeopleHub.Domain.Entities
{
    public class User : Entity
    {
        public User(
            Guid id,
            Name name,
            string email,
            DateTime birthDate,
            Gender gender,
            string photoUrl) : this(id, email, birthDate, gender, photoUrl)
        {
            this.Name = name;
        }

        private User(
            Guid id,
            string email,
            DateTime birthDate,
            Gender gender,
            string photoUrl) : base(id)
        {
            this.Email = email;
            this.BirthDate = birthDate;
            this.Gender = gender;
            this.PhotoUrl = photoUrl;
            Posts = new List<Post>();
            Groups = new List<UserGroup>();
            ProfessionalExperience = new List<ProfessionalExperience>();
            EducationalBackground = new List<Education>();
            Friends = new List<Friend>();
            Comments = new List<Comment>();
        }

        public virtual Name Name { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDate { get; private set; }
        public Gender Gender { get; private set; }
        public string PhotoUrl { get; private set; }
        public virtual RelationshipStatus RelationshipStatus { get; set; }
        public virtual ICollection<Post> Posts { get; private set; }
        public virtual ICollection<UserGroup> Groups { get; private set; }
        public virtual ICollection<ProfessionalExperience> ProfessionalExperience { get; private set; }
        public virtual ICollection<Education> EducationalBackground { get; private set; }
        public virtual ICollection<Friend> Friends { get; private set; }
        public virtual ICollection<Comment> Comments { get; private set; }
    }
}