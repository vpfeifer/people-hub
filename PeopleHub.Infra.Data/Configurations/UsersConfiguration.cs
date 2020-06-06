using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PeopleHub.Domain.Entities;

namespace PeopleHub.Infra.Data.Configurations
{
    public class UsersConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("users");
            builder.HasKey(u => u.Id);
            builder.OwnsOne(u => u.Name)
                .Property(u => u.FirstName)
                .HasColumnName("FirstName")
                .HasMaxLength(50)
                .IsRequired();
            builder.OwnsOne(u => u.Name)
                .Property(u => u.LastName)
                .HasColumnName("LastName")
                .HasMaxLength(150)
                .IsRequired();
            builder.Property(u => u.Email).HasMaxLength(150).IsRequired();
            builder.Property(u => u.BirthDate).IsRequired();
            builder.Property(u => u.Gender).IsRequired();
            builder.Property(u => u.PhotoUrl).HasMaxLength(400);
            builder.HasOne(u => u.Document)
                .WithOne(d => d.User)
                .HasForeignKey<Document>(d => d.UserId);
            builder.HasMany(u => u.Posts)
                .WithOne(p => p.User);
        }
    }
}