using Microsoft.EntityFrameworkCore;
using PeopleHub.Domain.Entities;
using PeopleHub.Infra.Data.Configurations;

namespace PeopleHub.Infra.Data
{
    public class PeopleHubContext : DbContext
    {
        public DbSet<User> Users;
        public DbSet<Post> Posts;
        public DbSet<Group> Groups;
        public DbSet<UserGroup> UserGroups;
        public DbSet<Comment> Comments;
        public DbSet<Education> EducationalBackground;
        public DbSet<ProfessionalExperience> ProfessionalExperience;
        public DbSet<Friend> Friends;
        public DbSet<RelationshipStatus> RelationshipStatus;

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