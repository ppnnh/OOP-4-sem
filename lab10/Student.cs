using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Lab10
{
    public class Student
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Secondname { get; set; }
        public int Age { get;set; }
        public string Specialization { get; set; }
        public int Course { get; set; }

        public string Image { get; set; }
        public override string ToString()
        {
            return ID + " " + Email + " " + Password + " " + Firstname + " " + Secondname + " " + Age + " " + Specialization + " " + Course + " " + Image; 
        }
    }
}
