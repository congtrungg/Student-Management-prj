using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student
    {
        public string stu_name;
        public int stu_id;
        public string stu_course;
        public string stu_room;

        // constructor
        public Student(string name, int id, string course, string room)
        {
            this.stu_name = name;
            this.stu_id = id;
            this.stu_course = course;
            this.stu_room = room;
        }
        // setters
        public void setName(string name) { this.stu_name = name; }
        public void setRoll(int id) { this.stu_id = id; }
        public void setCourse(string course) { this.stu_course = course; }
        

        // getters
        public string getName()
        {
            return stu_name;
        }
        public int getRoll()
        {
            return stu_id;
        }
        public string getCourse()
        {
            return stu_course;
        }
        public string getStream()
        {
            return stu_room;
        }
    }
}
