namespace Dsw2026Ej8
{
    public class Product
    {
        public string Description { get; private set; }

        public Product(string description)
        {
            Description = description;
        }
        public void CambiarDescripcion(string nuevaDescripcion)
        {
            Description = nuevaDescripcion;
        }
    }

    public class Problema3
    {
        public string CompararCopias(int originalValue, Product product)
        {
            int valorCopia = originalValue;
            valorCopia++;
            Product copiaProduct = product;
            copiaProduct.CambiarDescripcion("Nueva Descripcion Asignada");
            return $"{originalValue}-{valorCopia}-{product.Description}";
        }
    }
}