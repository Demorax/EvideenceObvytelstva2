using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvideenceObvytelstva2.Models
{
    public class ApplicationDB:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=C:\\Users\\tomas\\source\\repos\\EvideenceObvytelstva2\\DB\\test1.db");
        }
        public DbSet<Osoba> Osobas { get; set; }

        public DbSet<Adresa> Adresses { get; set; }

        public DbSet<Student> Students { get; set; }
        public DbSet<Zamestnanec> Zamestnanecs { get; set; }

        public DbSet<Skola> Skolas { get; set; }

        public DbSet<Zamestnani> Zamestnanis { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Osoba - Adresa
            modelBuilder.Entity<Osoba>()
                .HasOne(p => p.Adresa)
                .WithMany(a => a.Osobas)
                .HasForeignKey(p => p.AddressId)
                .OnDelete(DeleteBehavior.Restrict);
            //Osoba - Student
            modelBuilder.Entity<Osoba>()
               .HasOne(p => p.Student)
               .WithOne(s => s.Osoba)
               .HasForeignKey<Osoba?>(s => s.StudentId)
               .OnDelete(DeleteBehavior.Restrict);
            //Osoba - zamestnanec
            modelBuilder.Entity<Osoba>()
               .HasOne(p => p.Zamestnanec)
               .WithOne(z => z.Osoba)
               .HasForeignKey<Osoba?>(s => s.ZamestnanecId)
               .OnDelete(DeleteBehavior.Restrict);
            //Student - Skola
            modelBuilder.Entity<Student>()
               .HasOne(p => p.Skola)
               .WithMany(a => a.Students)
                .HasForeignKey(p => p.SkolaId)
                .OnDelete(DeleteBehavior.Restrict);
            //Zamestnanec - Zamestnani
            modelBuilder.Entity<Zamestnanec>()
               .HasOne(p => p.Zamestnani)
               .WithMany(a => a.Zamestnanecs)
                .HasForeignKey(p => p.ZamestnaniId)
                .OnDelete(DeleteBehavior.Restrict);
            //Zamestnani - Adresa
            modelBuilder.Entity<Zamestnani>()
               .HasOne(p => p.Adresa)
               .WithMany(a => a.Zamestnanis)
                .HasForeignKey(p => p.AdresaId)
                .OnDelete(DeleteBehavior.Restrict);
            //Skola - Adresa
            modelBuilder.Entity<Skola>()
               .HasOne(p => p.Adresa)
               .WithMany(a => a.Skolas)
                .HasForeignKey(p => p.AdresaId)
                .OnDelete(DeleteBehavior.Restrict);

            //Nastovovani primárních klíčů
            modelBuilder.Entity<Osoba>().HasKey(p => p.Id);
            modelBuilder.Entity<Student>().HasKey(p => p.Id);
            modelBuilder.Entity<Adresa>().HasKey(p => p.Id);
            modelBuilder.Entity<Zamestnanec>().HasKey(p => p.Id);
            modelBuilder.Entity<Skola>().HasKey(p => p.Id);
            modelBuilder.Entity<Zamestnani>().HasKey(p => p.Id);
        }

    }


}
