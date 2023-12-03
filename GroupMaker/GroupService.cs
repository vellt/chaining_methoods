using System;
using System.Collections.Generic;
using System.Linq;

namespace GroupMaker
{
    class GroupService
    {
        internal string[] students;
        internal List<Group> groupedStudents;

        public GroupService(string[] students)
        {
            this.students = students;
        }

        internal static GroupService MakeOf(string[] students)
        {
            ShuffleArray(students);
            GroupService group = new GroupService(students);
            return group;
        }

        internal GroupService In(int number)
        {
            groupedStudents = new List<Group>();
            for (int i = 0; i < students.Length; i++) 
            {
                if(!groupedStudents.SelectMany(x => x.Students).Select(x=>x.Id).ToList().Contains(i))
                {
                    var nameCountsByGroup = groupedStudents.Select(x => new
                    {
                        Group = x,
                        NameCount = x.Students.Count
                    }).ToList();
                    bool match = false;
                    foreach (var item in nameCountsByGroup)
                    {
                        if (item.NameCount != number)
                        {
                            item.Group.Students.Add(new Student(i, students[i]));
                            match = true;
                        }
                    }
                    if (!match)
                    {
                        groupedStudents.Add(new Group(groupedStudents.Count,new List<Student> { new Student(i, students[i]) }));
                    }
                    
                }
                
            }
            return this;
        }

        internal static void ShuffleArray(string[] array )
        {
            Random random = new Random();

            int n = array.Length;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                string value = array[k];
                array[k] = array[n];
                array[n] = value;
            }
        }

        internal void Print()
        {
            foreach (Group group in groupedStudents)
            {
                Console.WriteLine($"{group.Id+1}. Csapat:");
                foreach (Student student in group.Students)
                {
                    Console.WriteLine($"- {student.Name}");
                }
            }
        }
    }
}
