using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    //context nesnesi Db tabloları ile projenin class'larını bağlar
    public class GeekMatchContext:DbContext
    {
        //projenin hangi veritabanı ile ilişkili olduğunu belirttiğimiz kısım
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //@ ile \ olarak algıla deriz
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=GeekMatchDb;Trusted_Connection=True");
        }

        //Hangi class'ımız veritabanında hangi tabloya karşılık geliyor
        
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Customer> Customers { get; set; }
      
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Serie> Series { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<AssessmentBook> AssessmentBooks { get; set; }
        public DbSet<AssessmentMovie> AssessmentMovies { get; set; }
        public DbSet<AssessmentSerie> AssessmentSeries { get; set; }

    }
}
