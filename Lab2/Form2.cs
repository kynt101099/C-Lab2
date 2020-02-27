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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void doctorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.doctorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyDataSet);

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet.Doctor' table. You can move, or remove it, as needed.
            this.doctorTableAdapter.Fill(this.pharmacyDataSet.Doctor);

        }

        private void post_CodeLabel_Click(object sender, EventArgs e)
        {

        }

        private void email_AddressLabel_Click(object sender, EventArgs e)
        {

        }

        private void doctorDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
    
        }

        private void btExitDoctor_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to exit", "Pharmacy Management System",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btDeleteDoctor_Click(object sender, EventArgs e)
        {
            this.doctorBindingSource.RemoveCurrent();
        }

        private void btAddDoctor_Click(object sender, EventArgs e)
        {
            this.doctorBindingSource.AddNew();
        }

        private void btNextDoctor_Click(object sender, EventArgs e)
        {
            this.doctorBindingSource.MoveNext();
        }

        private void btPreviousDoctor_Click(object sender, EventArgs e)
        {
            this.doctorBindingSource.MovePrevious();
        }

        private void btSaveDoctor_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.doctorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyDataSet);
        }

        private void btCloseDoctor_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to exit doctor's report!", "Pharmacy Management System",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                this.Hide();
            }
        }
    }
}
