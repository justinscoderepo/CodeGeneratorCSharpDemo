///// <autogenerated>Remove this line to stop Code Generation</autogenerated>
///// <by>servermodelbuilderseed.txt</by>
///// <module>Category</module>
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Category.cs" company="Example">
//   The category Seed
// </copyright>
// <summary>
//   The category Seed.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
using System.ComponentModel;
using Microsoft.EntityFrameworkCore;
using Example.Data.Entities;

namespace Example.Entities.Seed
{
    public class CategoryBuilder
    {
        public void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(new Category{Name = "Category 1", Description = "category desc", Id = 1, });
        }
    }
}