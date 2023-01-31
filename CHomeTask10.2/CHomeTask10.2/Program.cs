using System;

namespace CHomeTask10._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student.CheckNo();

            Student std1 = new Student();
            Student std2 = new Student();
            Student std3 = new Student();
            Student std4 = new Student();

            std1.Name = "Nuru";
            std2.Name = "Vuqar";
            std3.Name = "Elvin";
            std4.Name = "Samir";

            std1.GroupNo = "P231";
            std2.GroupNo = "P231";
            std3.GroupNo = "P231";
            std4.GroupNo = "P231";

            Console.WriteLine(std1.Name);
            Console.WriteLine(std4.No);
            Console.WriteLine(std1.GroupNo);
            Console.WriteLine(std1.CheckGroupNo("P231"));
        }
    }
}
