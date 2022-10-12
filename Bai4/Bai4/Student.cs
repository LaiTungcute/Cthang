using System;
using System.Collections.Generic;
using System.Text;

namespace Bai4
{
    class Student
    {
        private string id;
        private string name;
        private int mark;
        private int scholarship;

        public string Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public int Mark { get { return mark; } set { mark = value; } }
        public int Scholarship { get { return scholarship; } set { scholarship = (mark > 8 ? 500 : (mark >= 7 ? 300 : 0)); } }

        public Student ()
        {
            id = "1";
            name = "Tung";
            mark = 0;
            scholarship = 0;
        }

        public Student (string id)
        {
            this.id = id;
        }

        public Student (string id, string name, int mark)
        {
            this.id = id;
            this.name = name;
            this.mark = mark;
        }
    }
}
