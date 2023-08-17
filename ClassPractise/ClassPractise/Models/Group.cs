namespace ClassPractise.Models
{
    public class Group
    {
        public int Id { get; set; }

        public string GroupName { get; set; }

        public List<Student> Students { get; set;}
    }
}
