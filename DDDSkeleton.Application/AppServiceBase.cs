using DDDSkeleton.Application.Interface;
using DDDSkeleton.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDDSkeleton.Application
{
    public class AppServiceBase<TEntity> : IDisposable, IAppServiceBase<TEntity> where TEntity : class
    {
        private readonly IServiceBase<TEntity> _serviceBase;
        private IItemService itemService;
        private IItemListService itemListService;

        public AppServiceBase(IItemService itemService)
        {
            this.itemService = itemService;
        }

        public AppServiceBase(IItemListService itemListService)
        {
            this.itemListService = itemListService;
        }

        public void Add(TEntity obj)
        {
            _serviceBase.Add(obj);
        }

        public void Dispose()
        {
            _serviceBase.Dispose();
        }

        public Task<IEnumerable<TEntity>> GetAll()
        {
            return _serviceBase.GetAll();
        }

        public TEntity GetById(Guid Id)
        {
            return _serviceBase.GetById(Id);
        }

        public void Remove(TEntity obj)
        {
            _serviceBase.Remove(obj);
        }

        public void Update(TEntity obj)
        {
            _serviceBase.Update(obj);
        }
    }
}
