using Microsoft.Practices.Unity;
using ObrasFai.ApplicationService.Administration;
using ObrasFai.ApplicationService.Execution;
using ObrasFai.ApplicationService.Support;
using ObrasFai.Domain.Repositories.Administration;
using ObrasFai.Domain.Repositories.Execution;
using ObrasFai.Domain.Repositories.Support;
using ObrasFai.Domain.Services.Administration;
using ObrasFai.Domain.Services.Execution;
using ObrasFai.Domain.Services.Support;
using ObrasFai.Infra.Persistence;
using ObrasFai.Infra.Persistence.DataContexts;
using ObrasFai.Infra.Repositories.Administration;
using ObrasFai.Infra.Repositories.Execution;
using ObrasFai.Infra.Repositories.Support;
using ObrasFai.Shared;
using ObrasFai.Shared.Events;

namespace ObrasFai.CrossCutting
{
    public static class DependencyRegister
    {
        public static void Register(UnityContainer container)
        {
            /// <summary>
            /// TransientLifetimeManager - Cada Resolve gera uma nova instância.
            /// ContainerControlledLifetimeManager - Utiliza Singleton
            /// </summary>
            /// <param name="container"></param>
            /// 

            container.RegisterType<ObrasFaiDataContext, ObrasFaiDataContext>(new HierarchicalLifetimeManager());
            container.RegisterType<IUnitOfWork, UnitOfWork>(new HierarchicalLifetimeManager());

            container.RegisterType<IUserRepository, UserRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IPersonRepository, PersonRepository>(new HierarchicalLifetimeManager());

            container.RegisterType<IConstructionRepository, ConstructionRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IContractRepository, ContractRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IBiddingRepository, BiddingRepository>(new HierarchicalLifetimeManager());

            container.RegisterType<ISupervisorRepository, SupervisorRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<ISupervisorConstructionRepository, SupervisorConstructionRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IBondRepository, BondRepository>(new HierarchicalLifetimeManager());

            container.RegisterType<ISituationRepository, SituationRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<ITypeOfBondRepository, TypeOfBondRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<ITypeOfConstructionRepository, TypeOfConstructionRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<ITypeOfInspectionRepository, TypeOfInspectionRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<ITypeOfContractRepository, TypeOfContractRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<INatureOfObservationRepository, NatureOfObservationRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IDocumentTypeConstructionRepository, DocumentTypeConstructionRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<ICampusRepository, CampusRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<ICommentRepository, CommentRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IBiddingRepository, BiddingRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IMeasurementRepository, MeasurementRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IDocumentRepository, DocumentRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IContractRepository, ContractRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IContractRateRepository, ContractRateRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IBiddingRateRepository, BiddingRateRepository>(new HierarchicalLifetimeManager());

            container.RegisterType<IUserApplicationService, UserApplicationService>(new HierarchicalLifetimeManager());
            container.RegisterType<IConstructionApplicationService, ConstructionApplicationService>(new HierarchicalLifetimeManager());
            container.RegisterType<ITypeOfBondApplicationService, TypeOfBondApplicationService>(new HierarchicalLifetimeManager());
            container.RegisterType<ITypeOfConstructionApplicationService, TypeOfConstructionApplicationService>(new HierarchicalLifetimeManager());
            container.RegisterType<ITypeOfInspectionApplicationService, TypeOfInspectionApplicationService>(new HierarchicalLifetimeManager());
            container.RegisterType<ITypeOfContractApplicationService, TypeOfContractApplicationService>(new HierarchicalLifetimeManager());
            container.RegisterType<INatureOfObservationApplicationService, NatureOfObservationApplicationService>(new HierarchicalLifetimeManager());
            container.RegisterType<IDocumentTypeConstructionApplicationService, DocumentTypeConstructionApplicationService>(new HierarchicalLifetimeManager());
            container.RegisterType<ICampusApplicationService, CampusApplicationService>(new HierarchicalLifetimeManager());

            container.RegisterType<ISupervisorApplicationService, SupervisorApplicationService>(new HierarchicalLifetimeManager());
            container.RegisterType<ISupervisorConstructionApplicationService, SupervisorConstructionApplicationService>(new HierarchicalLifetimeManager());
            container.RegisterType<IBondApplicationService, BondApplicationService>(new HierarchicalLifetimeManager());
            container.RegisterType<ICommentApplicationService, CommentApplicationService>(new HierarchicalLifetimeManager());
            container.RegisterType<IBiddingApplicationService, BiddingApplicationService>(new HierarchicalLifetimeManager());
            container.RegisterType<IMeasurementApplicationService, MeasurementApplicationService>(new HierarchicalLifetimeManager());
            container.RegisterType<IDocumentApplicationService, DocumentApplicationService>(new HierarchicalLifetimeManager());
            container.RegisterType<IContractApplicationService, ContractApplicationService>(new HierarchicalLifetimeManager());
            container.RegisterType<IContractRateApplicationService, ContractRateApplicationService>(new HierarchicalLifetimeManager());
            container.RegisterType<IBiddingRateApplicationService, BiddingRateApplicationService>(new HierarchicalLifetimeManager());

            container.RegisterType<ISituationApplicationService, SituationApplicationService>(new HierarchicalLifetimeManager());
            container.RegisterType<ITypeOfInspectionApplicationService, TypeOfInspectionApplicationService>(new HierarchicalLifetimeManager());

            container.RegisterType<IHandler<DomainNotification>, DomainNotificationHandler>(new HierarchicalLifetimeManager());


        }

        }
}
