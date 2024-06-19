namespace WebApplication1.Models
{
    public class Country
    {
        public int Id { get; set; }//id is what's called a primary key in sql
        public string Name { get; set; }
        public ICollection<Owner> Owners { get; set; }

    }
}
