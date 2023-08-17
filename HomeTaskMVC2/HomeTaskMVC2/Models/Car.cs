namespace HomeTaskMVC2.Models
{
    public class Car
    {
        public int Id { get; set; }
        public string CarName { get; set; }

        public int ModelId { get; set; }
        public Model Models { get; set; }
    }
}
