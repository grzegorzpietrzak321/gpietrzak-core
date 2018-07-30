using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using gpietrzak.Models;
using gpietrzak.Models.Blog;

namespace gpietrzak.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<ApplicationUser>()
                .HasMany(c => c.Articles)
                .WithOne(e => e.ApplicationUser);

            builder.Entity<Article>()
                .HasMany(a => a.Comments)
                .WithOne(c => c.Article);
            
            builder.Entity<ArticleCategory>()
                .HasKey(ac => new {ac.ArticleId, ac.CategoryId});
            builder.Entity<ArticleCategory>()
                .HasOne(ac => ac.Article)
                .WithMany(c => c.ArticleCategories)
                .HasForeignKey(pc => pc.ArticleId);
            builder.Entity<ArticleCategory>()
                .HasOne(c => c.Category)
                .WithMany(ca => ca.ArticleCategories)
                .HasForeignKey(c => c.CategoryId);

            builder.Entity<ArticleTags>()
                .HasKey(ac => new { ac.ArticleId, ac.TagId });
            builder.Entity<ArticleTags>()
                .HasOne(ac => ac.Article)
                .WithMany(c => c.ArticleTagses)
                .HasForeignKey(pc => pc.ArticleId);
            builder.Entity<ArticleTags>()
                .HasOne(c => c.Tag)
                .WithMany(ca => ca.ArticleTagses)
                .HasForeignKey(c => c.TagId);



            base.OnModelCreating(builder);

            


            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
