using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Rce.Domain.Abstractions;
using Rce.Domain.DataTransferObjects;
using Rce.Domain.Interfaces;
using Rce.Domain.Models;

namespace Rce.Domain.Services
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IReadRepository<RentItem, int> _rentItemRepository;

        public InvoiceService(IReadRepository<RentItem, int> rentItemRepository)
        {
            _rentItemRepository = rentItemRepository;
        }

        public InvoiceDto GetInvoice(int rentItemId)
        {
            throw new NotImplementedException();
        }
    }
}
