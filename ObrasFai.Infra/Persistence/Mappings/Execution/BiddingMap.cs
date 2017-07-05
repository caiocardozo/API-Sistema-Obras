using System.Data.Entity.ModelConfiguration;
using ObrasFai.Domain.Entities.Execution;

namespace ObrasFai.Infra.Persistence.Mappings.Execution
{
    public class BiddingMap : EntityTypeConfiguration<Bidding>
    {
        public BiddingMap()
        {
            ToTable("OB101LIC");
            HasKey(x => x.Id);
            Property(x => x.Id).HasColumnName("CODLIC");
            Property(x => x.ConstructionId).HasColumnName("CODOBR").IsRequired();
            Property(x => x.BiddingShoppingPortalId).HasColumnName("CODPCO").IsRequired();
            Property(x => x.Amount).HasColumnName("VLRLIC").IsRequired();
            Property(x => x.ExecutionTime).HasColumnName("PRALIC").IsRequired();
            Property(x => x.DateOfGeneration).HasColumnName("DATGER").IsRequired();
            Property(x => x.UserIdRegistered).HasColumnName("USUGER").IsRequired();
            Property(x => x.LastUpdatedDate).HasColumnName("DATALT").IsRequired();
            Property(x => x.UserIdUpdated).HasColumnName("USUALT").IsRequired();

            HasRequired(x => x.Construction);

        }
    }
}
