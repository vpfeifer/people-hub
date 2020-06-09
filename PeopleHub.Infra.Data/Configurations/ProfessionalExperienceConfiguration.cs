using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PeopleHub.Domain.Entities;

namespace PeopleHub.Infra.Data.Configurations
{
    public class ProfessionalExperienceConfiguration: IEntityTypeConfiguration<ProfessionalExperience>
    {
        public void Configure(EntityTypeBuilder<ProfessionalExperience> builder)
        {
            builder.ToTable("professional_experience");
            
            builder.HasKey(p => p.Id);

            builder.Property(p => p.InstitutionName).IsRequired();
            
            builder.Property(p => p.Description)
                .HasColumnType("longtext")
                .IsRequired();

            builder.Property(p => p.StartDate).IsRequired();
            builder.Property(p => p.EndDate);
            builder.Property(p => p.IsCurrentJob);
        }
    }
}