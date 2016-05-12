using System.Collections.Generic;

namespace Rce.Domain.DataTransferObjects
{
    public class InvoiceDto 
    {
        public string Title { get; set; }
        public List<RentalDto> Rentals { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
