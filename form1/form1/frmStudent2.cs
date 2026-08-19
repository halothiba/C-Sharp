using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace form1
{
    public partial class frmStudent2 : Form
    {
        public frmStudent2()
        {
            InitializeComponent();
        }

        private void frmStudent2_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            String firstName = txtFname.Text;
            String lastName = txtLname.Text;
            DateTime date = date1.Value;
            String address = txtAdrs1.Text;
            String nic = txtNic1.Text;
            String gender = "";
            if(rdo1.Checked)
            {
                gender = "Male";
            }
            else if(rdo2.Checked)
            {
                gender = "Female";
            }
            String Telephone = txtTp1.Text;

            txtFname2.Text = firstName;
            txtLname2.Text = lastName;
            date2.Value = date;
            txtAdrs2.Text = address;
            txtNic2.Text = nic;
            txtTp2.Text = Telephone;
        }
    }
}
