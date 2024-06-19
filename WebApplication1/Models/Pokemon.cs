namespace WebApplication1.Models
{
    public class Pokemon
    {   //Model is just a class with a bunch of properties in it
        //but a model holds a very important role, because a model is your database tables (like excel spreadsheets)
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime BrithDate { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}
