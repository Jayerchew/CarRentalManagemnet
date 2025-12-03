using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarRentalManagemnet.Domain;
using CarRentalManagement.Configurations.Entities;

namespace CarRentalManagemnet.Data
{
    public class CarRentalManagemnetContext : DbContext
    {
        public CarRentalManagemnetContext (DbContextOptions<CarRentalManagemnetContext> options)
            : base(options)
        {
        }

        public DbSet<CarRentalManagemnet.Domain.Make> Make { get; set; } = default!;
        public DbSet<CarRentalManagemnet.Domain.Model> Model { get; set; } = default!;
        public DbSet<CarRentalManagemnet.Domain.Colour> Colour { get; set; } = default!;
        public DbSet<CarRentalManagemnet.Domain.Vehicle> Vehicle { get; set; } = default!;
        public DbSet<CarRentalManagemnet.Domain.Customer> Customer { get; set; } = default!;
        public DbSet<CarRentalManagemnet.Domain.Booking> Booking { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ColourSeed());
			builder.ApplyConfiguration(new MakeSeed());
			builder.ApplyConfiguration(new ModelSeed());
		}
    }
}
