namespace WebinarApiRest.Entities
{
    public class Sale: EntityBase
    {
        public Customer Customer { get; set; } = default!; //relacion con entidad Customer
        public int CustomerId { get; set; } // llave foranea
        public DateTime SaleDate { get; set; }
        public string SaleNumber { get; set; } = default!; 
        public decimal TotalSale { get; set; }

    }
}
