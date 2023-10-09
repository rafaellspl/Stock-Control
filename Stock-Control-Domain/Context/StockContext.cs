using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Stock_Control_Domain.Mapping;
using Stock_Control_Domain.Entities;
using Stock_Control_Domain.Entities.Log;

namespace Stock_Control_Domain.Context
{
    public class StockContext : DbContext
    {
        public StockContext()
        {
            
        }
        public StockContext(DbContextOptions<StockContext> options) : base(options)
        {
        }

        public DbSet<User> Usuarios { get; set; }
        public DbSet<Role> DireitoDeAcesso { get; set; }

        public DbSet<Product> Produtos { get; set; }
        public DbSet<ProductCategory> Categorias { get; set; }

        public DbSet<Change> Modificacoes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySQL("Server=localhost;Database=StockControl;Uid=root;Pwd=Rafael789.;SslMode=Preferred;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new RoleMap());

            modelBuilder.ApplyConfiguration(new ProductMap());
            modelBuilder.ApplyConfiguration(new ProductCategoryMap());

            modelBuilder.ApplyConfiguration(new ChangeMap());

            

        }

        

    }
}
