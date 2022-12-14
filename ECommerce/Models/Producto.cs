namespace ECommerce.Models
{
    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Costo { get; set; }
        public int Inventario { get; set; }

       // public virtual Carrito Carrito { get; set; }
    }
}
