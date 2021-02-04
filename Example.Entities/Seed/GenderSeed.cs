///// <autogenerated>Remove this line to stop Code Generation</autogenerated>
///// <by>servermodelbuilderseed.txt</by>
///// <module>Gender</module>
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Gender.cs" company="Example">
//   The gender Seed
// </copyright>
// <summary>
//   The gender Seed.
// </summary>
// --------------------------------------------------------------------------------------------------------------------
using System.ComponentModel;
using Microsoft.EntityFrameworkCore;
using Example.Data.Entities;

namespace Example.Entities.Seed
{
    public class GenderBuilder
    {
        public void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Gender>().HasData(new Gender{Id = 1, Title = "Male", }, new Gender{Id = 2, Title = "Female", });
        }
    }
}