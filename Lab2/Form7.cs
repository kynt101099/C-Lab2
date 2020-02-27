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
    public partial class Pharmacy_Office : Form
    {
        public Pharmacy_Office()
        {
            InitializeComponent();
        }

        private void Pharmacy_Office_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet.Pharmacy_Office' table. You can move, or remove it, as needed.
            this.pharmacy_OfficeTableAdapter.Fill(this.pharmacyDataSet.Pharmacy_Office);

        }

        private void btExitPO_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to exit Pharmary Office!", "Pharmacy Management System",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btClosePO_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to exit Pharmary Office!", "Pharmacy Management System",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void btSavePO_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pharmacy_OfficeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyDataSet);
        }

        private void btPreviousPO_Click(object sender, EventArgs e)
        {
            this.pharmacy_OfficeBindingSource.MovePrevious();
        }

        private void btNextPO_Click(object sender, EventArgs e)
        {
            this.pharmacy_OfficeBindingSource.MoveNext();
        }

        private void btDeletePO_Click(object sender, EventArgs e)
        {
            this.pharmacy_OfficeBindingSource.RemoveCurrent();
        }

        private void btAddPO_Click(object sender, EventArgs e)
        {
            this.pharmacy_OfficeBindingSource.AddNew();
        }
    }
}
