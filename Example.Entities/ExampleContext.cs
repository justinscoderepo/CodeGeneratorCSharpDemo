///// <autogenerated>Remove this line to stop Code Generation</autogenerated>
///// <by>serverdbcontext.txt</by>
///// <module>Gender</module>
using Example.Data.Entities;
using Example.Entities.Seed;
using Microsoft.EntityFrameworkCore;
using System;

namespace Example.Entities
{
    /// <summary>
    /// ExampleDbContext class
    /// </summary>
    public class ExampleDbContext : DbContext
    {
        //// region ModuleListEntity#
        public virtual DbSet<User> User
        {
            get;
            set;
        }

        public virtual DbSet<Gender> Gender
        {
            get;
            set;
        }

        public virtual DbSet<Category> Category
        {
            get;
            set;
        }

        //// endregion ModuleListEntity#       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //// region ModuleListModelBuilderSeed#
            new GenderBuilder().Seed(modelBuilder);
            new CategoryBuilder().Seed(modelBuilder);
        //// endregion ModuleListModelBuilderSeed#       
        }

        public ExampleDbContext(DbContextOptions<ExampleDbContext> options): base(options)
        {
        }
    }
}