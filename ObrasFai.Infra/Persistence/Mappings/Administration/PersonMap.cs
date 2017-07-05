using System.Data.Entity.ModelConfiguration;
using ObrasFai.Domain.Entities.Administration;

namespace ObrasFai.Infra.Persistence.Mappings.Administration
{
    public class PersonMap : EntityTypeConfiguration<Person>
    {
        public PersonMap()
        {
            ToTable("Person");
            HasKey(x => x.Id);
            Property(x => x.BirthDate);
            Property(x => x.Cpf.Number).IsRequired().HasMaxLength(11).IsFixedLength();
            Property(x => x.Email.Address).IsRequired().HasMaxLength(160);
            Property(x => x.Name).IsRequired().HasMaxLength(100);
            HasRequired(x => x.User);
        }
    }
}
