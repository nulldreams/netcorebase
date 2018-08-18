using CoreBase.Core.Domain;
using CoreBase.Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace CoreBase.Repositories.Repositories
{
    public class ValueRepository : Repository<Value>, IValueRepository
    {
        public ValueRepository(DbContext context) : base(context)
        {
        }

        public CoreBaseContext CoreBaseContext
        {
            get { return Context as CoreBaseContext; }
        }
    }
}
