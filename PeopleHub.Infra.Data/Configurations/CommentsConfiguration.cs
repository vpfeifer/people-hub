using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PeopleHub.Domain.Entities;

namespace PeopleHub.Infra.Data.Configurations
{
    public class CommentsConfiguration: IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("comments");
            
            builder.HasKey(c => c.Id);

            builder.Property(c => c.CreatedDate).IsRequired();
            builder.Property(c => c.CommentText)
                .HasColumnType("longtext")
                .IsRequired();
        }
    }
}