using System.Collections.Generic;

namespace GroupMaker
{
    internal class Group
    {
        public int Id { get; set; }
        public List<Student> Students { get; set; }

        public Group(int id, List<Student> students)
        {
            Id = id;
            Students = students;
        }
    }

    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Student(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}