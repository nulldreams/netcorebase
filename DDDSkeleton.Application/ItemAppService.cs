using DDDSkeleton.Application.Interface;
using DDDSkeleton.Domain.Entities;
using DDDSkeleton.Domain.Interfaces.Services;

namespace DDDSkeleton.Application
{
    public class ItemAppService : AppServiceBase<Item>, IItemAppService
    {
        private readonly IItemService _itemService;

        public ItemAppService(IItemService itemService)
            : base(itemService)
        {
            _itemService = itemService;
        }
    }
}
