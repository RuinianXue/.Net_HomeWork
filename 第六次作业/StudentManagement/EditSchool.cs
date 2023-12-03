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
    public partial class EditSchool : Form
    {
        bool status;
        string lst_id;
        public EditSchool()
        {
            InitializeComponent();
            lst_id = "";
            status = true;
        }
        public EditSchool(string id,string name)
        {
            InitializeComponent();
            status = true;
            textBoxSchoolName.Text = name;
            textBoxSchoolID.Text = id;
            lst_id = id;
            status = false;
        }
        public void textBoxSchoolID_TextChanged(object sender, EventArgs e)
        {
            if(status == false)
            {
                MessageBox.Show("You shouldn't change id!");
                textBoxSchoolID.Text = lst_id;
            }
        }
        public int txtSchoolID()
        {
            return int.Parse(textBoxSchoolID.Text);
        }
        public string txtSchoolName()
        {
            return textBoxSchoolName.Text;
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (textBoxSchoolID.Text == "" ||  textBoxSchoolName.Text == "")
            {
                MessageBox.Show("Please input valid args!");
            }
            else this.Close();
        }
    }
}
