using System;
using ObrasFai.Domain.Scopes.Execution;
using ObrasFai.Shared.Entities;

namespace ObrasFai.Domain.Entities.Execution
{
    public class Supervisor : EntityTwo
    {

        protected Supervisor() { }
        public Supervisor(
            string name,
            Int64 cpf,
            string email,
            string phone,
            string phoneTwo,
            Int16 typeInspectionId,
            string creaNumber,
            int userIdRegistered)
        {
            Name = name;
            Cpf = cpf;
            Email = email;
            Phone = phone;
            PhoneTwo = phoneTwo;
            TypeInspectionId = typeInspectionId;
            Status = "Ativo";
            CreaNumber = creaNumber;
            DateOfGeneration = DateTime.Now;
            UserIdRegistered = userIdRegistered;
        }

        public Int16 Id { get; private set; }
        public string Name { get; private set; }
        public Int64 Cpf { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public string PhoneTwo { get; private set; }
        public Int16 TypeInspectionId { get; private set; }
        public string CreaNumber { get; set; }


        public void Create()
        {
            if (!this.CreateSupervisorScopeIsValid())
                return;
        }

        public void Update(
            Int16 id,
            string name,
            Int64 cpf,
            string email,
            string phone,
            string phoneTwo,
            Int16 typeInspectionId,
            string status,
            string creaNumber)
        {
            if (!this.UpdateInfoScopeIsValid(
            id,
            name,
            cpf,
            email,
            phone,
            phoneTwo,
            typeInspectionId,
            status,
            creaNumber))
                return;

            Id = id;
            Name = name;
            Cpf = cpf;
            Email = email;
            Phone = phone;
            PhoneTwo = phoneTwo;
            TypeInspectionId = typeInspectionId;
            Status = status;

        }

        public void Inactive()
        {
            this.Status = "Inativo";
        }

        public void Active()
        {
            this.Status = "Ativo";
        }
    }
}
