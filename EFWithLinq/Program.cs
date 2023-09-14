using EFWithLinq.Entity;

namespace EFWithLinq
{
     class Program
    {
        //static void Main(string[] args)
        //{
        //    try
        //    {
        //        using var context = new EFCoreDbContext();
        //        var student = context.Students.Find(1);
        //        Console.WriteLine($"FirstName: {student?.FirstName}, LastName: {student?.LastName}");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"Error: {ex.Message}"); ;
        //    }
        //}
        //static void Main(string[] args)
        //{
        //    try
        //    {
        //        using var context = new EFCoreDbContext();
        //        //FirstOrDefault method using Method Syntax
        //        var student1 = context.Students.FirstOrDefault(s => s.FirstName == "Pranaya");
        //        Console.WriteLine($"FirstName: {student1?.FirstName}, LastName: {student1?.LastName}");

        //        //First method using Method Syntax
        //        var student2 = context.Students.First(s => s.FirstName == "Pranaya");
        //        Console.WriteLine($"FirstName: {student2?.FirstName}, LastName: {student2?.LastName}");
        //        //FirstOrDefault method using Query Syntax
        //        var student3 = (from s in context.Students
        //                        where s.FirstName == "Pranaya"
        //                        select s).FirstOrDefault();
        //        Console.WriteLine($"FirstName: {student3?.FirstName}, LastName: {student3?.LastName}");
        //        //First method using Query Syntax
        //        var student4 = (from s in context.Students
        //                        where s.FirstName == "Pranaya"
        //                        select s).First();
        //        Console.WriteLine($"FirstName: {student4?.FirstName}, LastName: {student4?.LastName}");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"Error: {ex.Message}"); ;
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    try
        //    {
        //        using var context = new EFCoreDbContext();
        //        //FirstOrDefault method using Method Syntax
        //        var student1 = context.Students.FirstOrDefault(s => s.FirstName == "Smith");
        //        Console.WriteLine($"FirstName: {student1?.FirstName}, LastName: {student1?.LastName}");

        //        //First method using Method Syntax
        //        var student2 = context.Students.First(s => s.FirstName == "Smith");
        //        Console.WriteLine($"FirstName: {student2?.FirstName}, LastName: {student2?.LastName}");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"Error: {ex.Message}"); ;
        //    }
        //}

        //param with linq
        //static void Main(string[] args)
        //{
        //    try
        //    {
        //        //Creating an Instance of Context class
        //        using var context = new EFCoreDbContext();
        //        //Creating a Variable
        //        string FirstName = "Pranaya";
        //        //Using the Variable
        //        var student = context.Students
        //                      .FirstOrDefault(s => s.FirstName == FirstName);
        //        Console.WriteLine($"FirstName: {student?.FirstName}, LastName: {student?.LastName}");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"Error: {ex.Message}"); ;
        //    }
        //}

        //to list
        //static void Main(string[] args)
        //{
        //    try
        //    {
        //        //Creating an Instance of Context class
        //        using var context = new EFCoreDbContext();
        //        //Fetching All the Students from Students table
        //        var studentList = context.Students.ToList();
        //        //Displaying all the Student information
        //        foreach (var student in studentList)
        //        {
        //            Console.WriteLine($"FirstName: {student?.FirstName}, LastName: {student?.LastName}");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"Error: {ex.Message}"); ;
        //    }
        //}

        //orderby
        //static void Main(string[] args)
        //{
        //    try
        //    {
        //        //Creating an Instance of Context class
        //        using var context = new EFCoreDbContext();
        //        //Order By using Query syntax
        //        var studentsQS = from s in context.Students
        //                         orderby s.FirstName ascending
        //                         select s;

        //        //Order By using Method syntax
        //        var studentsMS = context.Students.OrderBy(s => s.FirstName).ToList();
        //        //Displaying the Records
        //        foreach (var student in studentsQS)
        //        {
        //            Console.WriteLine($"\tFirstName: {student?.FirstName}, LastName: {student?.LastName}");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"Error: {ex.Message}"); ;
        //    }
        //}
        //anynom obj
        //static void Main(string[] args)
        //{
        //    try
        //    {
        //        //Creating an Instance of Context class
        //        using var context = new EFCoreDbContext();
        //        // Query Syntax to Project the Result to an Anonymous Type
        //        var selectQuery = (from std in context.Students
        //                           select new
        //                           {
        //                               firstName = std.FirstName,
        //                               lastName = std.LastName,
        //                               height = std.Height
        //                           });
        //        //Displaying the Record
        //        foreach (var student in selectQuery)
        //        {
        //            Console.WriteLine($"FirstName: {student?.firstName}, LastName: {student?.lastName}, Height: {student?.height}");
        //        }
        //        //Method Syntax to Project the Result to an Anonymous Type
        //        var selectMethod = context.Students.
        //                                      Select(std => new
        //                                      {
        //                                          firstName = std.FirstName,
        //                                          lastName = std.LastName,
        //                                          height = std.Height
        //                                      }).ToList();
        //        //Displaying the Record
        //        foreach (var student in selectMethod)
        //        {
        //            Console.WriteLine($"FirstName: {student?.firstName}, LastName: {student?.lastName}, Height: {student?.height}");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"Error: {ex.Message}"); ;
        //    }
        //}

        //join 

        //static void Main(string[] args)
        //{
        //    try
        //    {
        //        //Creating an Instance of Context class
        //        using var context = new EFCoreDbContext();
        //        //Join using Method Syntax
        //        var JoinUsingMS = context.Students //Outer Data Source
        //                    .Join(
        //                    context.Standards,  //Inner Data Source
        //                    student => student.Standard.StandardId, //Inner Key Selector
        //                    standard => standard.StandardId, //Outer Key selector
        //                    (student, standard) => new //Projecting the data into an anonymous type
        //                    {
        //                        StudentName = student.FirstName + " " + student.LastName,
        //                        StandrdId = standard.StandardId,
        //                        StandardDescriptin = standard.Description,
        //                        StudentHeight = student.Height
        //                    }).ToList();
        //        foreach (var student in JoinUsingMS)
        //        {
        //            Console.WriteLine($"Name: {student?.StudentName}, StandrdId: {student?.StandrdId}, Height: {student?.StudentHeight}");
        //        }
        //        //Join using Query Syntax
        //        var JoinUsingQS = (from student in context.Students
        //                           join standard in context.Standards
        //                           on student.Standard.StandardId equals standard.StandardId
        //                           select new
        //                           {
        //                               StudentName = student.FirstName + " " + student.LastName,
        //                               StandrdId = standard.StandardId,
        //                               StudentHeight = student.Height
        //                           }).ToList();
        //        foreach (var student in JoinUsingQS)
        //        {
        //            Console.WriteLine($"Name: {student?.StudentName}, StandrdId: {student?.StandrdId}, Height: {student?.StudentHeight}");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine($"Error: {ex.Message}"); ;
        //    }
        //}

        //c# Methods.
        static void Main(string[] args)
        {
            try
            {
                //Creating an Instance of Context class
                using var context = new EFCoreDbContext();
                var studentsWithSameName = context.Students
                                      .Where(s => s.FirstName == GetName())
                                      .ToList();
                foreach (var student in studentsWithSameName)
                {
                    Console.WriteLine($"FirstName: {student?.FirstName}, LastName: {student?.LastName}, StandardId: {student?.Standard?.StandardId}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}"); ;
            }
        }
        public static string GetName()
        {
            return "Pranaya";
        }
    }
}