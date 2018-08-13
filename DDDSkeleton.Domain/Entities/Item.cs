using System;

namespace DDDSkeleton.Domain.Entities
{
    public class Item
    {
        public Guid Id {
            get { return Id; }
            set { value = new Guid(); }
        }

        public string Name { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
