using CoreBase.Core;
using CoreBase.Core.Repositories;
using CoreBase.Repositories.Repositories;

namespace CoreBase.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CoreBaseContext _context;

        public UnitOfWork(CoreBaseContext context)
        {
            _context = context;
            Values = new ValueRepository(_context);
        }

        public IValueRepository Values { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
