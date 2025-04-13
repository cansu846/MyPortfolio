using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using MyPortfolio.Dal.Entities;

namespace MyPortfolio.Dal.Context
{
    public class MyPortfolioContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //integrated security=true -> baglantım guvenli
            optionsBuilder.UseSqlServer("server=DESKTOP-3ADO5MC\\SQLEXPRESS; initial catalog=MyPortfoliodb; integrated security=true;");
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Experience> Experineces { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
    }
}
