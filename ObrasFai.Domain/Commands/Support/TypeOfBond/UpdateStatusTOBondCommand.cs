namespace ObrasFai.Domain.Commands.Support.TypeOfBond
{
    public class UpdateStatusTOBondCommand
    {
        public UpdateStatusTOBondCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }

    }

}
