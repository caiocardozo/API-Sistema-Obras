using System.Data.Entity.ModelConfiguration;
using ObrasFai.Domain.Entities.Administration;

namespace ObrasFai.Infra.Persistence.Mappings.Administration
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            ToTable("USUARIO");
            HasKey(x => x.Id);
            Property(x => x.Username).IsRequired().HasMaxLength(20);
            Property(x => x.Password).IsRequired().HasMaxLength(32).IsFixedLength();
            Property(x => x.Active);
        }
    }
}
