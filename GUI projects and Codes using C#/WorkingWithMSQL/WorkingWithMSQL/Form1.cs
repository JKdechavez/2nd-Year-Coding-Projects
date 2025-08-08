using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.OleDb;

namespace WorkingWithMSQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            // Manipulation MySQL Database
          
            StudentList list;
            MySQLDatabase mysqldb = new MySQLDatabase();
          
            /*
            list = mysqldb.all();
            string result = "";
            for (int i = 0; i < list.count(); i++)
            {
                result += "[" + list.studentList[i].Idno + ", ";
                result +=  list.studentList[i].Lastname + ", ";
                result +=  list.studentList[i].Firstname + "]\n";

            }
            MessageBox.Show(result);
        */

          /*  
            Student student = new Student("666", "Cruz", "Danilo");
            mysqldb.insert(student);    
            */

            /*
            Student student = new Student("666", "Cruz", "Danilo");
            mysqldb.delete(student);
            */

            
            Student student = new Student("222", "Garcia", "Aladin");
            mysqldb.update(student);
            

            /*
            Student student;
            student = mysqldb.get_student("244");
            if (student != null)
            {
                string result = "[" + student.Idno + ", ";
                result +=  student.Lastname + ", ";
                result +=  student.Firstname + "]\n";
                MessageBox.Show(result);
            } 
            else
            {
                MessageBox.Show("not found");
            }
            */


            // Manipulationg MS ACCESS Database

            // System.Configuration.ConfigurationManager.ConnectionStrings["studentdbConnectionString"].ConnectionString);

            //OleDbConnection conn = new OleDbConnection(Properties.Settings.Default.studentdbConnectionString);


/*
           StudentList list;
           OleDbDatabase mysqldb = new OleDbDatabase();
         
            list = mysqldb.all();
            string result = "";
            for (int i = 0; i < list.count(); i++)
            {
                result += "[" + list.studentList[i].Idno + ", ";
                result +=  list.studentList[i].Lastname + ", ";
                result +=  list.studentList[i].Firstname + "]\n";

            }
            MessageBox.Show(result);
  */       
            /*
           Student student = new Student("444", "Cruz", "Danilo");
           mysqldb.insert(student);    
           */

            
         //   Student student = new Student("444", "Cruz", "Danilo");
           // mysqldb.delete(student);
            

            /*
            Student student = new Student("123", "Garcia", "Calvin");
            mysqldb.update(student);
            */

        }


    }
}
