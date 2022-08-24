using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace TodoApi.Models
{
    public class TodoContext: IdentityDbContext<IdentityUser>
    {
        public TodoContext(DbContextOptions<TodoContext> options)
               : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public DbSet<TodoItem> TodoItems { get; set; } = null!;
    }
}
