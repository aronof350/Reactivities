using System;
using Domain;
using Microsoft.EntityFrameworkCore;



namespace Persistence
{
    public class DataContext: DbContext 
    {
        //Datacontext is the constructor, DbContextOptions is a EF parameter we call options. Then passing base class of options. 
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Value> Value{ get; set;}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Value>()
            .HasData(
                new Value {Id = 1, Name = "Aaron"},
                new Value {Id = 2, Name = "Meghan"},
                new Value {Id = 3, Name = "Dean"}
            );

        }

    }
}
