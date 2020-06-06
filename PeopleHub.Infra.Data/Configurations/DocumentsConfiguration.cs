using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PeopleHub.Domain.Entities;

namespace PeopleHub.Infra.Data.Configurations
{
    public class DocumentsConfiguration : IEntityTypeConfiguration<Document>
    {
        public void Configure(EntityTypeBuilder<Document> builder)
        {
            builder.ToTable("documents");
            builder.HasKey(d => d.Id);
            builder.Property(d => d.Type).IsRequired();
            builder.Property(d => d.Number).HasMaxLength(40).IsRequired();
        }
    }
}