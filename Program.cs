using StaticInterface2.Model;

namespace StaticInterface2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Mud", "ev");
            Student student2 = new Student("aLi", "sHuKuRoV");
            Student student3 = new Student("emIL", "pashayEv");
            Console.WriteLine("Name: " + student1.Name);
            Console.WriteLine("Surname: " + student1.Surname);
            Console.WriteLine("Id: " + student1.Id);
            Console.WriteLine("Code Email: " + student1.CodeEmail);
            Console.WriteLine("Name: " + student2.Name);
            Console.WriteLine("Surname: " + student2.Surname);
            Console.WriteLine("Id: " + student2.Id);
            Console.WriteLine("Code Email: " + student2.CodeEmail);
            Console.WriteLine("Name: " + student3.Name);
            Console.WriteLine("Surname: " + student3.Surname);
            Console.WriteLine("Id: " + student3.Id);
            Console.WriteLine("Code Email: " + student3.CodeEmail);
        }
    }
}
