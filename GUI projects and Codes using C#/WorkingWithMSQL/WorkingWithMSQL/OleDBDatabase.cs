using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace WorkingWithMSQL
{
    internal class OleDbDatabase
    {
        private OleDbConnection conn;
        private OleDbCommand command;
        private OleDbDataReader data_reader;


        public OleDbDatabase()
        {
               conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\studentdb.accdb");
                data_reader = null;
                command = new OleDbCommand();
                command.Connection = conn;
                command.CommandType = CommandType.Text;
            
            
        }

        public StudentList all()
        {
           
            StudentList studentList = null;
            
            string sql = "Select * from student";
            command.CommandText = sql;


            try
            {
                conn.Open();
                
                data_reader = command.ExecuteReader();
                if (data_reader != null)
                {
                    studentList = new StudentList();
                    while (data_reader.Read())
                    {
                        studentList.add_student(new Student(data_reader["idno"].ToString(), data_reader["lastname"].ToString(),  data_reader["firstname"].ToString()));
                    }
                }
                Console.WriteLine(studentList.count());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); 
            }
            finally
            {
                conn.Close();
            }
            return studentList;
        }

        public Student get_student(string idno)
        {

            Student student = null; 
            string sql = "Select * from student where idno='" + idno + "'";
            command.CommandText = sql;


            try
            {
                conn.Open();

                data_reader = command.ExecuteReader();
                if (data_reader.Read())
                {
                    
                   student = new Student(data_reader["idno"].ToString(), data_reader["lastname"].ToString(), data_reader["firstname"].ToString());
                    
                }

            }
            catch
            {
                Console.WriteLine("Error!");
            }
            finally
            {
                conn.Close();
            }
            return student;
        }


        public void insert(Student student)
        {
           
            string sql = "insert into student values('";
            sql += student.Idno + "','";
            sql += student.Lastname + "','";
            sql += student.Firstname + "')";
            command.CommandText = sql;

            try
            {
                conn.Open();
                command.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Error!");
            }
            finally
            {
                conn.Close();
            }
        }

        public void delete(Student student)
        {
            string sql = "DELETE FROM student where idno ='" + student.Idno + "'";
            command.CommandText = sql;

            try
            {
                conn.Open();
                command.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Error!");
            }
            finally
            {
                conn.Close();
            }
        }

        public void update(Student student)
        {
            string sql = "UPDATE student SET lastname ='";
            sql += student.Lastname + "', firstname ='";
            sql += student.Firstname + "' WHERE idno ='" + student.Idno + "'";
            command.CommandText = sql;

            try
            {
                conn.Open();
                command.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Error!");
            }
            finally
            {
                conn.Close();
            }
        }



    }
}
