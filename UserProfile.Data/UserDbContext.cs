using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserProfile.Common.Modals;

namespace UserProfile.Data
{
    public class UserDbContext: DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options) { }

        public DbSet<UserModel> Users { get; set; }
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> 14e31e8 (v2.1)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserModel>()
                .HasOne(u => u.Credentials)
                .WithOne(c => c.User)
                .HasForeignKey<LoginModel>(c => c.Id);
        }

<<<<<<< HEAD
=======
>>>>>>> origin/master
=======
>>>>>>> 1a5c9ac (Dev mohit (#1))
=======
>>>>>>> 1a5c9ac (Dev mohit (#1))
=======
>>>>>>> 14e31e8 (v2.1)
    }
}
