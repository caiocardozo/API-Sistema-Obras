namespace ObrasFai.Domain.Commands.Support.Situation
{
   public class CreateSituationCommand
    {
       public CreateSituationCommand(string description, int userIdRegistered)
       {
           Description = description;
           UserIdRegistered = userIdRegistered;
       }
        public string Description { get; set; }
        public int UserIdRegistered { get; set; }
    }
}
