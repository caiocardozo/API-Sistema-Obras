using System;

namespace ObrasFai.Domain.Commands.Execution.Supervisor
{
    public class CreateSupervisorCommand
    {
        public CreateSupervisorCommand(
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
            CreaNumber = creaNumber;
            UserIdRegistered = userIdRegistered;
        }

        public string Name { get; private set; }
        public Int64 Cpf { get; private set; }
        public string Email { get; private set; }
        public string Phone { get; private set; }
        public string PhoneTwo { get; private set; }
        public Int16 TypeInspectionId { get; private set; }
        public int UserIdRegistered { get; set; }
        public string CreaNumber { get; set; }
    }
}
