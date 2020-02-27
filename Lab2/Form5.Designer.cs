namespace Lab2
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label invoice_NoLabel;
            System.Windows.Forms.Label amount_PaidLabel;
            System.Windows.Forms.Label method_of_PaymentLabel;
            System.Windows.Forms.Label visa_CardLabel;
            System.Windows.Forms.Label debit_CardLabel;
            System.Windows.Forms.Label master_CardLabel;
            System.Windows.Forms.Label credit_CardLabel;
            System.Windows.Forms.Label driect_DebitLabel;
            System.Windows.Forms.Label visa_Debit_CardLabel;
            System.Windows.Forms.Label cash_PaidLabel;
            System.Windows.Forms.Label patient_IDLabel;
            System.Windows.Forms.Label per_Paid_PlanLabel;
            System.Windows.Forms.Label patient_NHS_NumberLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.pharmacyDataSet = new Lab2.PharmacyDataSet();
            this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentTableAdapter = new Lab2.PharmacyDataSetTableAdapters.PaymentTableAdapter();
            this.tableAdapterManager = new Lab2.PharmacyDataSetTableAdapters.TableAdapterManager();
            this.paymentBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.paymentBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.invoice_NoTextBox = new System.Windows.Forms.TextBox();
            this.amount_PaidTextBox = new System.Windows.Forms.TextBox();
            this.method_of_PaymentTextBox = new System.Windows.Forms.TextBox();
            this.visa_CardTextBox = new System.Windows.Forms.TextBox();
            this.debit_CardTextBox = new System.Windows.Forms.TextBox();
            this.master_CardTextBox = new System.Windows.Forms.TextBox();
            this.credit_CardTextBox = new System.Windows.Forms.TextBox();
            this.driect_DebitTextBox = new System.Windows.Forms.TextBox();
            this.visa_Debit_CardTextBox = new System.Windows.Forms.TextBox();
            this.cash_PaidTextBox = new System.Windows.Forms.TextBox();
            this.patient_IDTextBox = new System.Windows.Forms.TextBox();
            this.per_Paid_PlanCheckBox = new System.Windows.Forms.CheckBox();
            this.patient_NHS_NumberTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btExitPay = new System.Windows.Forms.Button();
            this.btClosePay = new System.Windows.Forms.Button();
            this.btSavePay = new System.Windows.Forms.Button();
            this.btPreviousPay = new System.Windows.Forms.Button();
            this.btNextPay = new System.Windows.Forms.Button();
            this.btDeletePay = new System.Windows.Forms.Button();
            this.btAddPay = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            invoice_NoLabel = new System.Windows.Forms.Label();
            amount_PaidLabel = new System.Windows.Forms.Label();
            method_of_PaymentLabel = new System.Windows.Forms.Label();
            visa_CardLabel = new System.Windows.Forms.Label();
            debit_CardLabel = new System.Windows.Forms.Label();
            master_CardLabel = new System.Windows.Forms.Label();
            credit_CardLabel = new System.Windows.Forms.Label();
            driect_DebitLabel = new System.Windows.Forms.Label();
            visa_Debit_CardLabel = new System.Windows.Forms.Label();
            cash_PaidLabel = new System.Windows.Forms.Label();
            patient_IDLabel = new System.Windows.Forms.Label();
            per_Paid_PlanLabel = new System.Windows.Forms.Label();
            patient_NHS_NumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingNavigator)).BeginInit();
            this.paymentBindingNavigator.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // invoice_NoLabel
            // 
            invoice_NoLabel.AutoSize = true;
            invoice_NoLabel.Location = new System.Drawing.Point(45, 50);
            invoice_NoLabel.Name = "invoice_NoLabel";
            invoice_NoLabel.Size = new System.Drawing.Size(78, 17);
            invoice_NoLabel.TabIndex = 1;
            invoice_NoLabel.Text = "Invoice No:";
            // 
            // amount_PaidLabel
            // 
            amount_PaidLabel.AutoSize = true;
            amount_PaidLabel.Location = new System.Drawing.Point(45, 78);
            amount_PaidLabel.Name = "amount_PaidLabel";
            amount_PaidLabel.Size = new System.Drawing.Size(92, 17);
            amount_PaidLabel.TabIndex = 3;
            amount_PaidLabel.Text = "Amount Paid:";
            // 
            // method_of_PaymentLabel
            // 
            method_of_PaymentLabel.AutoSize = true;
            method_of_PaymentLabel.Location = new System.Drawing.Point(45, 106);
            method_of_PaymentLabel.Name = "method_of_PaymentLabel";
            method_of_PaymentLabel.Size = new System.Drawing.Size(134, 17);
            method_of_PaymentLabel.TabIndex = 5;
            method_of_PaymentLabel.Text = "Method of Payment:";
            // 
            // visa_CardLabel
            // 
            visa_CardLabel.AutoSize = true;
            visa_CardLabel.Location = new System.Drawing.Point(45, 134);
            visa_CardLabel.Name = "visa_CardLabel";
            visa_CardLabel.Size = new System.Drawing.Size(73, 17);
            visa_CardLabel.TabIndex = 7;
            visa_CardLabel.Text = "Visa Card:";
            // 
            // debit_CardLabel
            // 
            debit_CardLabel.AutoSize = true;
            debit_CardLabel.Location = new System.Drawing.Point(45, 162);
            debit_CardLabel.Name = "debit_CardLabel";
            debit_CardLabel.Size = new System.Drawing.Size(79, 17);
            debit_CardLabel.TabIndex = 9;
            debit_CardLabel.Text = "Debit Card:";
            // 
            // master_CardLabel
            // 
            master_CardLabel.AutoSize = true;
            master_CardLabel.Location = new System.Drawing.Point(45, 190);
            master_CardLabel.Name = "master_CardLabel";
            master_CardLabel.Size = new System.Drawing.Size(89, 17);
            master_CardLabel.TabIndex = 11;
            master_CardLabel.Text = "Master Card:";
            // 
            // credit_CardLabel
            // 
            credit_CardLabel.AutoSize = true;
            credit_CardLabel.Location = new System.Drawing.Point(427, 47);
            credit_CardLabel.Name = "credit_CardLabel";
            credit_CardLabel.Size = new System.Drawing.Size(83, 17);
            credit_CardLabel.TabIndex = 13;
            credit_CardLabel.Text = "Credit Card:";
            // 
            // driect_DebitLabel
            // 
            driect_DebitLabel.AutoSize = true;
            driect_DebitLabel.Location = new System.Drawing.Point(427, 75);
            driect_DebitLabel.Name = "driect_DebitLabel";
            driect_DebitLabel.Size = new System.Drawing.Size(86, 17);
            driect_DebitLabel.TabIndex = 15;
            driect_DebitLabel.Text = "Driect Debit:";
            // 
            // visa_Debit_CardLabel
            // 
            visa_Debit_CardLabel.AutoSize = true;
            visa_Debit_CardLabel.Location = new System.Drawing.Point(427, 103);
            visa_Debit_CardLabel.Name = "visa_Debit_CardLabel";
            visa_Debit_CardLabel.Size = new System.Drawing.Size(110, 17);
            visa_Debit_CardLabel.TabIndex = 17;
            visa_Debit_CardLabel.Text = "Visa Debit Card:";
            // 
            // cash_PaidLabel
            // 
            cash_PaidLabel.AutoSize = true;
            cash_PaidLabel.Location = new System.Drawing.Point(427, 131);
            cash_PaidLabel.Name = "cash_PaidLabel";
            cash_PaidLabel.Size = new System.Drawing.Size(76, 17);
            cash_PaidLabel.TabIndex = 19;
            cash_PaidLabel.Text = "Cash Paid:";
            // 
            // patient_IDLabel
            // 
            patient_IDLabel.AutoSize = true;
            patient_IDLabel.Location = new System.Drawing.Point(427, 159);
            patient_IDLabel.Name = "patient_IDLabel";
            patient_IDLabel.Size = new System.Drawing.Size(73, 17);
            patient_IDLabel.TabIndex = 21;
            patient_IDLabel.Text = "Patient ID:";
            // 
            // per_Paid_PlanLabel
            // 
            per_Paid_PlanLabel.AutoSize = true;
            per_Paid_PlanLabel.Location = new System.Drawing.Point(427, 189);
            per_Paid_PlanLabel.Name = "per_Paid_PlanLabel";
            per_Paid_PlanLabel.Size = new System.Drawing.Size(98, 17);
            per_Paid_PlanLabel.TabIndex = 23;
            per_Paid_PlanLabel.Text = "Per Paid Plan:";
            // 
            // patient_NHS_NumberLabel
            // 
            patient_NHS_NumberLabel.AutoSize = true;
            patient_NHS_NumberLabel.Location = new System.Drawing.Point(427, 217);
            patient_NHS_NumberLabel.Name = "patient_NHS_NumberLabel";
            patient_NHS_NumberLabel.Size = new System.Drawing.Size(143, 17);
            patient_NHS_NumberLabel.TabIndex = 25;
            patient_NHS_NumberLabel.Text = "Patient NHS Number:";
            // 
            // pharmacyDataSet
            // 
            this.pharmacyDataSet.DataSetName = "PharmacyDataSet";
            this.pharmacyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentBindingSource
            // 
            this.paymentBindingSource.DataMember = "Payment";
            this.paymentBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // paymentTableAdapter
            // 
            this.paymentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DoctorTableAdapter = null;
            this.tableAdapterManager.GP_AppointmentTableAdapter = null;
            this.tableAdapterManager.PatientTableAdapter = null;
            this.tableAdapterManager.PaymentTableAdapter = this.paymentTableAdapter;
            this.tableAdapterManager.PharmacyTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Lab2.PharmacyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // paymentBindingNavigator
            // 
            this.paymentBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.paymentBindingNavigator.BindingSource = this.paymentBindingSource;
            this.paymentBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.paymentBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.paymentBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.paymentBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.paymentBindingNavigatorSaveItem});
            this.paymentBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.paymentBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.paymentBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.paymentBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.paymentBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.paymentBindingNavigator.Name = "paymentBindingNavigator";
            this.paymentBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.paymentBindingNavigator.Size = new System.Drawing.Size(810, 27);
            this.paymentBindingNavigator.TabIndex = 0;
            this.paymentBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // paymentBindingNavigatorSaveItem
            // 
            this.paymentBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.paymentBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("paymentBindingNavigatorSaveItem.Image")));
            this.paymentBindingNavigatorSaveItem.Name = "paymentBindingNavigatorSaveItem";
            this.paymentBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.paymentBindingNavigatorSaveItem.Text = "Save Data";
            this.paymentBindingNavigatorSaveItem.Click += new System.EventHandler(this.paymentBindingNavigatorSaveItem_Click);
            // 
            // invoice_NoTextBox
            // 
            this.invoice_NoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentBindingSource, "Invoice No", true));
            this.invoice_NoTextBox.Location = new System.Drawing.Point(194, 47);
            this.invoice_NoTextBox.Name = "invoice_NoTextBox";
            this.invoice_NoTextBox.Size = new System.Drawing.Size(193, 22);
            this.invoice_NoTextBox.TabIndex = 2;
            // 
            // amount_PaidTextBox
            // 
            this.amount_PaidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentBindingSource, "Amount Paid", true));
            this.amount_PaidTextBox.Location = new System.Drawing.Point(194, 75);
            this.amount_PaidTextBox.Name = "amount_PaidTextBox";
            this.amount_PaidTextBox.Size = new System.Drawing.Size(193, 22);
            this.amount_PaidTextBox.TabIndex = 4;
            // 
            // method_of_PaymentTextBox
            // 
            this.method_of_PaymentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentBindingSource, "Method of Payment", true));
            this.method_of_PaymentTextBox.Location = new System.Drawing.Point(194, 103);
            this.method_of_PaymentTextBox.Name = "method_of_PaymentTextBox";
            this.method_of_PaymentTextBox.Size = new System.Drawing.Size(193, 22);
            this.method_of_PaymentTextBox.TabIndex = 6;
            // 
            // visa_CardTextBox
            // 
            this.visa_CardTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentBindingSource, "Visa Card", true));
            this.visa_CardTextBox.Location = new System.Drawing.Point(194, 131);
            this.visa_CardTextBox.Name = "visa_CardTextBox";
            this.visa_CardTextBox.Size = new System.Drawing.Size(193, 22);
            this.visa_CardTextBox.TabIndex = 8;
            // 
            // debit_CardTextBox
            // 
            this.debit_CardTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentBindingSource, "Debit Card", true));
            this.debit_CardTextBox.Location = new System.Drawing.Point(194, 159);
            this.debit_CardTextBox.Name = "debit_CardTextBox";
            this.debit_CardTextBox.Size = new System.Drawing.Size(193, 22);
            this.debit_CardTextBox.TabIndex = 10;
            // 
            // master_CardTextBox
            // 
            this.master_CardTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentBindingSource, "Master Card", true));
            this.master_CardTextBox.Location = new System.Drawing.Point(194, 187);
            this.master_CardTextBox.Name = "master_CardTextBox";
            this.master_CardTextBox.Size = new System.Drawing.Size(193, 22);
            this.master_CardTextBox.TabIndex = 12;
            // 
            // credit_CardTextBox
            // 
            this.credit_CardTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentBindingSource, "Credit Card", true));
            this.credit_CardTextBox.Location = new System.Drawing.Point(576, 44);
            this.credit_CardTextBox.Name = "credit_CardTextBox";
            this.credit_CardTextBox.Size = new System.Drawing.Size(193, 22);
            this.credit_CardTextBox.TabIndex = 14;
            // 
            // driect_DebitTextBox
            // 
            this.driect_DebitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentBindingSource, "Driect Debit", true));
            this.driect_DebitTextBox.Location = new System.Drawing.Point(576, 72);
            this.driect_DebitTextBox.Name = "driect_DebitTextBox";
            this.driect_DebitTextBox.Size = new System.Drawing.Size(193, 22);
            this.driect_DebitTextBox.TabIndex = 16;
            // 
            // visa_Debit_CardTextBox
            // 
            this.visa_Debit_CardTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentBindingSource, "Visa Debit Card", true));
            this.visa_Debit_CardTextBox.Location = new System.Drawing.Point(576, 100);
            this.visa_Debit_CardTextBox.Name = "visa_Debit_CardTextBox";
            this.visa_Debit_CardTextBox.Size = new System.Drawing.Size(193, 22);
            this.visa_Debit_CardTextBox.TabIndex = 18;
            // 
            // cash_PaidTextBox
            // 
            this.cash_PaidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentBindingSource, "Cash Paid", true));
            this.cash_PaidTextBox.Location = new System.Drawing.Point(576, 128);
            this.cash_PaidTextBox.Name = "cash_PaidTextBox";
            this.cash_PaidTextBox.Size = new System.Drawing.Size(193, 22);
            this.cash_PaidTextBox.TabIndex = 20;
            // 
            // patient_IDTextBox
            // 
            this.patient_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentBindingSource, "Patient ID", true));
            this.patient_IDTextBox.Location = new System.Drawing.Point(576, 156);
            this.patient_IDTextBox.Name = "patient_IDTextBox";
            this.patient_IDTextBox.Size = new System.Drawing.Size(193, 22);
            this.patient_IDTextBox.TabIndex = 22;
            // 
            // per_Paid_PlanCheckBox
            // 
            this.per_Paid_PlanCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.paymentBindingSource, "Per Paid Plan", true));
            this.per_Paid_PlanCheckBox.Location = new System.Drawing.Point(576, 184);
            this.per_Paid_PlanCheckBox.Name = "per_Paid_PlanCheckBox";
            this.per_Paid_PlanCheckBox.Size = new System.Drawing.Size(193, 24);
            this.per_Paid_PlanCheckBox.TabIndex = 24;
            this.per_Paid_PlanCheckBox.Text = "checkBox1";
            this.per_Paid_PlanCheckBox.UseVisualStyleBackColor = true;
            // 
            // patient_NHS_NumberTextBox
            // 
            this.patient_NHS_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentBindingSource, "Patient NHS Number", true));
            this.patient_NHS_NumberTextBox.Location = new System.Drawing.Point(576, 214);
            this.patient_NHS_NumberTextBox.Name = "patient_NHS_NumberTextBox";
            this.patient_NHS_NumberTextBox.Size = new System.Drawing.Size(193, 22);
            this.patient_NHS_NumberTextBox.TabIndex = 26;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btExitPay);
            this.panel1.Controls.Add(this.btClosePay);
            this.panel1.Controls.Add(this.btSavePay);
            this.panel1.Controls.Add(this.btPreviousPay);
            this.panel1.Controls.Add(this.btNextPay);
            this.panel1.Controls.Add(this.btDeletePay);
            this.panel1.Controls.Add(this.btAddPay);
            this.panel1.Location = new System.Drawing.Point(70, 276);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 49);
            this.panel1.TabIndex = 36;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btExitPay
            // 
            this.btExitPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExitPay.Location = new System.Drawing.Point(549, 11);
            this.btExitPay.Name = "btExitPay";
            this.btExitPay.Size = new System.Drawing.Size(80, 27);
            this.btExitPay.TabIndex = 6;
            this.btExitPay.Text = "Exit";
            this.btExitPay.UseVisualStyleBackColor = true;
            this.btExitPay.Click += new System.EventHandler(this.btExitGP_Click);
            // 
            // btClosePay
            // 
            this.btClosePay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClosePay.Location = new System.Drawing.Point(463, 11);
            this.btClosePay.Name = "btClosePay";
            this.btClosePay.Size = new System.Drawing.Size(80, 27);
            this.btClosePay.TabIndex = 5;
            this.btClosePay.Text = "Close";
            this.btClosePay.UseVisualStyleBackColor = true;
            this.btClosePay.Click += new System.EventHandler(this.btCloseGP_Click);
            // 
            // btSavePay
            // 
            this.btSavePay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSavePay.Location = new System.Drawing.Point(377, 11);
            this.btSavePay.Name = "btSavePay";
            this.btSavePay.Size = new System.Drawing.Size(80, 27);
            this.btSavePay.TabIndex = 4;
            this.btSavePay.Text = "Save";
            this.btSavePay.UseVisualStyleBackColor = true;
            this.btSavePay.Click += new System.EventHandler(this.btSavePay_Click);
            // 
            // btPreviousPay
            // 
            this.btPreviousPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPreviousPay.Location = new System.Drawing.Point(291, 11);
            this.btPreviousPay.Name = "btPreviousPay";
            this.btPreviousPay.Size = new System.Drawing.Size(80, 27);
            this.btPreviousPay.TabIndex = 3;
            this.btPreviousPay.Text = "Previous";
            this.btPreviousPay.UseVisualStyleBackColor = true;
            this.btPreviousPay.Click += new System.EventHandler(this.btPreviousPay_Click);
            // 
            // btNextPay
            // 
            this.btNextPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNextPay.Location = new System.Drawing.Point(205, 11);
            this.btNextPay.Name = "btNextPay";
            this.btNextPay.Size = new System.Drawing.Size(80, 27);
            this.btNextPay.TabIndex = 2;
            this.btNextPay.Text = "Next";
            this.btNextPay.UseVisualStyleBackColor = true;
            this.btNextPay.Click += new System.EventHandler(this.btNextPay_Click);
            // 
            // btDeletePay
            // 
            this.btDeletePay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDeletePay.Location = new System.Drawing.Point(119, 11);
            this.btDeletePay.Name = "btDeletePay";
            this.btDeletePay.Size = new System.Drawing.Size(80, 27);
            this.btDeletePay.TabIndex = 1;
            this.btDeletePay.Text = "Delete";
            this.btDeletePay.UseVisualStyleBackColor = true;
            this.btDeletePay.Click += new System.EventHandler(this.btDeletePay_Click);
            // 
            // btAddPay
            // 
            this.btAddPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddPay.Location = new System.Drawing.Point(33, 11);
            this.btAddPay.Name = "btAddPay";
            this.btAddPay.Size = new System.Drawing.Size(80, 27);
            this.btAddPay.TabIndex = 0;
            this.btAddPay.Text = "Add";
            this.btAddPay.UseVisualStyleBackColor = true;
            this.btAddPay.Click += new System.EventHandler(this.btAddPay_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(48, 217);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 53);
            this.panel2.TabIndex = 37;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 338);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(invoice_NoLabel);
            this.Controls.Add(this.invoice_NoTextBox);
            this.Controls.Add(amount_PaidLabel);
            this.Controls.Add(this.amount_PaidTextBox);
            this.Controls.Add(method_of_PaymentLabel);
            this.Controls.Add(this.method_of_PaymentTextBox);
            this.Controls.Add(visa_CardLabel);
            this.Controls.Add(this.visa_CardTextBox);
            this.Controls.Add(debit_CardLabel);
            this.Controls.Add(this.debit_CardTextBox);
            this.Controls.Add(master_CardLabel);
            this.Controls.Add(this.master_CardTextBox);
            this.Controls.Add(credit_CardLabel);
            this.Controls.Add(this.credit_CardTextBox);
            this.Controls.Add(driect_DebitLabel);
            this.Controls.Add(this.driect_DebitTextBox);
            this.Controls.Add(visa_Debit_CardLabel);
            this.Controls.Add(this.visa_Debit_CardTextBox);
            this.Controls.Add(cash_PaidLabel);
            this.Controls.Add(this.cash_PaidTextBox);
            this.Controls.Add(patient_IDLabel);
            this.Controls.Add(this.patient_IDTextBox);
            this.Controls.Add(per_Paid_PlanLabel);
            this.Controls.Add(this.per_Paid_PlanCheckBox);
            this.Controls.Add(patient_NHS_NumberLabel);
            this.Controls.Add(this.patient_NHS_NumberTextBox);
            this.Controls.Add(this.paymentBindingNavigator);
            this.Name = "Form5";
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingNavigator)).EndInit();
            this.paymentBindingNavigator.ResumeLayout(false);
            this.paymentBindingNavigator.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PharmacyDataSet pharmacyDataSet;
        private System.Windows.Forms.BindingSource paymentBindingSource;
        private PharmacyDataSetTableAdapters.PaymentTableAdapter paymentTableAdapter;
        private PharmacyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator paymentBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton paymentBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox invoice_NoTextBox;
        private System.Windows.Forms.TextBox amount_PaidTextBox;
        private System.Windows.Forms.TextBox method_of_PaymentTextBox;
        private System.Windows.Forms.TextBox visa_CardTextBox;
        private System.Windows.Forms.TextBox debit_CardTextBox;
        private System.Windows.Forms.TextBox master_CardTextBox;
        private System.Windows.Forms.TextBox credit_CardTextBox;
        private System.Windows.Forms.TextBox driect_DebitTextBox;
        private System.Windows.Forms.TextBox visa_Debit_CardTextBox;
        private System.Windows.Forms.TextBox cash_PaidTextBox;
        private System.Windows.Forms.TextBox patient_IDTextBox;
        private System.Windows.Forms.CheckBox per_Paid_PlanCheckBox;
        private System.Windows.Forms.TextBox patient_NHS_NumberTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btExitPay;
        private System.Windows.Forms.Button btClosePay;
        private System.Windows.Forms.Button btSavePay;
        private System.Windows.Forms.Button btPreviousPay;
        private System.Windows.Forms.Button btNextPay;
        private System.Windows.Forms.Button btDeletePay;
        private System.Windows.Forms.Button btAddPay;
        private System.Windows.Forms.Panel panel2;
    }
}