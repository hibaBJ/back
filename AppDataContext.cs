using AxiaBackend.Model.Entities;
using AxiaBackend.View;
using Microsoft.EntityFrameworkCore;

namespace AxiaBackend
{
    public class AppDataContext:DbContext
    {
        public AppDataContext(DbContextOptions<AppDataContext> options) : base(options) 
        {


        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ViewConge>(c =>
            {
                c.HasNoKey();
                c.ToView("View_Conges");
            });
        }
        public DbSet<Groupe> Groupes { get; set; }
        public DbSet<Employee>Employees { get; set; }
        public DbSet<Paiement> Paiements { get; set; }

        public DbSet<Objectifs>Objectifs { get; set; }
        public DbSet<Pointage> Pointages { get; set; }
        public DbSet<Role> Roles { get; set; }  
        public DbSet<Taches> Taches { get; set; }
        public DbSet<Accessoires> Accessoires { get; set; }
        public DbSet<Conges>Conges { get; set; }
        public DbSet<Attachements> Attachements { get; set;}

        public DbSet<Log>Logs { get; set; }
        public DbSet<TypeConges> TypeConges { get; set; }
        public DbSet<ViewConge> ViewConge { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Login> Logins { get; set; }

    }
}
