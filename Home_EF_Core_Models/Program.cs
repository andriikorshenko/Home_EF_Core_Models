using AppDbContext adc = new AppDbContext();

var tom = new Student { FirstName = "Tom", LastName = "Tompson" };
var lary = new Student { FirstName = "Lary", LastName = "Cayan" };

var jeison = new Teacher { FirstName = "Jeison", LastName = "Lorro" };
var marry = new Teacher { FirstName = "Marry", LastName = "Carla" };

var efc = new Course { Name = "Entity Framework Core" };
var sql = new Course { Name = "MS SQL" };

efc.Students = new List<Student>
{
	tom
};

efc.Teachers = new List<Teacher>
{
	jeison,
	marry
};

sql.Students = new List<Student>
{
    tom,
	lary
};

sql.Teachers = new List<Teacher>
{
    marry
};

adc.Add(efc);
adc.Add(sql);
adc.Add(tom);
adc.Add(lary);
adc.Add(jeison);
adc.Add(marry);

adc.SaveChanges();

var courses = adc.Courses.ToList();

foreach (var course in courses)
{
    Console.WriteLine($"\nCourse : \n" + course.Name
		+ "\n\nStudents : ");

	foreach (var student in course.Students)
	{
		Console.WriteLine(student.FirstName + " " + student.LastName);
	}

	Console.WriteLine("\nTeachers : ");

	foreach (var teacher in course.Teachers)
	{
		Console.WriteLine(teacher.FirstName + " " + teacher.LastName);
	}
}