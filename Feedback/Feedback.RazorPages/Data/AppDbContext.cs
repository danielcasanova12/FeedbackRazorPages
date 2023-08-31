using Feedback.RazorPages.Models;
using Microsoft.EntityFrameworkCore;

namespace Feedback.RazorPages.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<FeedbackModel>? Feedbacks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("DataSource=Feedbacks.db;Cache=Shared");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FeedbackModel>().ToTable("Feedback");
        }
    }
}
