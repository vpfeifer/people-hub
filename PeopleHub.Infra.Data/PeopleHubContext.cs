using Microsoft.EntityFrameworkCore;
using PeopleHub.Domain.Entities;
using PeopleHub.Infra.Data.Configurations;

namespace PeopleHub.Infra.Data
{
    public class PeopleHubContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<UserGroup> UserGroups { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Education> EducationalBackground { get; set; }
        public DbSet<ProfessionalExperience> ProfessionalExperience { get; set; }
        public DbSet<Friend> Friends { get; set; }
        public DbSet<RelationshipStatus> RelationshipStatus { get; set; }

        public PeopleHubContext(DbContextOptions options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsersConfiguration());
            modelBuilder.ApplyConfiguration(new PostsConfiguration());
            modelBuilder.ApplyConfiguration(new GroupConfiguration());
            modelBuilder.ApplyConfiguration(new UserGroupConfiguration());
            modelBuilder.ApplyConfiguration(new CommentsConfiguration());
            modelBuilder.ApplyConfiguration(new EducationConfiguration());
            modelBuilder.ApplyConfiguration(new FriendsConfiguration());
            modelBuilder.ApplyConfiguration(new ProfessionalExperienceConfiguration());
            modelBuilder.ApplyConfiguration(new RelationshipStatusConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}