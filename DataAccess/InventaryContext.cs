using Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace DataAccess
{
    public class InventaryContext : DbContext
    {
        public DbSet<ProductEntity> Products { get; set; }
        public DbSet<CategoryEntity> Categories { get; set; }
        public DbSet<InputOutputEntity> InOuts { get; set; }
        public DbSet<WareHouseEntity> Warehouses { get; set; }
        public DbSet<StorageEntity> Storages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
                options.UseSqlServer("Server = DESKTOP-A52QQCF\\SQLEXPRESS; Database = InventoryDB; Trusted_Connection = True; ");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CategoryEntity>().HasData(
                new CategoryEntity { CategoryId = "ASH", CategoryName = "Aseo Hogar" },
                new CategoryEntity { CategoryId = "ASP", CategoryName = "Aseo Personal" },
                new CategoryEntity { CategoryId = "PLL", CategoryName = "Pollo" }
                );
            modelBuilder.Entity<WareHouseEntity>().HasData(
                new WareHouseEntity
                {
                    WarehouseId = Guid.NewGuid().ToString(),
                    WarehouseName = "Bodega Central",
                    WarehouseAdress = "Calle 8 con 23"
                },
                new WareHouseEntity
                {
                    WarehouseId = Guid.NewGuid().ToString(),
                    WarehouseName = "Bodega Norte",
                    WarehouseAdress = "Calle 12 con 23"
                },
                new WareHouseEntity
                {
                    WarehouseId = Guid.NewGuid().ToString(),
                    WarehouseName = "Bodega Sur",
                    WarehouseAdress = "Calle 5 con 17"
                }
                );
            modelBuilder.Entity<ProductEntity>().HasData(
                new ProductEntity
                {
                    ProductId = "P-01",
                    ProductName = "Pechuga Amarilla de campo",
                    ProductDescription = "Comprado al galpon del pollo de Cali",
                    CategoryId = "PLL"
                },
               new ProductEntity
               {
                   ProductId = "P-02",
                   ProductName = "Alas con costillar Amarilla de campo",
                   ProductDescription = "Comprado al galpon del pollo de Cali",
                   CategoryId = "PLL"
               },
               new ProductEntity
               {
                   ProductId = "P-03",
                   ProductName = "Pernil Amarillo de campo",
                   ProductDescription = "Comprado al galpon del pollo de Cali",
                   CategoryId = "PLL"
               },
               new ProductEntity
               {
                   ProductId = "A-01",
                   ProductName = "Talcos para los pies",
                   ProductDescription = "Nueva línea",
                   CategoryId = "ASP"
               },
               new ProductEntity
               {
                   ProductId = "H-01",
                   ProductName = "Limpido",
                   ProductDescription = "Buena calidad",
                   CategoryId = "ASH"
               }
                );
        }

    }
}
