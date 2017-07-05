using System;

namespace ObrasFai.Domain.Commands.Execution.Supervisor
{
    public class EditSupervisorCommand
    {
        public EditSupervisorCommand(
          Int16 id,
          string name,
          Int64 cpf,
          string email,
          string phone,
          string phoneTwo,
          Int16 typeInspectionId,
          string status,
          string creaNumber
           )
        {
            Id = id;
            Name = name;
            Cpf = cpf;
            Email = email;
            Phone = phone;
            PhoneTwo = phoneTwo;
            TypeInspectionId = typeInspectionId;
            Status = status;
            CreaNumber = creaNumber;
        }

        public Int16 Id { get; private set; }
        public string Name { get; private set; }
        public Int64 Cpf { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public string PhoneTwo { get; private set; }
        public Int16 TypeInspectionId { get; private set; }
        public string Status { get; set; }
        public string CreaNumber { get; set; }
    }
}
