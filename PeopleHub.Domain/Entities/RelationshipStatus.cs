using System;
using PeopleHub.Domain.Enums;

namespace PeopleHub.Domain.Entities
{
    public class RelationshipStatus
    {
        public RelationshipStatus(Relationship relationship)
        {
            Id = (int) relationship;
            Description = Enum.GetName(typeof(Relationship), relationship);
        }

        public RelationshipStatus(int id, string description)
        {
            Id = id;
            Description = description;
        }

        public int Id { get; private set; }
        public string Description { get; private set; }

        public bool Unknown { get { return Id == (int) Relationship.Unknown; } }
        public bool Single { get { return Id == (int) Relationship.Single; } }
        public bool Casual { get { return Id == (int) Relationship.Casual; } }
        public bool Crush { get { return Id == (int) Relationship.Crush; } }
        public bool Dating { get { return Id == (int) Relationship.Dating; } }
        public bool Engaged { get { return Id == (int) Relationship.Engaged; } }
        public bool Married { get { return Id == (int) Relationship.Married; } }
    }
}