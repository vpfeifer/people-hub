using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PeopleHub.Domain.Entities;

namespace PeopleHub.Infra.Data.Configurations
{
    public class GroupConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.ToTable("groups");
            
            builder.HasKey(g => g.Id);

            builder.Property(g => g.Name)
                .IsRequired()
                .HasMaxLength(100);
            
            builder.Property(g => g.Description)
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(g => g.PhotoUrl)
                .IsRequired()
                .HasMaxLength(500);
            
            builder.HasMany(g => g.Posts).WithOne(p => p.Group);
        }
    }
}