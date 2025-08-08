using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace WorkingWithMSQL
{
    internal class MySQLDatabase
    {
        private MySqlConnection conn;
        private MySqlCommand command;
        
        public MySQLDatabase()
        {
            conn = new MySqlConnection("server=localhost; uid=root; password=admin; database=student_db; port=3309");
            command = new MySqlCommand();
            command.Connection = conn;
            command.CommandType = CommandType.Text;
        }

        public StudentList all()
        {
           
            StudentList studentList = null;
            MySqlDataReader data_reader;
            string sql = "Select * from students";
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
              //  Console.WriteLine(studentList.count());
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
            MySqlDataReader data_reader;
            string sql = "Select * from students where idno='" + idno + "'";
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
           
            string sql = "insert into students values('";
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
            string sql = "DELETE FROM students where idno ='" + student.Idno + "'";
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
            string sql = "UPDATE students SET lastname ='";
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
