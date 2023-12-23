using System.Collections;
using CollectionsPractice.Console;

public class Program
{
    #region Main
    public static void Main(string[] args)
    {
        // Real names for the students
        string[] studentFirstNames =
            [
                "Alice",
                "Bob",
                "Charlie",
                "David",
                "Emma",
                "Frank",
                "Grace",
                "Henry",
                "Isabel",
                "Jack",
                "Katie",
                "Liam",
                "Mia",
                "Nathan",
                "Olivia",
                "Paul",
                "Quinn",
                "Rachel",
                "Samuel",
                "Tara"
                ];

        // Real last names for the students
        string[] studentLastNames =
            [
                "Smith",
                "Johnson",
                "Williams",
                "Jones",
                "Brown",
                "Davis",
                "Miller",
                "Wilson",
                "Moore",
                "Taylor",
                "Anderson",
                "Thomas",
                "Jackson",
                "White",
                "Harris",
                "Martin",
                "Thompson",
                "Young",
                "Clark",
                "Walker"
                ];

        Student[] unsortedStudents = new Student[20];

        for (int i = 0; i < studentFirstNames.Length; i++)
        {
            var student = new Student
            {
                Id = studentFirstNames.Length - i,
                FirstName = studentFirstNames[i],
                LastName = studentLastNames[studentFirstNames.Length - i - 1]
            };

            unsortedStudents[i] = student;
        }

        // TODO Consolega unsortedStudents elementlarini chiqaring (use while loop)

        int k = 0;
        while (k<unsortedStudents.Length)
        {
            Console.WriteLine(unsortedStudents[k]);
            k++;
        }


        var sortedStudents = new SortedList<int, Student>();

        // TODO simpleStudentArray elementlarini birma-bir sortedStudentsga qo'shing

        foreach (var item in unsortedStudents)
        {
            sortedStudents.Add(item.Id, item);
            
        }



        // TODO Consolega unsortedStudents elementlarini chiqaring (use for each loop)

        foreach (var item in unsortedStudents)
        {
            Console.WriteLine($"{item.Id}-{item.FirstName} {item.LastName}");
            
        }

        var studentsQueueForFood = new Queue<Student>();
        // TODO studentsQueueForFood  queue ga  Id 3, 4, 8, 17, 1, 6, 12 studentlarni qo'shing (Enqueue).

        foreach (var id in new[] { 3, 4, 8, 17, 1, 6, 12 })
        {


            studentsQueueForFood.Enqueue(sortedStudents[id]);
        }


        // Har bir studentni ketma-ketlikda consolega chiqaring Masalan. Shu Idga ega bo'lgan ovqatga navbatga turdi


        foreach (var student in studentsQueueForFood)
        {
            Console.WriteLine($"{student.Id} {student.FirstName} {student.LastName}");
        }

        // TODO studentsQueueForFood  queue dan 4 ta studentni chiqaring.(Dequeue)

        for (int i = 0; i < 4; i++)
        {
           var student= studentsQueueForFood.Dequeue();

            Console.WriteLine($"{student.Id} {student.FirstName} {student.LastName}" );
        }

        // Har bir studentni ketma-ketlikda consolega chiqaring Masalan. Shu Idga ega bo'lgan student ovqatni oldi.

        foreach (var item in studentsQueueForFood)
        {
            Console.WriteLine($"{item.Id} {item.FirstName} {item.LastName}");
        }


        var studentsEnrolledMathCourse = new HashSet<Student>();

        // TODO 1, 3, 5, 6, 8, 18, 15, 13, 20 id li studentlarni matematika kursiga qo'shing.

        foreach (var id in new[] { 1, 3, 5, 6, 8, 18, 15, 13, 20 })
        {
            studentsEnrolledMathCourse.Add(sortedStudents[id]);
        }


        var studentsEnrolledEnglishCourse = new HashSet<Student>();
        // TODO 1, 2, 9, 6, 8, 7, 15, 13, 20 id li studentlarni ingliz tili kursiga qo'shing.

        foreach (var id in new[] { 1, 2, 9, 6, 8, 7, 15, 13, 20 })
        {
            studentsEnrolledEnglishCourse.Add(sortedStudents[id]);
        }


        // TODO matematika va ingliz tiliga bir vaqtda qatnashayotgan studentlarni consolega chiqaring (IntersectWith) 



        // TODO faqat matematikaga(ingliz tiliga emas) qatnashayotgan studentlarni consolega chiqaring (ExceptWith)

        var mathOnlyStudents = new HashSet<Student>(studentsEnrolledMathCourse);

        mathOnlyStudents.ExceptWith(studentsEnrolledEnglishCourse);

       
        foreach (var student in mathOnlyStudents)
        {
            System.Console.WriteLine(student);
        }



        // TODO faqat ingliz tiliga(matematikaga emas) qatnashayotgan studentlarni consolega chiqaring (ExceptWith)

        studentsEnrolledEnglishCourse.ExceptWith(mathOnlyStudents);


        foreach (var student in studentsEnrolledEnglishCourse)
        {
            System.Console.WriteLine(student);
        }


        // TODO istalgan kursga qatnashayotgan studentlarni consolega chiqaring. (UnionWith)


        // HashSetlar reference type. UnionWith, ExceptWith va IntersectWith chaqirilgan hashSetlarni o'zgartiradi.

        // studentlarni id isiga ko'ra jurnalda saqlang. ma'lumotlarni sorted Listdan olib keling.
        var classJournal = new Dictionary<int, Student>();
        // studentlarni jurnalini Consolega chiqaring.
    }
    #endregion
}