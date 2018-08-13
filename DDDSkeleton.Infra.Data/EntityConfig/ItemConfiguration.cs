using DDDSkeleton.Domain.Entities;
using System.Data.Entity.ModelConfiguration;

namespace DDDSkeleton.Infra.Data.EntityConfig
{
    public class ItemConfiguration : EntityTypeConfiguration<Item>
    {
        public ItemConfiguration()
        {
            HasKey(i => i.Id);

            Property(i => i.Name);
            Property(i => i.CreatedAt);
        }   
    }
}
