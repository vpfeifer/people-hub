using System;

namespace PeopleHub.Domain.Entities
{
    public class Education : Entity
    {
        public Education(Guid id,
                         string institutionName,
                         string description,
                         User user,
                         int? yearOfCompletion = null)
                         : this(id, institutionName, description, yearOfCompletion, user.Id)
        {
            User = user;
        }

        private Education(Guid id,
                          string institutionName,
                          string description,
                          int? yearOfCompletion,
                          Guid userId) : base(id)
        {
            InstitutionName = institutionName;
            Description = description;
            YearOfCompletion = yearOfCompletion;
            UserId = userId;
        }

        public string InstitutionName { get; private set; }
        public string Description { get; private set; }
        public int? YearOfCompletion { get; private set; }
        public Guid UserId { get; private set; }
        public virtual User User { get; private set; }

        public void SetYearOfCompletion(int year) => this.YearOfCompletion = year;
    }
}