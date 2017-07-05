using System.Data.Entity;
using ObrasFai.Domain.Entities.Administration;
using ObrasFai.Domain.Entities.Execution;
using ObrasFai.Domain.Entities.Support;
using ObrasFai.Infra.Persistence.Mappings.Administration;
using ObrasFai.Infra.Persistence.Mappings.Execution;
using ObrasFai.Infra.Persistence.Mappings.General;
using ObrasFai.Infra.Persistence.Mappings.Support;

namespace ObrasFai.Infra.Persistence.DataContexts
{
    public class ObrasFaiDataContext : DbContext
    {
        public ObrasFaiDataContext()
       : base("ObrasFaiConnectionString")
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }
        #region Administration
        public DbSet<Person> People { get; set; }
        public DbSet<User> Users { get; set; }
        #endregion
        #region Support
        public DbSet<Situation> Situations { get; set; }
        public DbSet<TypeOfConstruction> TypeOfConstructions { get; set; }
        public DbSet<TypeOfInspection> TypeOfInspections { get; set; }
        public DbSet<TypeOfBond> TypeOfBonds { get; set; }
        public DbSet<TypeOfContract> TypeOfContracts { get; set; }
        public DbSet<DocumentTypeConstruction> DocumentTypeConstructions { get; set; }
        public DbSet<NatureOfObservation> NatureOfObservations { get; set; }
        public DbSet<Campus> Campi { get; set; }
        #endregion
        #region Execution
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<ContractRate> ContractsRate { get; set; }
        public DbSet<Construction> Constructions { get; set; }
        public DbSet<Bidding> Biddings { get; set; }
        public DbSet<Bond> Bonds { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<Measurement> Measurements { get; set; }
        public DbSet<Supervisor> Supervisors { get; set; }
        public DbSet<SupervisorConstruction> SupervisorConstructions { get; set; }
        public DbSet<BiddingRate> BiddingsRate { get; set; }


        #endregion

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           modelBuilder.HasDefaultSchema("COMPRASTESTE");

            #region Administration
            modelBuilder.Configurations.Add(new PersonMap());
            modelBuilder.Configurations.Add(new UserMap());
            #endregion
            #region Support
            modelBuilder.Configurations.Add(new SituationMap());

            modelBuilder.Configurations.Add(new TypeOfBondMap());
            modelBuilder.Configurations.Add(new TypeOfConstructionMap());
            modelBuilder.Configurations.Add(new TypeOfInspectionMap());
            modelBuilder.Configurations.Add(new TypeOfContractMap());
            modelBuilder.Configurations.Add(new NatureOfObservationMap());
            modelBuilder.Configurations.Add(new DocumentTypeConstructionMap());
            #endregion
            #region Execution
            modelBuilder.Configurations.Add(new SupervisorMap());
            modelBuilder.Configurations.Add(new SupervisorConstructionMap());
            modelBuilder.Configurations.Add(new BondMap());
            modelBuilder.Configurations.Add(new ConstructionMap());
            modelBuilder.Configurations.Add(new ContractMap());
            modelBuilder.Configurations.Add(new BiddingMap());
            modelBuilder.Configurations.Add(new CommentsMap());
            modelBuilder.Configurations.Add(new DocumentMap());
            modelBuilder.Configurations.Add(new MeasurementMap());
            modelBuilder.Configurations.Add(new ContractRateMap());
            modelBuilder.Configurations.Add(new BiddingRateMap());
            #endregion

            modelBuilder.Configurations.Add(new CampMap());
        }
    }
}
