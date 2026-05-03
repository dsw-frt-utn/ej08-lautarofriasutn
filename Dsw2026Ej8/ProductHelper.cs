namespace Dsw2026Ej8
{
    public partial class ProductHelper
    {
        public string ObtenerEtiquetaProducto(long code, string description, decimal price)
        {
            
            string precioFormateado = FormatearMoneda(price);
            return $"[{code}] {description} - {precioFormateado}";
        }
    }
}