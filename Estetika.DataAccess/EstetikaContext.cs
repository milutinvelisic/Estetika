using Estetika.DataAccess.Configurations;
using Estetika.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estetika.DataAccess
{
    public class EstetikaContext : DbContext
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DentistConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new TeehConfiguration());
            modelBuilder.ApplyConfiguration(new JawConfiguration());
            modelBuilder.ApplyConfiguration(new JawSideConfiguration());
            modelBuilder.ApplyConfiguration(new JawJawSideTeethConfiguration());
            modelBuilder.ApplyConfiguration(new DentistConfiguration());
            modelBuilder.ApplyConfiguration(new AppointmentConfiguration());
            modelBuilder.ApplyConfiguration(new ContactConfiguration());
            modelBuilder.ApplyConfiguration(new ServiceTypeConfiguration());
            modelBuilder.ApplyConfiguration(new EKartonConfiguration());

            modelBuilder.Entity<Role>().HasQueryFilter(x => !x.IsDeleted);
            modelBuilder.Entity<User>().HasQueryFilter(x => !x.IsDeleted);
            modelBuilder.Entity<Appointment>().HasQueryFilter(x => !x.IsDeleted);
            modelBuilder.Entity<Contact>().HasQueryFilter(x => !x.IsDeleted);
            modelBuilder.Entity<Dentist>().HasQueryFilter(x => !x.IsDeleted);
            modelBuilder.Entity<EKarton>().HasQueryFilter(x => !x.IsDeleted);
            modelBuilder.Entity<Jaw>().HasQueryFilter(x => !x.IsDeleted);
            modelBuilder.Entity<JawSide>().HasQueryFilter(x => !x.IsDeleted);
            modelBuilder.Entity<JawJawSideTooth>().HasQueryFilter(x => !x.IsDeleted);
            modelBuilder.Entity<Teeth>().HasQueryFilter(x => !x.IsDeleted);
            modelBuilder.Entity<ServiceType>().HasQueryFilter(x => !x.IsDeleted);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-HJ4SKN6;Initial Catalog=estetika;Integrated Security=True");
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries())
            {
                if(entry.Entity is EntityBase e)
                {
                    switch (entry.State)
                    {
                        case EntityState.Added:
                            e.IsActive = true;
                            e.CreatedAt = DateTime.Now;
                            e.IsDeleted = false;
                            e.ModifiedAt = null;
                            e.DeletedAt = null;
                            break;

                        case EntityState.Modified:
                            e.ModifiedAt = DateTime.Now;
                            break;
                    }
                }
            }

            return base.SaveChanges();
        }

        public DbSet<Dentist> Dentists { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<EKarton> EKartons { get; set; }
        public DbSet<Jaw> Jaws { get; set; }
        public DbSet<JawSide> JawSides { get; set; }
        public DbSet<JawJawSideTooth> JawJawSideTeeth { get; set; }
        public DbSet<ServiceType> ServiceTypes { get; set; }
        public DbSet<Teeth> Teeths { get; set; }
        public DbSet<UseCaseLog> UseCaseLog { get; set; }
        public DbSet<UserUseCases> UserUseCases { get; set; }
    }
}
