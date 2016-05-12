using System.Collections.Generic;
using Rce.Domain.Abstractions;
using Rce.Domain.Models;

namespace Rce.Domain.Services
{
    public class EquipmentItemRepository : IReadRepository<EquipmentItem, int>
    {
        private readonly IReadRepository<EquipmentItem, int> _equipmentItemRepository;

        public EquipmentItemRepository(IReadRepository<EquipmentItem, int> equipmentItemRepository)
        {
            _equipmentItemRepository = equipmentItemRepository;
        }

        public IEnumerable<EquipmentItem> List()
        {
            return _equipmentItemRepository.List();
        }

        public EquipmentItem GetById(int id)
        {
            return _equipmentItemRepository.GetById(id);
        }
    }
}
