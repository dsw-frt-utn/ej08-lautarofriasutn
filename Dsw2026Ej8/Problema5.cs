namespace Dsw2026Ej8
{
    public class Sale
    {
        public decimal Subtotal { get; set; }
        public virtual decimal CalculateTotal() 
        { 
            return Subtotal; 
        }
    }
    public class RetailSale : Sale
    {
        public override decimal CalculateTotal()
        {
            return Subtotal; 
        }
    }

    public class WholesaleSale : Sale
    {
        public override decimal CalculateTotal()
        { 
            return Subtotal * 0.90m; 
        }
    }

    public class Problema5
    {
        public decimal ObtenerImporteFinal(Sale sale)
        {

            return sale.CalculateTotal();
        }
    }
}