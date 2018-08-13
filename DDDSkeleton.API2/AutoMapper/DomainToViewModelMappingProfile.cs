using AutoMapper;
using DDDSkeleton.API.ViewModels;
using DDDSkeleton.Domain.Entities;

namespace DDDSkeleton.API.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        protected void Configure()
        {
            CreateMap<ItemViewModel, Item>();
            CreateMap<ItemListViewModel, ItemList>();
        }
    }
}
