using Microsoft.AspNet.Identity.EntityFramework;
using N_Tier_Blog.Core.Interfaces.DbContext;
using N_Tier_Blog.Entities.Models.Owin.UserModel;
using N_Tier_Blog.Models.EntityModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Tier_Blog.DataAccess.DbContext
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IDbContext
    {
        public ApplicationDbContext() : base("DefaultConnection", throwIfV1Schema: false)
        {

        }
        public DbSet<Ad> Ads { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleDetail> ArticleDetails { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Picture> Pictures { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<SendMessage> SendMessages { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
        public DbSet<Subcategory> Subcategories { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<UserLog> UserLogs { get; set; }
        public DbSet<VideoAd> VideoAds { get; set; }
    }
}