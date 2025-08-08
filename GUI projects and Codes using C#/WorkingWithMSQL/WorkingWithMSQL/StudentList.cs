using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithMSQL
{
    internal class StudentList
    {
        public List <Student> studentList;
        public int current_record_no { get; set; }

        public StudentList()
        {
            studentList = new List<Student>();
            current_record_no = 0;
        }

        public void add_student(Student student)
        {
            studentList.Add(student);
            current_record_no = studentList.Count - 1;
        }

        public void upate_student(Student student)
        {
            studentList[current_record_no].Lastname = student.Lastname;
            studentList[current_record_no].Firstname = student.Firstname;
            
        }

        public void delete_student(string idno)
        {
            for (int i = 0; i < studentList.Count; i++)
            {
                if (studentList[i].Idno == idno)
                {
                    studentList.RemoveAt(i);
                    current_record_no = 0;
                    break;
                }
            }



        }

      

        public Student get_current_student()
        {
            return studentList[current_record_no];
        }

        public int count()
        {
            return studentList.Count;
        }
        

    }
}
