using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PeopleHub.Domain.Entities;

namespace PeopleHub.Infra.Data.Configurations
{
    public class EducationConfiguration: IEntityTypeConfiguration<Education>
    {
        public void Configure(EntityTypeBuilder<Education> builder)
        {
            builder.ToTable("educational_background");
            
            builder.HasKey(e => e.Id);

            builder.Property(e => e.InstitutionName).IsRequired();
            
            builder.Property(c => c.Description)
                .HasColumnType("longtext")
                .IsRequired();

            builder.Property(e => e.YearOfCompletion);
        }
    }
}