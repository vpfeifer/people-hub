using Microsoft.EntityFrameworkCore;
using PeopleHub.Domain.Entities;
using PeopleHub.Infra.Data.Configurations;

namespace PeopleHub.Infra.Data
{
    public class PeopleHubContext : DbContext
    {
        public DbSet<User> Users;
        public DbSet<Post> Posts;
        public DbSet<Document> Documents;
        public DbSet<Group> Groups;
        public DbSet<UserGroup> UserGroups;

        public PeopleHubContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsersConfiguration());
            modelBuilder.ApplyConfiguration(new PostsConfiguration());
            modelBuilder.ApplyConfiguration(new DocumentsConfiguration());
            modelBuilder.ApplyConfiguration(new GroupConfiguration());
            modelBuilder.ApplyConfiguration(new UserGroupConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}