class Student
{
    private static int nextId = 1;

    public string Name;
    public int StudentId;
    public double GPA;
    public string Faculty;

    public Student(string name, double gpa, string faculty)
    {
        if (gpa < 0.0 || gpa > 4.0)
            throw new Exception("Invalid GPA");

        Name = name;
        GPA = gpa;
        Faculty = faculty;
        StudentId = nextId++;
    }

    public void Print()
    {
        Console.WriteLine("ID: " + StudentId +
                          ", Name: " + Name +
                          ", GPA: " + GPA +
                          ", Faculty: " + Faculty);
    }
}

class Registry
{
    private Student[] students = new Student[100];
    private int count = 0;

    public void Add(Student s)
    {
        if (count == 100)
        {
            Console.WriteLine("Registry full");
            return;
        }

        students[count] = s;
        count++;
    }

    public Student FindById(int id)
    {
        for (int i = 0; i < count; i++)
        {
            if (students[i].StudentId == id)
                return students[i];
        }
        return null;
    }

    public void FindByName(string name)
    {
        bool found = false;

        for (int i = 0; i < count; i++)
        {
            if (students[i].Name.ToLower() == name.ToLower())
            {
                students[i].Print();
                found = true;
            }
        }

        if (!found)
            Console.WriteLine("No students found");
    }

    public void GetTopStudents(int n)
    {
        if (n > count) n = count;

        for (int i = 0; i < count - 1; i++)
        {
            for (int j = 0; j < count - i - 1; j++)
            {
                if (students[j].GPA < students[j + 1].GPA)
                {
                    Student temp = students[j];
                    students[j] = students[j + 1];
                    students[j + 1] = temp;
                }
            }
        }

        for (int i = 0; i < n; i++)
        {
            students[i].Print();
        }
    }

    public void PrintAll()
    {
        if (count == 0)
        {
            Console.WriteLine("Empty");
            return;
        }

        for (int i = 0; i < count; i++)
        {
            students[i].Print();
        }
    }
}

class Program
{
    static void Main()
    {
        Registry reg = new Registry();

        while (true)
        {
            Console.WriteLine("\n1.Add 2.FindID 3.FindName 4.Top 5.All 6.Exit");
            string c = Console.ReadLine();

            if (c == "1")
            {
                try
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("GPA: ");
                    double gpa = double.Parse(Console.ReadLine());

                    Console.Write("Faculty: ");
                    string fac = Console.ReadLine();

                    reg.Add(new Student(name, gpa, fac));
                }
                catch
                {
                    Console.WriteLine("Error input");
                }
            }

            else if (c == "2")
            {
                Console.Write("ID: ");
                int id;

                if (int.TryParse(Console.ReadLine(), out id))
                {
                    Student s = reg.FindById(id);
                    if (s != null) s.Print();
                    else Console.WriteLine("Not found");
                }
                else
                {
                    Console.WriteLine("Wrong ID");
                }
            }

            else if (c == "3")
            {
                Console.Write("Name: ");
                reg.FindByName(Console.ReadLine());
            }

            else if (c == "4")
            {
                Console.Write("N: ");
                int n;

                if (int.TryParse(Console.ReadLine(), out n))
                    reg.GetTopStudents(n);
                else
                    Console.WriteLine("Wrong number");
            }

            else if (c == "5")
            {
                reg.PrintAll();
            }

            else if (c == "6")
            {
                break;
            }

            else
            {
                Console.WriteLine("Wrong choice");
            }
        }
    }
}