using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PeopleHub.Domain.Entities;
using PeopleHub.Domain.Enums;

namespace PeopleHub.Infra.Data.Configurations
{
    public class RelationshipStatusConfiguration: IEntityTypeConfiguration<RelationshipStatus>
    {
        public void Configure(EntityTypeBuilder<RelationshipStatus> builder)
        {
            builder.ToTable("relationship_status");
            
            builder.HasKey(p => p.Id);
            
            builder.Property(p => p.Description)
                .HasMaxLength(50)
                .IsRequired();
            
            builder.HasData(
                new RelationshipStatus(Relationship.Unknown),
                new RelationshipStatus(Relationship.Single),
                new RelationshipStatus(Relationship.Casual),
                new RelationshipStatus(Relationship.Crush),
                new RelationshipStatus(Relationship.Dating),
                new RelationshipStatus(Relationship.Engaged),
                new RelationshipStatus(Relationship.Married)
            );
        }
    }
}