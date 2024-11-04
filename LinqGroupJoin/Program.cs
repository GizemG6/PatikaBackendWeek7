
// sample students
List<Students> Students = new List<Students>
{
    new Students { StudentId = 1, StudentName = "Ali", ClassId = 1},
    new Students { StudentId = 2, StudentName = "Ayşe", ClassId = 2},
    new Students { StudentId = 3, StudentName = "Mehmet", ClassId = 1},
    new Students { StudentId = 4, StudentName = "Fatma", ClassId = 3},
    new Students { StudentId = 5, StudentName = "Ahmet", ClassId = 2}
};


// sample classes
List<Classes> Classes = new List<Classes>
{
    new Classes { ClassId = 1, ClassName = "Matematik"},
    new Classes { ClassId = 2, ClassName = "Türkçe"},
    new Classes { ClassId = 3, ClassName = "Kimya"}
};

// group join query to group students by class
var classStudentQuery = from c in Classes
                        join s in Students on c.ClassId equals s.ClassId into studentGroup
                        select new
                        {
                            ClassName = c.ClassName,
                            Students = studentGroup.Select(s => s.StudentName)
                        };

// display results
foreach (var item in classStudentQuery)
{
    Console.WriteLine($"Sınıf: {item.ClassName}");
    Console.WriteLine("Öğrenciler: " + string.Join(", ", item.Students));
    Console.WriteLine();
}
