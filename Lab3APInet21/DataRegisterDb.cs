using Lab3APInet21.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab3APInet21
{
    public class DataRegisterDb : DbContext
    {
        public DataRegisterDb(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Hobby> Hobbies { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<WebbLink> WebbLinks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=PersonHobbys; Integrated Security=SSPI;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Person>()
            //    .HasMany(h => h.Hobbies)
            //    .WithOne(p => p.Person);

            //modelBuilder.Entity<Hobby>()
            //    .HasOne(p => p.Person)
            //    .WithMany(p => p.Hobbies);

            //modelBuilder.Entity<WebbLink>()
            //    .HasOne(c => c.Hobby)
            //    .WithMany(s => s.WebbLinks);


            modelBuilder.Entity<Person>()
                .HasData(
                new {PersonId = 1, Name = "Tony", PhoneNumber = "0701231233"},
                new {PersonId = 2, Name = "Banner", PhoneNumber = "070321321"},
                new {PersonId = 3, Name = "Rogers", PhoneNumber = "0703123123"},
                new {PersonId = 4, Name = "Thor", PhoneNumber = "0704141444"},
                new {PersonId = 5, Name = "Strange", PhoneNumber = "0705555112"}
                );

            modelBuilder.Entity<Hobby>()
                .HasData(
                new {HobbyId = 1, Titel = "Cars", Description ="Make them Shine", PersonId= 1},
                new {HobbyId = 2, Titel = "Cars", Description ="Make them Fast", PersonId = 2},
                new {HobbyId = 3, Titel = "Magic", Description ="Teleports", PersonId = 5},
                new {HobbyId = 4, Titel = "Magic", Description ="Lightning", PersonId = 4},
                new {HobbyId = 5, Titel = "WorkOut", Description ="Train Legs", PersonId = 2},
                new {HobbyId = 6, Titel = "WorkOut", Description ="Train Arms", PersonId = 3},
                new {HobbyId = 7, Titel = "Cars", Description ="Make them Weird", PersonId = 5},
                new {HobbyId = 8, Titel = "Math", Description = "Calculate stuff", PersonId = 1}
                );

            modelBuilder.Entity<WebbLink>()
                .HasData(
                new { WebbLinkId = 1, Link ="FakeLinkForHobby1", HobbyId = 1},
                new { WebbLinkId = 2, Link ="FakeLinkForHobby1", HobbyId = 2},
                new { WebbLinkId = 3, Link ="FakeLinkForHobby2", HobbyId = 3},
                new { WebbLinkId = 4, Link ="FakeLinkForHobby2", HobbyId = 4},
                new { WebbLinkId = 5, Link ="FakeLinkForHobby3", HobbyId = 5},
                new { WebbLinkId = 6, Link ="FakeLinkForHobby3", HobbyId = 6},
                new { WebbLinkId = 7, Link ="FakeLinkForHobby4", HobbyId = 7},
                new { WebbLinkId = 8, Link ="FakeLinkForHobby4", HobbyId = 8}
                );
        }
    }
}
