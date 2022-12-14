namespace ECommerce.Models
{
    public class Carrito
    {
        public Carrito()
        {
            Productos = new HashSet<Producto>();
        }

        public int Id { get; set; }
        public int ProductoId { get; set; } 
        public virtual ICollection<Producto> Productos { get; set; }    

        public virtual Producto Producto { get; set; }
        
    }
}
