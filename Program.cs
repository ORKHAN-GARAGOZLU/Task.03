namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int abc;
        l1:
            Console.WriteLine("Number of students: ");
            if (!int.TryParse(Console.ReadLine(), out abc) || abc <= 0)
            {
                goto l1;
            }
            Students[] freshman = new Students[abc];
            for (int i = 0; i < freshman.Length; i++)
            {
                Students students = new Students();

                students.name = Volunteer.ReadString($"{i + 1}.Name: ");
                students.surname = Volunteer.ReadString($"{i + 1}.Surname: ");
                students.age = Volunteer.ReadInt($"{i + 1}.Age: ");
                students.speciality = Volunteer.ReadString($"{i + 1}.Specialty: ");
                students.groupNo = Volunteer.ReadInt($"{i + 1}.GroupNo: ");



                freshman[i] = students;
            }
            Console.WriteLine("======================");
            for (int i = 0; i < freshman.Length; i++)
            {
                Console.Write($"{i + 1}. ");
                Console.WriteLine(freshman[i]);
            }
        }
    }
}