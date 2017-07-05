using System.Data.Entity.ModelConfiguration;
using ObrasFai.Domain.Entities.Execution;

namespace ObrasFai.Infra.Persistence.Mappings.Execution
{
    public class SupervisorMap : EntityTypeConfiguration<Supervisor>
    {
        public SupervisorMap()
        {
            ToTable("OB008FIS");
            HasKey(x => x.Id);
            Property(x => x.Id).HasColumnName("CODFIS").IsRequired();
            Property(x => x.Name).HasColumnName("NOMFIS").IsRequired().HasMaxLength(100);
            Property(x => x.Cpf).HasColumnName("CPFFIS").IsRequired();
            Property(x => x.Email).HasColumnName("EMAFIS").IsRequired().HasMaxLength(160);
            Property(x => x.Phone).HasColumnName("TELFIS").HasMaxLength(20);
            Property(x => x.PhoneTwo).HasColumnName("TELFI2").HasMaxLength(20);
            Property(x => x.TypeInspectionId).HasColumnName("CODTFI").IsRequired();
            Property(x => x.Status).HasColumnName("SITFIS").IsRequired().HasMaxLength(7);
            Property(x => x.CreaNumber).HasColumnName("NUMCRE").HasMaxLength(30);
            Property(x => x.DateOfGeneration).HasColumnName("DATGER").IsRequired();
            Property(x => x.UserIdRegistered).HasColumnName("USUGER").IsRequired();
        }
    }
}
