using Microsoft.EntityFrameworkCore;
using RegistroPedidosConDetalle.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistroPedidosConDetalle.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Suplidores> Suplidores { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Ordenes> Ordenes { get; set; }
        public DbSet<OrdenesDetalle> OrdenesDetalle { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = Data/GestionPedidos.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Suplidores>().HasData(
                    new Suplidores() { SuplidorId = 1, Nombres = "Pizza Hut" },
                    new Suplidores() { SuplidorId = 2, Nombres = "C&H Technology" },
                    new Suplidores() { SuplidorId = 3, Nombres = "Rica"}
                );

            modelBuilder.Entity<Productos>().HasData(
                new Productos() { ProductoId = 1, Descripcion = "Cartón de jugo de naranja, 1 litro", Costo = 80, Inventario = 110},
                new Productos() { ProductoId = 2, Descripcion = "Cartón de leche Listamilk, 1 litro", Costo = 50, Inventario = 85},
                new Productos() { ProductoId = 3, Descripcion = "Pizza Grande Suprema de Pollo", Costo = 700, Inventario = 1225}
                );
        }
    }
}
