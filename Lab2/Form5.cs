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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void paymentBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.paymentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pharmacyDataSet.Payment' table. You can move, or remove it, as needed.
            this.paymentTableAdapter.Fill(this.pharmacyDataSet.Payment);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btExitGP_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to exit Payment!", "Pharmacy Management System",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btCloseGP_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to exit Payment!", "Pharmacy Management System",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void btSavePay_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.paymentBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pharmacyDataSet);
        }

        private void btPreviousPay_Click(object sender, EventArgs e)
        {
            this.paymentBindingSource.MovePrevious();
        }

        private void btNextPay_Click(object sender, EventArgs e)
        {
            this.paymentBindingSource.MoveNext();
        }

        private void btDeletePay_Click(object sender, EventArgs e)
        {
            this.paymentBindingSource.RemoveCurrent();
        }

        private void btAddPay_Click(object sender, EventArgs e)
        {
            this.paymentBindingSource.AddNew();
        }
    }
}
