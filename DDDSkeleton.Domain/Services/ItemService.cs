using DDDSkeleton.Domain.Entities;
using DDDSkeleton.Domain.Interfaces;
using DDDSkeleton.Domain.Interfaces.Services;

namespace DDDSkeleton.Domain.Services
{
    public class ItemService : ServiceBase<Item>, IItemService
    {
        private readonly IItemRepository _itemRepository;

        public ItemService(IItemRepository repository) : base(repository)
        {
            _itemRepository = repository;
        }
    }
}
