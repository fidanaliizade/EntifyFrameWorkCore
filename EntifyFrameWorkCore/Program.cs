using EntityFrameWorkCore.DAL;
using EntityFrameWorkCore.Models;
using EntityFrameWorkCore.Services;
using System.Net.Cache;

namespace EntifyFrameWorkCore
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            AppDbContext dbContext = new AppDbContext();
            StudentsService studentsService = new StudentsService();
            Student student = new Student()
            {
                Name = "Fidan",
                Age = 19
            };
            Student student2 = new Student()
            {
                Name = "Gultac",
                Age = 19
            };
            Student student3 = new Student()
            {
                Name = "Asmar",
                Age = 20
            };
            Student student4 = new Student()
            {
                Name = "Maryam",
                Age = 20
            };

            studentsService.Add(student);
            studentsService.Add(student2);
            studentsService.Add(student3);
            studentsService.Add(student4);



            //studentsService.Remove(4);
            //studentsService.Remove(3);




            //List<Student> students = new List<Student>();
            //foreach (Student student in dbContext.Students)
            //{
            //    Console.WriteLine($"Id:{student.Id}, Name:{student.Name}, Age:{student.Age}");
            //}



            //Student updatedStudent = new Student()
            //{
            //    Name = "Aysel"
            //};
            //studentsService.UpdateName(2, updatedStudent.Name);



            //Student updatedStudent = new Student()
            //{
            //    Age = 21
            //};
            //studentsService.UpdateAge(2, updatedStudent.Age);


            //GroupsService groupsService = new GroupsService();
            //Group group = new Group()
            //{
            //    Name = "BB205"
            //};
            //Group group2 = new Group()
            //{
            //    Name = "KE022S1"
            //};
            //Group group3 = new Group()
            //{
            //    Name = "TK94"
            //};
            //Group group4 = new Group()
            //{
            //    Name = "KE022S2 "
            //};
            //groupsService.AddToGroup(group);
            //groupsService.AddToGroup(group2);
            //groupsService.AddToGroup(group3);
            //groupsService.AddToGroup(group4);




            //groupsService.RemoveFromGoup(4);


            //List<Group> groups = new List<Group>();
            //foreach (Group item in dbContext.Groups)
            //Console.WriteLine($"Id:{item.Id}, Group name:{item.Name}");




            //Group updatedGroup = new Group()
            //{
            //    Name = "BB203"
            //};
            //groupsService.UpdateGroupName(1, updatedGroup.Name);

        }
    }
}