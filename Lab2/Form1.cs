using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Form2 doctor = new Form2();
            doctor.Show();
        }

        private void btGPAppiontment_Click(object sender, EventArgs e)
        {
            Form3 gpa = new Form3();
            gpa.Show();
        }

        private void btPatient_Click(object sender, EventArgs e)
        {
            Form4 patient = new Form4();
            patient.Show();
        }

        private void btPayment_Click(object sender, EventArgs e)
        {
            Form5 payment = new Form5();
            payment.Show();
        }

        private void btPharmary_Click(object sender, EventArgs e)
        {
            Form6 pharmary = new Form6();
            DialogResult iExit;
            iExit = MessageBox.Show("This function has not been developed yet please come back later", "Pharmacy Management System",
                MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to exit", "Pharmacy Management System",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "kyntce130282" && txtPassword.Text == "123456789")
            {
                btGPAppiontment.Enabled = true;
                btDoctor.Enabled = true;
                btPatient.Enabled = true;
                btPayment.Enabled = true;
                btPharmaryOffice.Enabled = true;
                btPharmary.Enabled = true;
                btConsultant.Enabled = true;
                btHelp.Enabled = true;
                btHospital.Enabled = true;
                btPharmacircleFirms.Enabled = true;
                btPharmacist.Enabled = true;
                btSpecialist.Enabled = true;
                btSurgery.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please enter the correct username and password!", "Pharmacy Management System");
                txtUsername.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btGPAppiontment.Enabled = false;
            btDoctor.Enabled = false;
            btPatient.Enabled = false;
            btPayment.Enabled = false;
            btPharmaryOffice.Enabled = false;
            btPharmary.Enabled = false;
            btConsultant.Enabled = false;
            btHelp.Enabled = false;
            btHospital.Enabled = false;
            btPharmacircleFirms.Enabled = false;
            btPharmacist.Enabled = false;
            btSpecialist.Enabled = false;
            btSurgery.Enabled = false;
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
            //enabled account
            btGPAppiontment.Enabled = false;
            btDoctor.Enabled = false;
            btPatient.Enabled = false;
            btPayment.Enabled = false;
            btPharmaryOffice.Enabled = false;
            btPharmary.Enabled = false;
            btConsultant.Enabled = false;
            btHelp.Enabled = false;
            btHospital.Enabled = false;
            btPharmacircleFirms.Enabled = false;
            btPharmacist.Enabled = false;
            btSpecialist.Enabled = false;
            btSurgery.Enabled = false;
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
            //enabled account
            btGPAppiontment.Enabled = false;
            btDoctor.Enabled = false;
            btPatient.Enabled = false;
            btPayment.Enabled = false;
            btPharmaryOffice.Enabled = false;
            btPharmary.Enabled = false;
            btConsultant.Enabled = false;
            btHelp.Enabled = false;
            btHospital.Enabled = false;
            btPharmacircleFirms.Enabled = false;
            btPharmacist.Enabled = false;
            btSpecialist.Enabled = false;
            btSurgery.Enabled = false;
        }

        private void lbTitle_Click(object sender, EventArgs e)
        {

        }

        private void btSurgery_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("This function has not been developed yet please come back later", "Pharmacy Management System",
                MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btHospital_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("This function has not been developed yet please come back later", "Pharmacy Management System",
                MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btSpecialist_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("This function has not been developed yet please come back later", "Pharmacy Management System",
                MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btConsultant_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("This function has not been developed yet please come back later", "Pharmacy Management System",
                MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btPharmacist_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("This function has not been developed yet please come back later", "Pharmacy Management System",
                MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btPharmacircleFirms_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("This function has not been developed yet please come back later", "Pharmacy Management System",
                MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btHelp_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("This function has not been developed yet please come back later", "Pharmacy Management System",
                MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btPharmaryOffice_Click(object sender, EventArgs e)
        {
            Pharmacy_Office pho = new Pharmacy_Office();
            pho.Show();
        }
    }
}
