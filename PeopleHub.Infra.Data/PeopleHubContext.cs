using Microsoft.EntityFrameworkCore;
using PeopleHub.Domain.Entities;

namespace PeopleHub.Infra.Data
{
    public class PeopleHubContext : DbContext
    {
        public DbSet<User> Users;

        public PeopleHubContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}