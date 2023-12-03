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
    public partial class EditClass : Form
    {
        bool status;
        string lst_id_cls,lst_id_sch;
        public EditClass(string id, string name,string schoolid)
        {
            InitializeComponent();
            status = true;
            textBoxClassName.Text = name;
            textBoxClassID.Text = id;
            textBoxClassSchool.Text = schoolid;
            lst_id_cls = id;
            lst_id_sch = schoolid;
            status = false;
        }
        public void textClassID_TextChanged(object sender, EventArgs e)
        {
            if (status == false)
            {
                MessageBox.Show("You shouldn't change id!");
                textBoxClassID.Text = lst_id_cls;
            }
        }
        public void textBoxClassSchoolID_TextChanged(object sender, EventArgs e)
        {
            if (status == false)
            {
                MessageBox.Show("You shouldn't change school id!");
                textBoxClassSchool.Text = lst_id_sch;
            }
        }
        public EditClass()
        {
            InitializeComponent();
            lst_id_cls = "";
            lst_id_sch = "";
            status = true;
        }
        public int txtClassID()
        {
            return int.Parse(textBoxClassID.Text);
        }
        public string txtClassName()
        {
            return textBoxClassName.Text;
        }
        public int txtClassSchool()
        {
            return int.Parse(textBoxClassSchool.Text);
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (textBoxClassID.Text == "" || textBoxClassName.Text == "" || textBoxClassSchool.Text == "")
            {
                MessageBox.Show("Please input valid args!");
            }
            else this.Close();
        }
    }
}
