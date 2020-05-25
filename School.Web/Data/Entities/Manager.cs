namespace School.Web.Data.Entities
{
    public class Manager : IEntity
    {
        public int Id { get; set; }

        public User User { get; set; }
    }
}
