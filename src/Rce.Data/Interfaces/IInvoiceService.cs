using Rce.Domain.DataTransferObjects;

namespace Rce.Domain.Interfaces
{
    public interface IInvoiceService
    {
        InvoiceDto GetInvoice(int rentItemId);
    }
}