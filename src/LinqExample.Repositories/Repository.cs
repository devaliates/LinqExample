using System.Collections;

namespace LinqExample.Repositories;

public static class Repository
{
	public static IList<Student> studentList = new List<Student>() {
				new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
				new Student() { StudentID = 2, StudentName = "Moin", Age = 21 } ,
				new Student() { StudentID = 3, StudentName = "Bill", Age = 18 } ,
				new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
				new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
			};


	public static IList mixedList = new ArrayList()
	{
		0,
		"One",
		"Two",
		3,
		new Student() { StudentID = 1, StudentName = "Bill" },
	};
}
