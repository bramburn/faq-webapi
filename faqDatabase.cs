using FAQApi.Models;
using Microsoft.EntityFrameworkCore;

namespace FAQApi;

public class faqDatabase:DbContext
{
    public DbSet<Answers> Answers { get; set; } = null!;
    public DbSet<Questions> Questions { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Host=localhost;Username=faq_user;Password=shadow123;Database=faq");
        base.OnConfiguring(optionsBuilder);
    }
}