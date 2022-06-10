using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace contact_tracing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnSubmit.Enabled = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblNameGuide_Click(object sender, EventArgs e)
        {

        }

        private void lblEmailAddress_Click(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            StreamWriter A = new StreamWriter(Application.StartupPath + @"\MyContactTracingForm.txt", true);
            A.WriteLine("The following personal details below are automatically generated into this text file by BCN's Contact Tracing Form App. You may use this text file or copy its' contents for contact tracing purposes.");
            A.WriteLine("");
            A.WriteLine(lblFullName.Text + " " + txtBoxFullName.Text);
            A.WriteLine(lblSex.Text + " " + txtBoxSex.Text);
            A.WriteLine(lblAge.Text + " " + txtBoxAge.Text);
            A.WriteLine(lblAddress.Text + " " + txtBoxAddress.Text);
            A.WriteLine(lblEmail.Text + " " + txtBoxEmail.Text);
            A.WriteLine(lblContactNo.Text + " " + txtBoxContactNo.Text);
            A.WriteLine(lblSymptoms.Text + " " + txtBoxSymptoms.Text);
            A.WriteLine(lblVaccinated.Text + " " + txtBoxVaccinated.Text);
            A.WriteLine("");
            A.WriteLine("Thank you for using the contact tracing form application!");
            A.Close();

            msgboxSubmit m = new msgboxSubmit();
            m.Show();

        }

        private void lblSubmitButtonInfo_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxFullName_TextChanged(object sender, EventArgs e)
        {
            if (txtBoxFullName.Text != "" && txtBoxSex.Text != "" && txtBoxAge.Text != "" && txtBoxAddress.Text != "" && txtBoxContactNo.Text != "" && txtBoxEmail.Text != "" && txtBoxSymptoms.Text != "" && txtBoxVaccinated.Text != "")
            {
                btnSubmit.Enabled = true;
            }
        }
    }
}
