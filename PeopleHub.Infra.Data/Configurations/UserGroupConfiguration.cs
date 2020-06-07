using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PeopleHub.Domain.Entities;

namespace PeopleHub.Infra.Data.Configurations
{
    public class UserGroupConfiguration : IEntityTypeConfiguration<UserGroup>
    {
        public void Configure(EntityTypeBuilder<UserGroup> builder)
        {
            builder.ToTable("user_groups");

            builder.HasKey(ug => new { ug.UserId, ug.GroupId });

            builder.Property(ug => ug.CreatedDate).IsRequired();
            builder.Property(ug => ug.IsAdmin);
        }
    }
}