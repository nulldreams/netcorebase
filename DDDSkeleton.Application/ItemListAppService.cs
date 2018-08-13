using DDDSkeleton.Application.Interface;
using DDDSkeleton.Domain.Entities;
using DDDSkeleton.Domain.Interfaces.Services;

namespace DDDSkeleton.Application
{
    public class ItemListAppService : AppServiceBase<ItemList>, IItemListAppService
    {
        private readonly IItemListService _itemListService;

        public ItemListAppService(IItemListService itemListService)
            : base(itemListService)
        {
            _itemListService = itemListService;
        }
    }
}
