using DDDSkeleton.Domain.Entities;
using DDDSkeleton.Domain.Interfaces;
using DDDSkeleton.Domain.Interfaces.Services;

namespace DDDSkeleton.Domain.Services
{
    public class ItemListService : ServiceBase<ItemList>, IItemListService
    {
        private readonly IItemListRepository _itemListRepository;

        public ItemListService(IItemListRepository repository) : base(repository)
        {
            _itemListRepository = repository;
        }
    }
}
