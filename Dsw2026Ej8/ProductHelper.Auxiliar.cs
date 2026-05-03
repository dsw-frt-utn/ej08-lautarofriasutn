namespace Dsw2026Ej8
{
    public partial class ProductHelper
    {
        private string FormatearMoneda(decimal price)
        {
            return price.ToString("C");
        }
    }
}