using EntityFrameWorkCore.DAL;
using EntityFrameWorkCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkCore.Services
{
    internal class GroupsService
    {
        AppDbContext context = new AppDbContext();
        public void AddToGroup(Group group)
        {
            context.Groups.Add(group);
            context.SaveChanges();
        }

        public void RemoveFromGoup(int id)
        {
            var groupToRemove = context.Students.Find(id);
            if (groupToRemove != null)
            {
                context.Students.Remove(groupToRemove);
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Such group not found.");
            }
        }



        public List<Group> GetAllGroup()
        {
            return context.Groups.ToList();
        }


        public void UpdateGroupName(int id, string new_name)
        {
            var updatedGroup = context.Groups.Find(id);
            if (updatedGroup != null)
            {
                updatedGroup.Name = new_name;
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Such group not found.");
            }
        }

    }
}
