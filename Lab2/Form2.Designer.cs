namespace Lab2
{
    partial class Form2
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
            System.Windows.Forms.Label doctor_s_Ref_NoLabel;
            System.Windows.Forms.Label doctor_s_NHS_NoLabel;
            System.Windows.Forms.Label firstnameLabel;
            System.Windows.Forms.Label surnameLabel;
            System.Windows.Forms.Label medical_Centre_NameLabel;
            System.Windows.Forms.Label address_of_CentreLabel;
            System.Windows.Forms.Label post_CodeLabel;
            System.Windows.Forms.Label medical_Centre_RefLabel;
            System.Windows.Forms.Label office_Phone_No_1Label;
            System.Windows.Forms.Label office_Phone_No_2Label;
            System.Windows.Forms.Label fax_NoLabel;
            System.Windows.Forms.Label email_AddressLabel;
            System.Windows.Forms.Label patient_NHS_NumberLabel;
            System.Windows.Forms.Label eMIS_NumberLabel;
            System.Windows.Forms.Label gP_Appointment_RefLabel;
            System.Windows.Forms.Label patient_IDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pharmacyDataSet = new Lab2.PharmacyDataSet();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorTableAdapter = new Lab2.PharmacyDataSetTableAdapters.DoctorTableAdapter();
            this.tableAdapterManager = new Lab2.PharmacyDataSetTableAdapters.TableAdapterManager();
            this.doctorBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.doctorBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.doctor_s_Ref_NoTextBox = new System.Windows.Forms.TextBox();
            this.doctor_s_NHS_NoTextBox = new System.Windows.Forms.TextBox();
            this.firstnameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.medical_Centre_NameTextBox = new System.Windows.Forms.TextBox();
            this.address_of_CentreTextBox = new System.Windows.Forms.TextBox();
            this.post_CodeTextBox = new System.Windows.Forms.TextBox();
            this.medical_Centre_RefTextBox = new System.Windows.Forms.TextBox();
            this.office_Phone_No_1TextBox = new System.Windows.Forms.TextBox();
            this.office_Phone_No_2TextBox = new System.Windows.Forms.TextBox();
            this.fax_NoTextBox = new System.Windows.Forms.TextBox();
            this.email_AddressTextBox = new System.Windows.Forms.TextBox();
            this.patient_NHS_NumberTextBox = new System.Windows.Forms.TextBox();
            this.eMIS_NumberTextBox = new System.Windows.Forms.TextBox();
            this.gP_Appointment_RefTextBox = new System.Windows.Forms.TextBox();
            this.patient_IDTextBox = new System.Windows.Forms.TextBox();
            this.pnDoctor = new System.Windows.Forms.Panel();
            this.doctorDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btExitDoctor = new System.Windows.Forms.Button();
            this.btCloseDoctor = new System.Windows.Forms.Button();
            this.btSaveDoctor = new System.Windows.Forms.Button();
            this.btPreviousDoctor = new System.Windows.Forms.Button();
            this.btNextDoctor = new System.Windows.Forms.Button();
            this.btDeleteDoctor = new System.Windows.Forms.Button();
            this.btAddDoctor = new System.Windows.Forms.Button();
            doctor_s_Ref_NoLabel = new System.Windows.Forms.Label();
            doctor_s_NHS_NoLabel = new System.Windows.Forms.Label();
            firstnameLabel = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            medical_Centre_NameLabel = new System.Windows.Forms.Label();
            address_of_CentreLabel = new System.Windows.Forms.Label();
            post_CodeLabel = new System.Windows.Forms.Label();
            medical_Centre_RefLabel = new System.Windows.Forms.Label();
            office_Phone_No_1Label = new System.Windows.Forms.Label();
            office_Phone_No_2Label = new System.Windows.Forms.Label();
            fax_NoLabel = new System.Windows.Forms.Label();
            email_AddressLabel = new System.Windows.Forms.Label();
            patient_NHS_NumberLabel = new System.Windows.Forms.Label();
            eMIS_NumberLabel = new System.Windows.Forms.Label();
            gP_Appointment_RefLabel = new System.Windows.Forms.Label();
            patient_IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingNavigator)).BeginInit();
            this.doctorBindingNavigator.SuspendLayout();
            this.pnDoctor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // doctor_s_Ref_NoLabel
            // 
            doctor_s_Ref_NoLabel.AutoSize = true;
            doctor_s_Ref_NoLabel.Location = new System.Drawing.Point(26, 44);
            doctor_s_Ref_NoLabel.Name = "doctor_s_Ref_NoLabel";
            doctor_s_Ref_NoLabel.Size = new System.Drawing.Size(112, 17);
            doctor_s_Ref_NoLabel.TabIndex = 1;
            doctor_s_Ref_NoLabel.Text = "Doctor\'s Ref No:";
            // 
            // doctor_s_NHS_NoLabel
            // 
            doctor_s_NHS_NoLabel.AutoSize = true;
            doctor_s_NHS_NoLabel.Location = new System.Drawing.Point(26, 72);
            doctor_s_NHS_NoLabel.Name = "doctor_s_NHS_NoLabel";
            doctor_s_NHS_NoLabel.Size = new System.Drawing.Size(119, 17);
            doctor_s_NHS_NoLabel.TabIndex = 3;
            doctor_s_NHS_NoLabel.Text = "Doctor\'s NHS No:";
            // 
            // firstnameLabel
            // 
            firstnameLabel.AutoSize = true;
            firstnameLabel.Location = new System.Drawing.Point(26, 100);
            firstnameLabel.Name = "firstnameLabel";
            firstnameLabel.Size = new System.Drawing.Size(74, 17);
            firstnameLabel.TabIndex = 5;
            firstnameLabel.Text = "Firstname:";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new System.Drawing.Point(26, 128);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(69, 17);
            surnameLabel.TabIndex = 7;
            surnameLabel.Text = "Surname:";
            // 
            // medical_Centre_NameLabel
            // 
            medical_Centre_NameLabel.AutoSize = true;
            medical_Centre_NameLabel.Location = new System.Drawing.Point(26, 156);
            medical_Centre_NameLabel.Name = "medical_Centre_NameLabel";
            medical_Centre_NameLabel.Size = new System.Drawing.Size(147, 17);
            medical_Centre_NameLabel.TabIndex = 9;
            medical_Centre_NameLabel.Text = "Medical Centre Name:";
            // 
            // address_of_CentreLabel
            // 
            address_of_CentreLabel.AutoSize = true;
            address_of_CentreLabel.Location = new System.Drawing.Point(26, 184);
            address_of_CentreLabel.Name = "address_of_CentreLabel";
            address_of_CentreLabel.Size = new System.Drawing.Size(126, 17);
            address_of_CentreLabel.TabIndex = 11;
            address_of_CentreLabel.Text = "Address of Centre:";
            // 
            // post_CodeLabel
            // 
            post_CodeLabel.AutoSize = true;
            post_CodeLabel.Location = new System.Drawing.Point(387, 155);
            post_CodeLabel.Name = "post_CodeLabel";
            post_CodeLabel.Size = new System.Drawing.Size(77, 17);
            post_CodeLabel.TabIndex = 13;
            post_CodeLabel.Text = "Post Code:";
            post_CodeLabel.Click += new System.EventHandler(this.post_CodeLabel_Click);
            // 
            // medical_Centre_RefLabel
            // 
            medical_Centre_RefLabel.AutoSize = true;
            medical_Centre_RefLabel.Location = new System.Drawing.Point(387, 45);
            medical_Centre_RefLabel.Name = "medical_Centre_RefLabel";
            medical_Centre_RefLabel.Size = new System.Drawing.Size(132, 17);
            medical_Centre_RefLabel.TabIndex = 15;
            medical_Centre_RefLabel.Text = "Medical Centre Ref:";
            // 
            // office_Phone_No_1Label
            // 
            office_Phone_No_1Label.AutoSize = true;
            office_Phone_No_1Label.Location = new System.Drawing.Point(387, 73);
            office_Phone_No_1Label.Name = "office_Phone_No_1Label";
            office_Phone_No_1Label.Size = new System.Drawing.Size(128, 17);
            office_Phone_No_1Label.TabIndex = 17;
            office_Phone_No_1Label.Text = "Office Phone No 1:";
            // 
            // office_Phone_No_2Label
            // 
            office_Phone_No_2Label.AutoSize = true;
            office_Phone_No_2Label.Location = new System.Drawing.Point(387, 101);
            office_Phone_No_2Label.Name = "office_Phone_No_2Label";
            office_Phone_No_2Label.Size = new System.Drawing.Size(128, 17);
            office_Phone_No_2Label.TabIndex = 19;
            office_Phone_No_2Label.Text = "Office Phone No 2:";
            // 
            // fax_NoLabel
            // 
            fax_NoLabel.AutoSize = true;
            fax_NoLabel.Location = new System.Drawing.Point(387, 129);
            fax_NoLabel.Name = "fax_NoLabel";
            fax_NoLabel.Size = new System.Drawing.Size(56, 17);
            fax_NoLabel.TabIndex = 21;
            fax_NoLabel.Text = "Fax No:";
            // 
            // email_AddressLabel
            // 
            email_AddressLabel.AutoSize = true;
            email_AddressLabel.Location = new System.Drawing.Point(752, 47);
            email_AddressLabel.Name = "email_AddressLabel";
            email_AddressLabel.Size = new System.Drawing.Size(102, 17);
            email_AddressLabel.TabIndex = 23;
            email_AddressLabel.Text = "Email Address:";
            email_AddressLabel.Click += new System.EventHandler(this.email_AddressLabel_Click);
            // 
            // patient_NHS_NumberLabel
            // 
            patient_NHS_NumberLabel.AutoSize = true;
            patient_NHS_NumberLabel.Location = new System.Drawing.Point(752, 76);
            patient_NHS_NumberLabel.Name = "patient_NHS_NumberLabel";
            patient_NHS_NumberLabel.Size = new System.Drawing.Size(143, 17);
            patient_NHS_NumberLabel.TabIndex = 25;
            patient_NHS_NumberLabel.Text = "Patient NHS Number:";
            // 
            // eMIS_NumberLabel
            // 
            eMIS_NumberLabel.AutoSize = true;
            eMIS_NumberLabel.Location = new System.Drawing.Point(752, 104);
            eMIS_NumberLabel.Name = "eMIS_NumberLabel";
            eMIS_NumberLabel.Size = new System.Drawing.Size(98, 17);
            eMIS_NumberLabel.TabIndex = 27;
            eMIS_NumberLabel.Text = "EMIS Number:";
            // 
            // gP_Appointment_RefLabel
            // 
            gP_Appointment_RefLabel.AutoSize = true;
            gP_Appointment_RefLabel.Location = new System.Drawing.Point(752, 129);
            gP_Appointment_RefLabel.Name = "gP_Appointment_RefLabel";
            gP_Appointment_RefLabel.Size = new System.Drawing.Size(141, 17);
            gP_Appointment_RefLabel.TabIndex = 29;
            gP_Appointment_RefLabel.Text = "GP Appointment Ref:";
            // 
            // patient_IDLabel
            // 
            patient_IDLabel.AutoSize = true;
            patient_IDLabel.Location = new System.Drawing.Point(752, 157);
            patient_IDLabel.Name = "patient_IDLabel";
            patient_IDLabel.Size = new System.Drawing.Size(73, 17);
            patient_IDLabel.TabIndex = 31;
            patient_IDLabel.Text = "Patient ID:";
            // 
            // pharmacyDataSet
            // 
            this.pharmacyDataSet.DataSetName = "PharmacyDataSet";
            this.pharmacyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataMember = "Doctor";
            this.doctorBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // doctorTableAdapter
            // 
            this.doctorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DoctorTableAdapter = this.doctorTableAdapter;
            this.tableAdapterManager.GP_AppointmentTableAdapter = null;
            this.tableAdapterManager.PatientTableAdapter = null;
            this.tableAdapterManager.PaymentTableAdapter = null;
            this.tableAdapterManager.PharmacyTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Lab2.PharmacyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // doctorBindingNavigator
            // 
            this.doctorBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.doctorBindingNavigator.BindingSource = this.doctorBindingSource;
            this.doctorBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.doctorBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.doctorBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.doctorBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.doctorBindingNavigatorSaveItem});
            this.doctorBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.doctorBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.doctorBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.doctorBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.doctorBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.doctorBindingNavigator.Name = "doctorBindingNavigator";
            this.doctorBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.doctorBindingNavigator.Size = new System.Drawing.Size(1076, 27);
            this.doctorBindingNavigator.TabIndex = 0;
            this.doctorBindingNavigator.Text = "bindingNavigator1";
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
            // doctorBindingNavigatorSaveItem
            // 
            this.doctorBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.doctorBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("doctorBindingNavigatorSaveItem.Image")));
            this.doctorBindingNavigatorSaveItem.Name = "doctorBindingNavigatorSaveItem";
            this.doctorBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.doctorBindingNavigatorSaveItem.Text = "Save Data";
            this.doctorBindingNavigatorSaveItem.Click += new System.EventHandler(this.doctorBindingNavigatorSaveItem_Click);
            // 
            // doctor_s_Ref_NoTextBox
            // 
            this.doctor_s_Ref_NoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Doctor\'s Ref No", true));
            this.doctor_s_Ref_NoTextBox.Location = new System.Drawing.Point(179, 41);
            this.doctor_s_Ref_NoTextBox.Name = "doctor_s_Ref_NoTextBox";
            this.doctor_s_Ref_NoTextBox.Size = new System.Drawing.Size(149, 22);
            this.doctor_s_Ref_NoTextBox.TabIndex = 2;
            // 
            // doctor_s_NHS_NoTextBox
            // 
            this.doctor_s_NHS_NoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Doctor\'s NHS No", true));
            this.doctor_s_NHS_NoTextBox.Location = new System.Drawing.Point(179, 69);
            this.doctor_s_NHS_NoTextBox.Name = "doctor_s_NHS_NoTextBox";
            this.doctor_s_NHS_NoTextBox.Size = new System.Drawing.Size(149, 22);
            this.doctor_s_NHS_NoTextBox.TabIndex = 4;
            // 
            // firstnameTextBox
            // 
            this.firstnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Firstname", true));
            this.firstnameTextBox.Location = new System.Drawing.Point(179, 97);
            this.firstnameTextBox.Name = "firstnameTextBox";
            this.firstnameTextBox.Size = new System.Drawing.Size(149, 22);
            this.firstnameTextBox.TabIndex = 6;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Surname", true));
            this.surnameTextBox.Location = new System.Drawing.Point(179, 125);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(149, 22);
            this.surnameTextBox.TabIndex = 8;
            // 
            // medical_Centre_NameTextBox
            // 
            this.medical_Centre_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Medical Centre Name", true));
            this.medical_Centre_NameTextBox.Location = new System.Drawing.Point(179, 153);
            this.medical_Centre_NameTextBox.Name = "medical_Centre_NameTextBox";
            this.medical_Centre_NameTextBox.Size = new System.Drawing.Size(149, 22);
            this.medical_Centre_NameTextBox.TabIndex = 10;
            // 
            // address_of_CentreTextBox
            // 
            this.address_of_CentreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Address of Centre", true));
            this.address_of_CentreTextBox.Location = new System.Drawing.Point(179, 181);
            this.address_of_CentreTextBox.Name = "address_of_CentreTextBox";
            this.address_of_CentreTextBox.Size = new System.Drawing.Size(149, 22);
            this.address_of_CentreTextBox.TabIndex = 12;
            // 
            // post_CodeTextBox
            // 
            this.post_CodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Post Code", true));
            this.post_CodeTextBox.Location = new System.Drawing.Point(540, 157);
            this.post_CodeTextBox.Name = "post_CodeTextBox";
            this.post_CodeTextBox.Size = new System.Drawing.Size(149, 22);
            this.post_CodeTextBox.TabIndex = 14;
            // 
            // medical_Centre_RefTextBox
            // 
            this.medical_Centre_RefTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Medical Centre Ref", true));
            this.medical_Centre_RefTextBox.Location = new System.Drawing.Point(540, 42);
            this.medical_Centre_RefTextBox.Name = "medical_Centre_RefTextBox";
            this.medical_Centre_RefTextBox.Size = new System.Drawing.Size(149, 22);
            this.medical_Centre_RefTextBox.TabIndex = 16;
            // 
            // office_Phone_No_1TextBox
            // 
            this.office_Phone_No_1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Office Phone No 1", true));
            this.office_Phone_No_1TextBox.Location = new System.Drawing.Point(540, 70);
            this.office_Phone_No_1TextBox.Name = "office_Phone_No_1TextBox";
            this.office_Phone_No_1TextBox.Size = new System.Drawing.Size(149, 22);
            this.office_Phone_No_1TextBox.TabIndex = 18;
            // 
            // office_Phone_No_2TextBox
            // 
            this.office_Phone_No_2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Office Phone No 2", true));
            this.office_Phone_No_2TextBox.Location = new System.Drawing.Point(540, 98);
            this.office_Phone_No_2TextBox.Name = "office_Phone_No_2TextBox";
            this.office_Phone_No_2TextBox.Size = new System.Drawing.Size(149, 22);
            this.office_Phone_No_2TextBox.TabIndex = 20;
            // 
            // fax_NoTextBox
            // 
            this.fax_NoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Fax No", true));
            this.fax_NoTextBox.Location = new System.Drawing.Point(540, 126);
            this.fax_NoTextBox.Name = "fax_NoTextBox";
            this.fax_NoTextBox.Size = new System.Drawing.Size(149, 22);
            this.fax_NoTextBox.TabIndex = 22;
            // 
            // email_AddressTextBox
            // 
            this.email_AddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Email Address", true));
            this.email_AddressTextBox.Location = new System.Drawing.Point(901, 45);
            this.email_AddressTextBox.Name = "email_AddressTextBox";
            this.email_AddressTextBox.Size = new System.Drawing.Size(149, 22);
            this.email_AddressTextBox.TabIndex = 24;
            // 
            // patient_NHS_NumberTextBox
            // 
            this.patient_NHS_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Patient NHS Number", true));
            this.patient_NHS_NumberTextBox.Location = new System.Drawing.Point(901, 73);
            this.patient_NHS_NumberTextBox.Name = "patient_NHS_NumberTextBox";
            this.patient_NHS_NumberTextBox.Size = new System.Drawing.Size(149, 22);
            this.patient_NHS_NumberTextBox.TabIndex = 26;
            // 
            // eMIS_NumberTextBox
            // 
            this.eMIS_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "EMIS Number", true));
            this.eMIS_NumberTextBox.Location = new System.Drawing.Point(901, 101);
            this.eMIS_NumberTextBox.Name = "eMIS_NumberTextBox";
            this.eMIS_NumberTextBox.Size = new System.Drawing.Size(149, 22);
            this.eMIS_NumberTextBox.TabIndex = 28;
            // 
            // gP_Appointment_RefTextBox
            // 
            this.gP_Appointment_RefTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "GP Appointment Ref", true));
            this.gP_Appointment_RefTextBox.Location = new System.Drawing.Point(901, 129);
            this.gP_Appointment_RefTextBox.Name = "gP_Appointment_RefTextBox";
            this.gP_Appointment_RefTextBox.Size = new System.Drawing.Size(149, 22);
            this.gP_Appointment_RefTextBox.TabIndex = 30;
            // 
            // patient_IDTextBox
            // 
            this.patient_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Patient ID", true));
            this.patient_IDTextBox.Location = new System.Drawing.Point(901, 157);
            this.patient_IDTextBox.Name = "patient_IDTextBox";
            this.patient_IDTextBox.Size = new System.Drawing.Size(149, 22);
            this.patient_IDTextBox.TabIndex = 32;
            // 
            // pnDoctor
            // 
            this.pnDoctor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnDoctor.Controls.Add(this.doctorDataGridView);
            this.pnDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnDoctor.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pnDoctor.Location = new System.Drawing.Point(29, 246);
            this.pnDoctor.Name = "pnDoctor";
            this.pnDoctor.Size = new System.Drawing.Size(1021, 105);
            this.pnDoctor.TabIndex = 33;
            // 
            // doctorDataGridView
            // 
            this.doctorDataGridView.AutoGenerateColumns = false;
            this.doctorDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.doctorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.doctorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16});
            this.doctorDataGridView.DataSource = this.doctorBindingSource;
            this.doctorDataGridView.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.doctorDataGridView.Location = new System.Drawing.Point(-3, -2);
            this.doctorDataGridView.Name = "doctorDataGridView";
            this.doctorDataGridView.RowTemplate.Height = 24;
            this.doctorDataGridView.Size = new System.Drawing.Size(1017, 105);
            this.doctorDataGridView.TabIndex = 0;
            this.doctorDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.doctorDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Doctor\'s Ref No";
            this.dataGridViewTextBoxColumn1.HeaderText = "Doctor\'s Ref No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Doctor\'s NHS No";
            this.dataGridViewTextBoxColumn2.HeaderText = "Doctor\'s NHS No";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Firstname";
            this.dataGridViewTextBoxColumn3.HeaderText = "Firstname";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Surname";
            this.dataGridViewTextBoxColumn4.HeaderText = "Surname";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Medical Centre Name";
            this.dataGridViewTextBoxColumn5.HeaderText = "Medical Centre Name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Address of Centre";
            this.dataGridViewTextBoxColumn6.HeaderText = "Address of Centre";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Post Code";
            this.dataGridViewTextBoxColumn7.HeaderText = "Post Code";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Medical Centre Ref";
            this.dataGridViewTextBoxColumn8.HeaderText = "Medical Centre Ref";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Office Phone No 1";
            this.dataGridViewTextBoxColumn9.HeaderText = "Office Phone No 1";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Office Phone No 2";
            this.dataGridViewTextBoxColumn10.HeaderText = "Office Phone No 2";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Fax No";
            this.dataGridViewTextBoxColumn11.HeaderText = "Fax No";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Email Address";
            this.dataGridViewTextBoxColumn12.HeaderText = "Email Address";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Patient NHS Number";
            this.dataGridViewTextBoxColumn13.HeaderText = "Patient NHS Number";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "EMIS Number";
            this.dataGridViewTextBoxColumn14.HeaderText = "EMIS Number";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "GP Appointment Ref";
            this.dataGridViewTextBoxColumn15.HeaderText = "GP Appointment Ref";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Patient ID";
            this.dataGridViewTextBoxColumn16.HeaderText = "Patient ID";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btExitDoctor);
            this.panel1.Controls.Add(this.btCloseDoctor);
            this.panel1.Controls.Add(this.btSaveDoctor);
            this.panel1.Controls.Add(this.btPreviousDoctor);
            this.panel1.Controls.Add(this.btNextDoctor);
            this.panel1.Controls.Add(this.btDeleteDoctor);
            this.panel1.Controls.Add(this.btAddDoctor);
            this.panel1.Location = new System.Drawing.Point(390, 191);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 49);
            this.panel1.TabIndex = 34;
            // 
            // btExitDoctor
            // 
            this.btExitDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExitDoctor.Location = new System.Drawing.Point(549, 11);
            this.btExitDoctor.Name = "btExitDoctor";
            this.btExitDoctor.Size = new System.Drawing.Size(80, 27);
            this.btExitDoctor.TabIndex = 6;
            this.btExitDoctor.Text = "Exit";
            this.btExitDoctor.UseVisualStyleBackColor = true;
            this.btExitDoctor.Click += new System.EventHandler(this.btExitDoctor_Click);
            // 
            // btCloseDoctor
            // 
            this.btCloseDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCloseDoctor.Location = new System.Drawing.Point(463, 11);
            this.btCloseDoctor.Name = "btCloseDoctor";
            this.btCloseDoctor.Size = new System.Drawing.Size(80, 27);
            this.btCloseDoctor.TabIndex = 5;
            this.btCloseDoctor.Text = "Close";
            this.btCloseDoctor.UseVisualStyleBackColor = true;
            this.btCloseDoctor.Click += new System.EventHandler(this.btCloseDoctor_Click);
            // 
            // btSaveDoctor
            // 
            this.btSaveDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSaveDoctor.Location = new System.Drawing.Point(377, 11);
            this.btSaveDoctor.Name = "btSaveDoctor";
            this.btSaveDoctor.Size = new System.Drawing.Size(80, 27);
            this.btSaveDoctor.TabIndex = 4;
            this.btSaveDoctor.Text = "Save";
            this.btSaveDoctor.UseVisualStyleBackColor = true;
            this.btSaveDoctor.Click += new System.EventHandler(this.btSaveDoctor_Click);
            // 
            // btPreviousDoctor
            // 
            this.btPreviousDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPreviousDoctor.Location = new System.Drawing.Point(291, 11);
            this.btPreviousDoctor.Name = "btPreviousDoctor";
            this.btPreviousDoctor.Size = new System.Drawing.Size(80, 27);
            this.btPreviousDoctor.TabIndex = 3;
            this.btPreviousDoctor.Text = "Previous";
            this.btPreviousDoctor.UseVisualStyleBackColor = true;
            this.btPreviousDoctor.Click += new System.EventHandler(this.btPreviousDoctor_Click);
            // 
            // btNextDoctor
            // 
            this.btNextDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNextDoctor.Location = new System.Drawing.Point(205, 11);
            this.btNextDoctor.Name = "btNextDoctor";
            this.btNextDoctor.Size = new System.Drawing.Size(80, 27);
            this.btNextDoctor.TabIndex = 2;
            this.btNextDoctor.Text = "Next";
            this.btNextDoctor.UseVisualStyleBackColor = true;
            this.btNextDoctor.Click += new System.EventHandler(this.btNextDoctor_Click);
            // 
            // btDeleteDoctor
            // 
            this.btDeleteDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDeleteDoctor.Location = new System.Drawing.Point(119, 11);
            this.btDeleteDoctor.Name = "btDeleteDoctor";
            this.btDeleteDoctor.Size = new System.Drawing.Size(80, 27);
            this.btDeleteDoctor.TabIndex = 1;
            this.btDeleteDoctor.Text = "Delete";
            this.btDeleteDoctor.UseVisualStyleBackColor = true;
            this.btDeleteDoctor.Click += new System.EventHandler(this.btDeleteDoctor_Click);
            // 
            // btAddDoctor
            // 
            this.btAddDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddDoctor.Location = new System.Drawing.Point(33, 11);
            this.btAddDoctor.Name = "btAddDoctor";
            this.btAddDoctor.Size = new System.Drawing.Size(80, 27);
            this.btAddDoctor.TabIndex = 0;
            this.btAddDoctor.Text = "Add";
            this.btAddDoctor.UseVisualStyleBackColor = true;
            this.btAddDoctor.Click += new System.EventHandler(this.btAddDoctor_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 392);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnDoctor);
            this.Controls.Add(doctor_s_Ref_NoLabel);
            this.Controls.Add(this.doctor_s_Ref_NoTextBox);
            this.Controls.Add(doctor_s_NHS_NoLabel);
            this.Controls.Add(this.doctor_s_NHS_NoTextBox);
            this.Controls.Add(firstnameLabel);
            this.Controls.Add(this.firstnameTextBox);
            this.Controls.Add(surnameLabel);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(medical_Centre_NameLabel);
            this.Controls.Add(this.medical_Centre_NameTextBox);
            this.Controls.Add(address_of_CentreLabel);
            this.Controls.Add(this.address_of_CentreTextBox);
            this.Controls.Add(post_CodeLabel);
            this.Controls.Add(this.post_CodeTextBox);
            this.Controls.Add(medical_Centre_RefLabel);
            this.Controls.Add(this.medical_Centre_RefTextBox);
            this.Controls.Add(office_Phone_No_1Label);
            this.Controls.Add(this.office_Phone_No_1TextBox);
            this.Controls.Add(office_Phone_No_2Label);
            this.Controls.Add(this.office_Phone_No_2TextBox);
            this.Controls.Add(fax_NoLabel);
            this.Controls.Add(this.fax_NoTextBox);
            this.Controls.Add(email_AddressLabel);
            this.Controls.Add(this.email_AddressTextBox);
            this.Controls.Add(patient_NHS_NumberLabel);
            this.Controls.Add(this.patient_NHS_NumberTextBox);
            this.Controls.Add(eMIS_NumberLabel);
            this.Controls.Add(this.eMIS_NumberTextBox);
            this.Controls.Add(gP_Appointment_RefLabel);
            this.Controls.Add(this.gP_Appointment_RefTextBox);
            this.Controls.Add(patient_IDLabel);
            this.Controls.Add(this.patient_IDTextBox);
            this.Controls.Add(this.doctorBindingNavigator);
            this.Name = "Form2";
            this.Text = "Doctor";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingNavigator)).EndInit();
            this.doctorBindingNavigator.ResumeLayout(false);
            this.doctorBindingNavigator.PerformLayout();
            this.pnDoctor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.doctorDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PharmacyDataSet pharmacyDataSet;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private PharmacyDataSetTableAdapters.DoctorTableAdapter doctorTableAdapter;
        private PharmacyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator doctorBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton doctorBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox doctor_s_Ref_NoTextBox;
        private System.Windows.Forms.TextBox doctor_s_NHS_NoTextBox;
        private System.Windows.Forms.TextBox firstnameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox medical_Centre_NameTextBox;
        private System.Windows.Forms.TextBox address_of_CentreTextBox;
        private System.Windows.Forms.TextBox post_CodeTextBox;
        private System.Windows.Forms.TextBox medical_Centre_RefTextBox;
        private System.Windows.Forms.TextBox office_Phone_No_1TextBox;
        private System.Windows.Forms.TextBox office_Phone_No_2TextBox;
        private System.Windows.Forms.TextBox fax_NoTextBox;
        private System.Windows.Forms.TextBox email_AddressTextBox;
        private System.Windows.Forms.TextBox patient_NHS_NumberTextBox;
        private System.Windows.Forms.TextBox eMIS_NumberTextBox;
        private System.Windows.Forms.TextBox gP_Appointment_RefTextBox;
        private System.Windows.Forms.TextBox patient_IDTextBox;
        private System.Windows.Forms.Panel pnDoctor;
        private System.Windows.Forms.DataGridView doctorDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btExitDoctor;
        private System.Windows.Forms.Button btCloseDoctor;
        private System.Windows.Forms.Button btSaveDoctor;
        private System.Windows.Forms.Button btPreviousDoctor;
        private System.Windows.Forms.Button btNextDoctor;
        private System.Windows.Forms.Button btDeleteDoctor;
        private System.Windows.Forms.Button btAddDoctor;
    }
}