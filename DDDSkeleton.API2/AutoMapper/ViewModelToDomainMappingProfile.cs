using AutoMapper;
using DDDSkeleton.API.ViewModels;
using DDDSkeleton.Domain.Entities;

namespace DDDSkeleton.API.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        protected void Config()
        {
            CreateMap<Item, ItemViewModel>();
            CreateMap<ItemList, ItemListViewModel>();
        }
    }
}
