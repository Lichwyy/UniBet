using Microsoft.EntityFrameworkCore;
using UniBet.Entities;
using UniBet.Repositories;

namespace UniBet.Data.Contexts
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users;
        public DbSet<Deposit> Deposits;

        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>()
                .HasKey(user => user.Id);
            
            builder.Entity<Deposit>()
                .HasKey(deposit => deposit.Id);
            builder.Entity<Deposit>()
                .HasOne(dpst => dpst.User)
                .WithMany(usr => usr.Deposits)
                .HasForeignKey(deposit => deposit.UserId);
            base.OnModelCreating(builder);
        }
    }
}
