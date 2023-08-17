namespace ClassPractise.Models
{
    public class Student
    {
        public int Id { get; set; } 

        public string StudentName { get; set; }

        public int  GroupId { get; set; }

        public Group Group { get; set; }

        public string Surname { get; set; }
    }
}

