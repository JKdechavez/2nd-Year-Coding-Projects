using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithMSQL
{
    class Student : Person
    {
        // fields and properties declartion

        private string idno {  get; set; }
       

               // constructor methods

        public Student() : base()
        {
            idno = "";
      
        }

        public Student(string idno, string lastname,  string firstname) : base(lastname, firstname)
        {
            this.idno = idno ;

        }

        public string Idno
        {
            get
            {
                return idno;
            }
            set
            {

                idno = value;
            }
        }





    }
}
