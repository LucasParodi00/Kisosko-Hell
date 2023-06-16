namespace CapaEntidad
{
    public class DetalleVenta
    {

        public int IdDetalleVenta { get; set; }
        public Producto ObjProducto { get; set; }
        public decimal PrecioVenta { get; set; }
        public int Cantidad { get; set; }
        public decimal SubTotal { get; set; }
        public string FechaRegistro { get; set; }


    }
}
