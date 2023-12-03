using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class EditStudent : Form
    {
        bool status;
        string lst_id_cls, lst_name_stu,lst_id_stu;
        public EditStudent()
        {
            InitializeComponent();
            status  = true;
            lst_id_cls = lst_name_stu = lst_id_stu = "";
        }
        public EditStudent(string id, string name,string age, string clssid)
        {
            InitializeComponent();
            status = true;
            textBoxStudentAge.Text = age;
            lst_id_cls = textBoxStudentClass.Text = clssid;
            lst_id_stu = textBoxStudentID.Text = id;
            lst_name_stu = textBoxStudentName.Text = name;
            status = false;
        }
        public void textStudentID_TextChanged(object sender, EventArgs e)
        {
            if (status == false)
            {
                MessageBox.Show("You shouldn't change id!");
                textBoxStudentID.Text = lst_id_stu;
            }
        }
        public void textStudentName_TextChanged(object sender, EventArgs e)
        {
            if (status == false)
            {
                MessageBox.Show("You shouldn't change name!");
                textBoxStudentName.Text = lst_name_stu;
            }
        }
        public void textClassID_TextChanged(object sender, EventArgs e)
        {
            if (status == false)
            {
                MessageBox.Show("You shouldn't change class id!");
                textBoxStudentClass.Text = lst_id_cls;
            }
        }
        public int txtStudentID()
        {
            return int.Parse(textBoxStudentID.Text);
        }
        public string txtStudentName()
        {
            return textBoxStudentName.Text;
        }
        public int txtAge() {
            return int.Parse(textBoxStudentAge.Text);
        }
        public int txtStudentClassID()
        {
            return int.Parse(textBoxStudentClass.Text);
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (textBoxStudentID.Text == "" || textBoxStudentName.Text == "" || textBoxStudentAge.Text == "" || textBoxStudentClass.Text == "")
            {
                MessageBox.Show("Please input valid args!");
            }
            else this.Close();
        }
    }
}
