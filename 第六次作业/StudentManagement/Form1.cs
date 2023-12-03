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
using System.Data.SqlClient;
using System.IO;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Org.BouncyCastle.Asn1.X509;

namespace StudentManagement
{
    public partial class Form1 : Form
    {
        ManageDatabase manageDatabase;
        public Form1()
        {
            InitializeComponent();
            manageDatabase = new ManageDatabase();
            UpdateAll();
        }

        public void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void NewSchool_Click(object sender, EventArgs e)
        {
            EditSchool editSchool = new EditSchool();
            editSchool.ShowDialog();
            try
            {
                int id = editSchool.txtSchoolID();
                string name = editSchool.txtSchoolName();
                manageDatabase.InsertSchool(id, name);
                UpdateSchool();
            }
            catch (Exception ex)
            {
                MessageBox.Show("not valid input!");
            }

        }
        public void NewClass_Click(object sender, EventArgs e)
        {
            EditClass editClass = new EditClass();
            editClass.ShowDialog();
            try
            {
                int id = editClass.txtClassID();
                string name = editClass.txtClassName();
                int sch_id = editClass.txtClassSchool();
                manageDatabase.InsertClass(id, name, sch_id);
                UpdateClass();
            }
            catch (Exception ex)
            {
                MessageBox.Show("not valid input!");
            }

        }
        public void NewStudent_Click(object sender, EventArgs e)
        {
            EditStudent editStudent = new EditStudent();
            editStudent.ShowDialog();
            try
            {
                int id = editStudent.txtStudentID();
                string name = editStudent.txtStudentName();
                int cls_id = editStudent.txtStudentClassID();
                int age = editStudent.txtAge();
                manageDatabase.InsertStudent(id, name, age,cls_id);
                UpdateStudent();
            }
            catch (Exception ex)
            {
                MessageBox.Show("not valid input!");
            }

        }

        public void dbvSchool_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewSchool.Rows[e.RowIndex];
                string id = selectedRow.Cells["schoolId"].Value.ToString(); 
                string name = selectedRow.Cells["schoolName"].Value.ToString();
                EditSchool editSchool = new EditSchool(id,name);
                editSchool.ShowDialog();
                manageDatabase.ChangeSchoolName(int.Parse(id), editSchool.txtSchoolName());
                UpdateSchool();
            }
        }
        public void dbvClass_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewClass.Rows[e.RowIndex];
                string id = selectedRow.Cells["classId"].Value.ToString();
                string name = selectedRow.Cells["className"].Value.ToString();
                string schid = selectedRow.Cells["schoolID"].Value.ToString();
                
                EditClass editClass = new EditClass(id, name, schid);
                editClass.ShowDialog();
                manageDatabase.ChangeClass(int.Parse(id), editClass.txtClassName());
                UpdateClass();
            }
        }
        public void dbvStudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewStudent.Rows[e.RowIndex];
                string cls_id = selectedRow.Cells["ClassID"].Value.ToString();
                string stu_id = selectedRow.Cells["StudentID"].Value.ToString();
                string age = selectedRow.Cells["Age"].Value.ToString();
                string name = selectedRow.Cells["StudentName"].Value.ToString();
                EditStudent editStudent = new EditStudent(stu_id, name , age , cls_id);
                editStudent.ShowDialog();
                manageDatabase.ChangeStudent(int.Parse(stu_id), editStudent.txtAge());
                UpdateStudent();
            }
        }
        public void dataGridViewSchool_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewSchool.Rows[e.RowIndex];
                try
                {
                    int schoolId = Convert.ToInt32(selectedRow.Cells["schoolID"].Value); // Replace "SchoolIdColumn" with the actual column name for school ID
                    dataGridViewClass.DataSource = manageDatabase.selectClassBySchoolId(schoolId); // Replace with the method to retrieve classes by school ID
                                                                                                   //dataGridViewClass.DataMember = "Class";
                }
                catch { }
            }
        }
        public void dataGridViewClass_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewClass.Rows[e.RowIndex];
                try
                {
                    int classId = Convert.ToInt32(selectedRow.Cells["classID"].Value); // Replace "SchoolIdColumn" with the actual column name for school ID
                    dataGridViewStudent.DataSource = manageDatabase.selectStudentByClassId(classId); // Replace with the method to retrieve classes by school ID
                }
                catch { }
                //dataGridViewClass.DataMember = "Class";
            }
        }
        public void UpdateSchool()
        {
            dataGridViewSchool.DataSource = manageDatabase.selectSchool();
            dataGridViewSchool.DataMember = "School";
        }
        public void UpdateClass()
        {
            dataGridViewClass.DataSource = manageDatabase.selectClass();
            dataGridViewClass.DataMember = "Class";
        }
        public void UpdateStudent()
        {
            dataGridViewStudent.DataSource = manageDatabase.selectStudent();
            dataGridViewStudent.DataMember = "Student";
        }
        private void UpdateAll()
        {
            UpdateStudent();
            UpdateSchool();
            UpdateClass();
        }
        public void ReloadDatabase_Click(object sender, EventArgs e)
        {
            UpdateAll();
        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            ViewLog viewLog = new ViewLog();
            viewLog.Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        private void buttonDeleteSchool_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridViewSchool.CurrentRow;
            try
            {
                string id = selectedRow.Cells["schoolID"].Value.ToString();
                manageDatabase.DeleteSchool(int.Parse(id));
                UpdateAll();
            }catch
            {
                //int hhh = selectedRowIndex;
                MessageBox.Show("111");
            }
        }

        private void buttonDeleteClass_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridViewClass.CurrentRow;
            try
            {
                string id = selectedRow.Cells["classID"].Value.ToString();
                manageDatabase.DeleteClass(int.Parse(id));
                UpdateAll();
            }
            catch
            {
                //int hhh = selectedRowIndex;
                MessageBox.Show("111");
            }
        }

        private void buttonDeleteStudent_Click(object sender, EventArgs e)
        {
            DataGridViewRow selectedRow = dataGridViewStudent.CurrentRow;
            try
            {
                string id = selectedRow.Cells["StudentID"].Value.ToString();
                manageDatabase.DeleteStudent(int.Parse(id));
                UpdateAll();
            }
            catch
            {
                //int hhh = selectedRowIndex;
                MessageBox.Show("111");
            }
        }
    }
}
