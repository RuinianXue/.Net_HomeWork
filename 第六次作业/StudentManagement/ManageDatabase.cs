using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using static System.Data.Entity.Infrastructure.Design.Executor;
using System.Windows.Forms;

namespace StudentManagement
{
    class ManageDatabase
    {

        public string connectionString;

        public ManageDatabase()
        {
            connectionString = "Database=StudentManagement;Data Source=127.0.0.1;port=3306;User Id=root;;SslMode=none;Password=rrgglovexx37;";
        }

        public DataSet selectLog()
        {
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            databaseConnection.Open();
            string str = "select * from Log";
            MySqlCommand cmd = new MySqlCommand(str, databaseConnection);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataSet logDs = new DataSet();
            sda.Fill(logDs, "Log");
            return logDs;
        }
        public DataSet selectStudent()
        {
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            databaseConnection.Open(); 
            string str = "select * from Student";
            MySqlCommand cmd = new MySqlCommand(str, databaseConnection);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataSet studentDs = new DataSet(); 
            sda.Fill(studentDs, "Student"); 
            return studentDs;
        }
        public DataSet selectClass()
        {
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            databaseConnection.Open();
            string str = "select * from Class";
            MySqlCommand cmd = new MySqlCommand(str, databaseConnection);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataSet classDs = new DataSet();
            sda.Fill(classDs, "Class");
            return classDs;
        }
        public DataSet selectSchool()
        {
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            databaseConnection.Open();
            string str = "select * from School";
            MySqlCommand cmd = new MySqlCommand(str, databaseConnection);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataSet schoolDs = new DataSet();
            sda.Fill(schoolDs, "School");
            return schoolDs;
        }
        public void ChangeSchoolName(int schoolID, string newSchoolName)
        {
            string updateQuery = "UPDATE School SET SchoolName = @newSchoolName WHERE SchoolID = @schoolID";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@newSchoolName", newSchoolName);
                    command.Parameters.AddWithValue("@schoolID", schoolID);
                    command.ExecuteNonQuery();
                }
            }
            LogOperation("ChangeSchoolName", DateTime.Now.ToString());
        }
        public void ChangeStudent(int studentID, int newAge)
        {
            string updateQuery = "UPDATE Student SET Age = @newAge WHERE StudentID = @studentID";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@newAge", newAge);
                    command.Parameters.AddWithValue("@studentID", studentID);
                    command.ExecuteNonQuery();
                }
            }
            LogOperation("ChangeStudentAge", DateTime.Now.ToString());
        }
        public void ChangeClass(int classID, string newName)
        {
            string updateQuery = "UPDATE Class SET ClassName = @newName WHERE ClassID = @classID";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@newName", newName);
                    command.Parameters.AddWithValue("@classID", classID);
                    command.ExecuteNonQuery();
                }
            }
            LogOperation("ChangeClassName", DateTime.Now.ToString());
        }
        /*
        public void ChangeSchoolName(string schoolName, int schoolID)
        {
            string checkIdQuery = "SELECT COUNT(*) FROM School WHERE SchoolID = @schoolID";
            int count;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(checkIdQuery, connection))
                {
                    command.Parameters.AddWithValue("@schoolID", schoolID);
                    count = Convert.ToInt32(command.ExecuteScalar());
                }
            }
            if (count < 1)
            {
                MessageBox.Show("School ID doesn't exist.");
            }
            else
            {
                string query = "UPDATE School SET SchoolName = @schoolName WHERE SchoolID = @schoolID";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@schoolID", schoolID);
                        command.Parameters.AddWithValue("@schoolName", schoolName);
                        command.ExecuteNonQuery();
                    }
                }
                // 记录操作到日志
                LogOperation("ChangeSchoolName", DateTime.Now.ToString());
            }
        }*/
        public void DeleteSchool(int schoolID)
        {
            string checkIdQuery = "SELECT COUNT(*) FROM School WHERE SchoolID = @schoolID";
            int count;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(checkIdQuery, connection))
                {
                    command.Parameters.AddWithValue("@schoolID", schoolID);
                    count = Convert.ToInt32(command.ExecuteScalar());
                }
            }
            if (count == 0)
            {
                Console.WriteLine("SchoolID not exists.");
            }
            else
            {
                string query = "DELETE FROM Student WHERE ClassID IN(SELECT ClassID FROM Class WHERE SchoolID = @schoolID);DELETE FROM Class WHERE SchoolID = @schoolID;DELETE FROM School WHERE SchoolID = @schoolID;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@schoolID", schoolID);
                        command.ExecuteNonQuery();
                    }
                }
                // 记录操作到日志
                LogOperation("DeleteSchool", DateTime.Now.ToString());
            }
        }
        public void DeleteClass(int classID)
        {
            string checkIdQuery = "SELECT COUNT(*) FROM Class WHERE ClassID = @classID";
            int count;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(checkIdQuery, connection))
                {
                    command.Parameters.AddWithValue("@classID", classID);
                    count = Convert.ToInt32(command.ExecuteScalar());
                }
            }
            if (count == 0)
            {
                Console.WriteLine("ClassID not exists.");
            }
            else
            {
                string query = "DELETE FROM Student WHERE ClassID = @classID;DELETE FROM Class WHERE ClassID = @classID;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@classID", classID);
                        command.ExecuteNonQuery();
                    }
                }
                // 记录操作到日志
                LogOperation("DeleteClass", DateTime.Now.ToString());
            }
        }
        public void InsertSchool(int schoolID, string schoolName)
        {
            string checkIdQuery = "SELECT COUNT(*) FROM School WHERE SchoolID = @schoolID";
            int count;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(checkIdQuery, connection))
                {
                    command.Parameters.AddWithValue("@schoolID", schoolID);
                    count = Convert.ToInt32(command.ExecuteScalar());
                }
            }
            if (count > 0)
            {
                Console.WriteLine("School ID already exists.");
            }
            else
            {
                string query = "INSERT INTO School (SchoolID,SchoolName) VALUES (@schoolID,@schoolName)";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@schoolID", schoolID);
                        command.Parameters.AddWithValue("@schoolName", schoolName);
                        command.ExecuteNonQuery();
                    }
                }
                // 记录操作到日志
                LogOperation("InsertSchool", DateTime.Now.ToString());
            }
        }

        public void InsertClass(int classID, string className, int schoolID)
        {
            string checkIdQuery = "SELECT COUNT(*) FROM Class WHERE ClassID = @classID";
            int count;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(checkIdQuery, connection))
                {
                    command.Parameters.AddWithValue("@classID", classID);
                    count = Convert.ToInt32(command.ExecuteScalar());
                }
            }
            if (count > 0)
            {
                Console.WriteLine("ClassID already exists.");
            }
            else
            {
                string query = "INSERT INTO Class (ClassID, ClassName, SchoolID) VALUES (@classID, @className, @schoolID)";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@classID", classID);
                        command.Parameters.AddWithValue("@className", className);
                        command.Parameters.AddWithValue("@schoolID", schoolID);
                        command.ExecuteNonQuery();
                    }
                }
                // 记录操作到日志
                LogOperation("InsertClass", DateTime.Now.ToString());
            }
        }
        public DataTable selectClassBySchoolId(int schoolId)
        {
            string query = "SELECT * FROM Class WHERE SchoolId = @schoolId";
            DataTable classTable = new DataTable();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@schoolId", schoolId);
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        classTable.Load(reader);
                    }
                }
            }
            return classTable;
        }
        public DataTable selectStudentByClassId(int classID)
        {
            string query = "SELECT * FROM Student WHERE ClassId = @classID";
            DataTable classTable = new DataTable();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@classId", classID);
                    connection.Open();
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        classTable.Load(reader);
                    }
                }
            }
            return classTable;
        }
        
        public void InsertStudent(int studentID, string studentName, int age, int classID)
        {
            string checkIdQuery = "SELECT COUNT(*) FROM Student WHERE StudentID = @studentID";
            int count;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(checkIdQuery, connection))
                {
                    command.Parameters.AddWithValue("@studentID", studentID);
                    count = Convert.ToInt32(command.ExecuteScalar());
                }
            }
            if (count > 0)
            {
                Console.WriteLine("StudentID already exists.");
            }
            else
            {
                string query = "INSERT INTO Student (StudentID, StudentName, Age, ClassID) VALUES (@studentID, @studentName, @age, @classID)";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@studentID", studentID);
                        command.Parameters.AddWithValue("@studentName", studentName);
                        command.Parameters.AddWithValue("@age", age);
                        command.Parameters.AddWithValue("@classID", classID);
                        command.ExecuteNonQuery();
                    }
                }
                // 记录操作到日志
                LogOperation("InsertStudent", DateTime.Now.ToString());
            }
        }

        public void UpdateStudentAge(int studentID, int newAge)
        {
            string query = "UPDATE Student SET Age = @newAge WHERE StudentID = @studentID";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@newAge", newAge);
                    command.Parameters.AddWithValue("@studentID", studentID);
                    command.ExecuteNonQuery();
                }
            }
            // 记录操作到日志
            LogOperation("UpdateStudentAge", DateTime.Now.ToString());
        }

        public void DeleteStudent(int studentID)
        {
            string checkIdQuery = "SELECT COUNT(*) FROM Student WHERE StudentID = @studentID";
            int count;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(checkIdQuery, connection))
                {
                    command.Parameters.AddWithValue("@studentID", studentID);
                    count = Convert.ToInt32(command.ExecuteScalar());
                }
            }
            if (count == 0)
            {
                Console.WriteLine("StudentID is not exists.");
            }
            else
            {
                string query = "DELETE FROM Student WHERE StudentID = @studentID";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@studentID", studentID);
                        command.ExecuteNonQuery();
                    }
                }
                // 记录操作到日志
                LogOperation("DeleteStudent", DateTime.Now.ToString());
            }

        }

        public void RetrieveStudentsByClass(int classID)
        {
            string query = "SELECT * FROM Student WHERE ClassID = @classID";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@classID", classID);
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int studentID = reader.GetInt32(0);
                            string studentName = reader.GetString(1);
                            int age = reader.GetInt32(2);

                            Console.WriteLine($"Student ID: {studentID}");
                            Console.WriteLine($"Name: {studentName}");
                            Console.WriteLine($"Age: {age}");
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
        public void RetrieveAllSchools()
        {
            string query = "SELECT * FROM School";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int schoolID = reader.GetInt32(0);
                            string schoolName = reader.GetString(1);
                            Console.WriteLine($"School ID: {schoolID}");
                            Console.WriteLine($"Name: {schoolName}");
                            Console.WriteLine();
                        }
                    }
                }
            }
        }

        public void RetrieveAllClasses()
        {
            string query = "SELECT * FROM Class";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int classID = reader.GetInt32(0);
                            string className = reader.GetString(1);
                            int schoolID = reader.GetInt32(2);

                            Console.WriteLine($"Class ID: {classID}");
                            Console.WriteLine($"Name: {className}");
                            Console.WriteLine($"School ID: {schoolID}");
                            Console.WriteLine();
                        }
                    }
                }
            }
        }

        public void RetrieveAllStudents()
        {
            string query = "SELECT * FROM Student";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int studentID = reader.GetInt32(0);
                            string studentName = reader.GetString(1);
                            int age = reader.GetInt32(2);
                            int classID = reader.GetInt32(3);

                            Console.WriteLine($"Student ID: {studentID}");
                            Console.WriteLine($"Name: {studentName}");
                            Console.WriteLine($"Age: {age}");
                            Console.WriteLine($"Class ID: {classID}");
                            Console.WriteLine();
                        }
                    }
                }
            }
        }

        
        void LogOperation(string operation, string timestamp)
        {
            string logQuery = "INSERT INTO Log (Operation, TimeStamp) VALUES (@operation, @timestamp)";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(logQuery, connection))
                {
                    command.Parameters.AddWithValue("@operation", operation);
                    command.Parameters.AddWithValue("@timestamp", timestamp);
                    command.ExecuteNonQuery();
                }
            }
        }
        public void DisplayLogs()
        {
            string logQuery = "SELECT * FROM Log";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(logQuery, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int logID = reader.GetInt32(0);
                            string operation = reader.GetString(1);
                            string timestamp = reader.GetString(2);
                            Console.WriteLine($"Log ID: {logID}");
                            Console.WriteLine($"Operation: {operation}");
                            Console.WriteLine($"Timestamp: {timestamp}");
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
    }
}
