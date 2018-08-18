using CoreBase.Core.Repositories;
using System;

namespace CoreBase.Core
{
    public interface IUnitOfWork : IDisposable
    {
        IValueRepository Values { get; }
        int Complete();
    }
}
