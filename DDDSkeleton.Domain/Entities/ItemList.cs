using System;
using System.Collections.Generic;

namespace DDDSkeleton.Domain.Entities
{
    public class ItemList
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public DateTime CreatedAt { get; set; }

        public virtual IEnumerable<ItemList> Items { get; set; }
    }
}
