public class Teacher
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public List<Student> Students { get; set; }
    public List<Course> Courses { get; set; }
}

