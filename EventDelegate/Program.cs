using EventDelegate;

class Program
{
    static void Main(string[] args)
    {
        StudentModel[] students =
        {
            new StudentModel(100 , "Ram", 15 ,99),
            new StudentModel(121, "Arjun", 19, 89.8),
            new StudentModel(101, "Rahul", 15, 99.9),
            new StudentModel(102, "Riya", 16, 78.5)
        };
        Console.WriteLine("Before Sorting: ");
        PrintStudents(students);
        CustomSort.DelegateComparer<StudentModel> studentComparer = (x,y) => x.Score > y.Score;
        CustomSort.Sort<StudentModel>(students, studentComparer);
        Console.WriteLine("After Sorting: ");
        PrintStudents(students);
    }

    static void PrintStudents(StudentModel[] students)
    {
        foreach (var student in students)
        {
            Console.WriteLine($"STUDENT ID: {student.Id}\tNAME: {student.Name}\tAGE: {student.Age}\tSCORE: {student.Score}");
        }
    }

}