using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
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

        private void label1_Click(object sender, EventArgs e)
        {
            string myname = txtName.Text;
        }

        private void rdoFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtGuardianName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
          INSERT INTO tblStudent(Name,Gender,DOB,Email,ContactNumber,GuardianName,GuardianEmail,GuardianContact,RelationWithGuardian,HscMarks,HscBoard,HscYearOfPassing,AcpcMeritRank,SscMarks,SscBoard,SscYearOfPassing) VALUES (txtName,rdoFemale_CheckedChanged,dateTimePicker1,txtEmail,txtContactNumber,txtGuardianName,txtGuardianEmail,txtGuardianContact,txtGuardianRelation,txtHscMarks,txtHscBoard,txtHscYof,txtAcpcMeritRank,txtSscMarks,txtSscBoard,txtHscYof);

        }
    }
}
