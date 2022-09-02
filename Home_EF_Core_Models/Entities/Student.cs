public class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public List<Teacher> Teachers { get; set; }
    public List<Course> Courses { get; set; }
}

