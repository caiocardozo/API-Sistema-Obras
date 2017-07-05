using System.Data.Entity.ModelConfiguration;
using ObrasFai.Domain.Entities.Execution;

namespace ObrasFai.Infra.Persistence.Mappings.Execution
{
    public class ConstructionMap : EntityTypeConfiguration<Construction>
    {
        public ConstructionMap()
        {
            ToTable("OB100OBR");
            HasKey(x => x.Id);
            Property(x => x.Id).HasColumnName("CODOBR");
            Property(x => x.Nickname).HasColumnName("APEOBR").HasMaxLength(20);
            Property(x => x.Description).HasColumnName("DESOBR").HasMaxLength(200).IsRequired();
            Property(x => x.Name).HasColumnName("NOMOBR").HasMaxLength(3000).IsRequired();
            Property(x => x.CampId).HasColumnName("CODCAM").IsRequired();
            Property(x => x.TypeOfConstructionId).HasColumnName("CODTIP").IsRequired();
            Property(x => x.SituationId).HasColumnName("CODSIT").IsRequired();
            Property(x => x.TypeInspectionId).HasColumnName("CODTFI").IsRequired();
            Property(x => x.StartDate).HasColumnName("DATINI");
            Property(x => x.EndDate).HasColumnName("DATENC");
            Property(x => x.ContractTerminationDate).HasColumnName("DATCON");
            Property(x => x.SignatureDate).HasColumnName("DATASS");
            Property(x => x.Area).HasColumnName("AREOBR");
            Property(x => x.EstimatedValue).HasColumnName("VLREST").IsRequired();
            Property(x => x.DateOfGeneration).HasColumnName("DATGER").IsRequired();
            Property(x => x.UserIdRegistered).HasColumnName("USUGER").IsRequired();
            Property(x => x.LastUpdatedDate).HasColumnName("DATALT").IsRequired();
            Property(x => x.UserIdUpdated).HasColumnName("USUALT").IsRequired();

            //HasRequired(x => x.Camp);
            HasRequired(x => x.Situation);  
            HasRequired(x => x.TypeInspection);
            HasRequired(x => x.TypeOfConstruction);
        }
    }
}
