using System;
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
            string photoUrl, 
            Document document) : this(id, email, birthDate, gender, photoUrl)
        {
            this.Name = name;
            this.Document = document;
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
        }

        public virtual Name Name { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDate { get; private set; }
        public Gender Gender { get; private set; }
        public string PhotoUrl { get; private set; }
        public virtual Document Document { get; private set; }
    }
}