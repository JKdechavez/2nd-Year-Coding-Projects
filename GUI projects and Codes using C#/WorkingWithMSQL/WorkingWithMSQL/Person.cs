using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithMSQL
{
    class Person
    {
        private string lastname { get; set; }
        private string firstname { get; set; }
     

        public Person()
        {
            lastname = "";
            firstname = "";
        }


        public Person(string lastname, string firstname)
        {
            this.lastname = lastname;
            this.firstname = firstname;
        }

        
        public string Lastname
        {
            get
            {
                return lastname;
            }
            set
            {

                    lastname = value;
            }
        }

        public string Firstname
        {
            get
            {
                return firstname;
            }
            set
            {

                firstname = value;
            }
        }

        public override string ToString()
        {
            return String.Format("Lastname : {0}\nFirstname : {1}", lastname, firstname);
        }

    }
}
