namespace ObrasFai.Domain.Commands.Support.Situation
{
    public class UpdateStatusSituationCommand
    {
        public UpdateStatusSituationCommand(int id)
        {
            Id = id;
           }
        
        public int Id { get; set; }

    }

}
