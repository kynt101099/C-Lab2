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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            
        }

        private void patientBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this.pharmacyDataSet.Patient);

        }

        private void btExitPatient_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to exit Patient report!", "Pharmacy Management System",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btClosePatient_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to exit Patient report!", "Pharmacy Management System",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void btSavePatient_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.patientBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyDataSet);
        }

        private void btPreviousPatient_Click(object sender, EventArgs e)
        {
            this.patientBindingSource.MovePrevious();
        }

        private void btNextPatient_Click(object sender, EventArgs e)
        {
            this.patientBindingSource.MoveNext();
        }

        private void btDeletePatient_Click(object sender, EventArgs e)
        {
            this.patientBindingSource.RemoveCurrent();
        }

        private void btAddPatient_Click(object sender, EventArgs e)
        {
            this.patientBindingSource.AddNew();
        }
    }
}
