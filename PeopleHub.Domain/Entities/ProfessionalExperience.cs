using System;

namespace PeopleHub.Domain.Entities
{
    public class ProfessionalExperience : Entity
    {
        public ProfessionalExperience(Guid id,
                                      string institutionName,
                                      string description,
                                      DateTime startDate,
                                      DateTime endDate,
                                      bool isCurrentJob,
                                      User user) : this(id, institutionName, description, startDate, endDate, isCurrentJob, user.Id)
        {
            User = user;
        }

        private ProfessionalExperience(Guid id,
                                      string institutionName,
                                      string description,
                                      DateTime startDate,
                                      DateTime endDate,
                                      bool isCurrentJob,
                                      Guid userId) : base(id)
        {
            InstitutionName = institutionName;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
            IsCurrentJob = isCurrentJob;
            UserId = userId;
        }

        public string InstitutionName { get; private set; }
        public string Description { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public bool IsCurrentJob { get; private set; }
        public Guid UserId { get; private set; }
        public virtual User User { get; private set; }
    }
}