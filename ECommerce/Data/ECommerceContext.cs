using ECommerce.Models;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.Data
{
    public class ECommerceContext:DbContext
    {
        public ECommerceContext(DbContextOptions<ECommerceContext> options): base(options)
        { 
        
        }

        public virtual DbSet<Carrito> carrito { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }

    }
}
