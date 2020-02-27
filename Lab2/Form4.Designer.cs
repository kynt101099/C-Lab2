namespace Lab2
{
    partial class Form4
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
            System.Windows.Forms.Label nI_NumberLabel;
            System.Windows.Forms.Label firstnameLabel;
            System.Windows.Forms.Label surnameLabel;
            System.Windows.Forms.Label date_of_BirthLabel;
            System.Windows.Forms.Label billing_NameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label post_CodeLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label home_PhoneLabel;
            System.Windows.Forms.Label mobile_PhoneLabel;
            System.Windows.Forms.Label fax_PhoneLabel;
            System.Windows.Forms.Label menoLabel;
            System.Windows.Forms.Label patient__IDLabel;
            System.Windows.Forms.Label patient_NHS_NumberLabel;
            System.Windows.Forms.Label eMIS_NumberLabel;
            System.Windows.Forms.Label gP_Appointment_RefLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.pharmacyDataSet = new Lab2.PharmacyDataSet();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientTableAdapter = new Lab2.PharmacyDataSetTableAdapters.PatientTableAdapter();
            this.tableAdapterManager = new Lab2.PharmacyDataSetTableAdapters.TableAdapterManager();
            this.patientBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.patientBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nI_NumberTextBox = new System.Windows.Forms.TextBox();
            this.firstnameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.date_of_BirthTextBox = new System.Windows.Forms.TextBox();
            this.billing_NameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.post_CodeTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.home_PhoneTextBox = new System.Windows.Forms.TextBox();
            this.mobile_PhoneTextBox = new System.Windows.Forms.TextBox();
            this.fax_PhoneTextBox = new System.Windows.Forms.TextBox();
            this.menoTextBox = new System.Windows.Forms.TextBox();
            this.patient__IDTextBox = new System.Windows.Forms.TextBox();
            this.patient_NHS_NumberTextBox = new System.Windows.Forms.TextBox();
            this.eMIS_NumberTextBox = new System.Windows.Forms.TextBox();
            this.gP_Appointment_RefTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btExitPatient = new System.Windows.Forms.Button();
            this.btClosePatient = new System.Windows.Forms.Button();
            this.btSavePatient = new System.Windows.Forms.Button();
            this.btPreviousPatient = new System.Windows.Forms.Button();
            this.btNextPatient = new System.Windows.Forms.Button();
            this.btDeletePatient = new System.Windows.Forms.Button();
            this.btAddPatient = new System.Windows.Forms.Button();
            this.pnPatient = new System.Windows.Forms.Panel();
            this.patientDataGridView = new System.Windows.Forms.DataGridView();
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
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nI_NumberLabel = new System.Windows.Forms.Label();
            firstnameLabel = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            date_of_BirthLabel = new System.Windows.Forms.Label();
            billing_NameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            post_CodeLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            home_PhoneLabel = new System.Windows.Forms.Label();
            mobile_PhoneLabel = new System.Windows.Forms.Label();
            fax_PhoneLabel = new System.Windows.Forms.Label();
            menoLabel = new System.Windows.Forms.Label();
            patient__IDLabel = new System.Windows.Forms.Label();
            patient_NHS_NumberLabel = new System.Windows.Forms.Label();
            eMIS_NumberLabel = new System.Windows.Forms.Label();
            gP_Appointment_RefLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingNavigator)).BeginInit();
            this.patientBindingNavigator.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnPatient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nI_NumberLabel
            // 
            nI_NumberLabel.AutoSize = true;
            nI_NumberLabel.Location = new System.Drawing.Point(26, 38);
            nI_NumberLabel.Name = "nI_NumberLabel";
            nI_NumberLabel.Size = new System.Drawing.Size(79, 17);
            nI_NumberLabel.TabIndex = 1;
            nI_NumberLabel.Text = "NI Number:";
            // 
            // firstnameLabel
            // 
            firstnameLabel.AutoSize = true;
            firstnameLabel.Location = new System.Drawing.Point(26, 66);
            firstnameLabel.Name = "firstnameLabel";
            firstnameLabel.Size = new System.Drawing.Size(74, 17);
            firstnameLabel.TabIndex = 3;
            firstnameLabel.Text = "Firstname:";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new System.Drawing.Point(26, 94);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(69, 17);
            surnameLabel.TabIndex = 5;
            surnameLabel.Text = "Surname:";
            // 
            // date_of_BirthLabel
            // 
            date_of_BirthLabel.AutoSize = true;
            date_of_BirthLabel.Location = new System.Drawing.Point(26, 122);
            date_of_BirthLabel.Name = "date_of_BirthLabel";
            date_of_BirthLabel.Size = new System.Drawing.Size(91, 17);
            date_of_BirthLabel.TabIndex = 7;
            date_of_BirthLabel.Text = "Date of Birth:";
            // 
            // billing_NameLabel
            // 
            billing_NameLabel.AutoSize = true;
            billing_NameLabel.Location = new System.Drawing.Point(294, 41);
            billing_NameLabel.Name = "billing_NameLabel";
            billing_NameLabel.Size = new System.Drawing.Size(90, 17);
            billing_NameLabel.TabIndex = 9;
            billing_NameLabel.Text = "Billing Name:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(26, 158);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(64, 17);
            addressLabel.TabIndex = 11;
            addressLabel.Text = "Address:";
            // 
            // post_CodeLabel
            // 
            post_CodeLabel.AutoSize = true;
            post_CodeLabel.Location = new System.Drawing.Point(294, 66);
            post_CodeLabel.Name = "post_CodeLabel";
            post_CodeLabel.Size = new System.Drawing.Size(77, 17);
            post_CodeLabel.TabIndex = 13;
            post_CodeLabel.Text = "Post Code:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(294, 94);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(35, 17);
            cityLabel.TabIndex = 15;
            cityLabel.Text = "City:";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new System.Drawing.Point(294, 122);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(61, 17);
            countryLabel.TabIndex = 17;
            countryLabel.Text = "Country:";
            // 
            // home_PhoneLabel
            // 
            home_PhoneLabel.AutoSize = true;
            home_PhoneLabel.Location = new System.Drawing.Point(294, 150);
            home_PhoneLabel.Name = "home_PhoneLabel";
            home_PhoneLabel.Size = new System.Drawing.Size(94, 17);
            home_PhoneLabel.TabIndex = 19;
            home_PhoneLabel.Text = "Home Phone:";
            // 
            // mobile_PhoneLabel
            // 
            mobile_PhoneLabel.AutoSize = true;
            mobile_PhoneLabel.Location = new System.Drawing.Point(294, 181);
            mobile_PhoneLabel.Name = "mobile_PhoneLabel";
            mobile_PhoneLabel.Size = new System.Drawing.Size(98, 17);
            mobile_PhoneLabel.TabIndex = 21;
            mobile_PhoneLabel.Text = "Mobile Phone:";
            // 
            // fax_PhoneLabel
            // 
            fax_PhoneLabel.AutoSize = true;
            fax_PhoneLabel.Location = new System.Drawing.Point(569, 41);
            fax_PhoneLabel.Name = "fax_PhoneLabel";
            fax_PhoneLabel.Size = new System.Drawing.Size(79, 17);
            fax_PhoneLabel.TabIndex = 23;
            fax_PhoneLabel.Text = "Fax Phone:";
            // 
            // menoLabel
            // 
            menoLabel.AutoSize = true;
            menoLabel.Location = new System.Drawing.Point(569, 69);
            menoLabel.Name = "menoLabel";
            menoLabel.Size = new System.Drawing.Size(47, 17);
            menoLabel.TabIndex = 25;
            menoLabel.Text = "Meno:";
            // 
            // patient__IDLabel
            // 
            patient__IDLabel.AutoSize = true;
            patient__IDLabel.Location = new System.Drawing.Point(569, 97);
            patient__IDLabel.Name = "patient__IDLabel";
            patient__IDLabel.Size = new System.Drawing.Size(77, 17);
            patient__IDLabel.TabIndex = 27;
            patient__IDLabel.Text = "Patient  ID:";
            // 
            // patient_NHS_NumberLabel
            // 
            patient_NHS_NumberLabel.AutoSize = true;
            patient_NHS_NumberLabel.Location = new System.Drawing.Point(569, 127);
            patient_NHS_NumberLabel.Name = "patient_NHS_NumberLabel";
            patient_NHS_NumberLabel.Size = new System.Drawing.Size(143, 17);
            patient_NHS_NumberLabel.TabIndex = 29;
            patient_NHS_NumberLabel.Text = "Patient NHS Number:";
            // 
            // eMIS_NumberLabel
            // 
            eMIS_NumberLabel.AutoSize = true;
            eMIS_NumberLabel.Location = new System.Drawing.Point(569, 158);
            eMIS_NumberLabel.Name = "eMIS_NumberLabel";
            eMIS_NumberLabel.Size = new System.Drawing.Size(98, 17);
            eMIS_NumberLabel.TabIndex = 31;
            eMIS_NumberLabel.Text = "EMIS Number:";
            // 
            // gP_Appointment_RefLabel
            // 
            gP_Appointment_RefLabel.AutoSize = true;
            gP_Appointment_RefLabel.Location = new System.Drawing.Point(569, 183);
            gP_Appointment_RefLabel.Name = "gP_Appointment_RefLabel";
            gP_Appointment_RefLabel.Size = new System.Drawing.Size(141, 17);
            gP_Appointment_RefLabel.TabIndex = 33;
            gP_Appointment_RefLabel.Text = "GP Appointment Ref:";
            // 
            // pharmacyDataSet
            // 
            this.pharmacyDataSet.DataSetName = "PharmacyDataSet";
            this.pharmacyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            this.patientBindingSource.DataSource = this.pharmacyDataSet;
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DoctorTableAdapter = null;
            this.tableAdapterManager.GP_AppointmentTableAdapter = null;
            this.tableAdapterManager.PatientTableAdapter = this.patientTableAdapter;
            this.tableAdapterManager.PaymentTableAdapter = null;
            this.tableAdapterManager.PharmacyTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Lab2.PharmacyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // patientBindingNavigator
            // 
            this.patientBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.patientBindingNavigator.BindingSource = this.patientBindingSource;
            this.patientBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.patientBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.patientBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.patientBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.patientBindingNavigatorSaveItem});
            this.patientBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.patientBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.patientBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.patientBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.patientBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.patientBindingNavigator.Name = "patientBindingNavigator";
            this.patientBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.patientBindingNavigator.Size = new System.Drawing.Size(888, 27);
            this.patientBindingNavigator.TabIndex = 0;
            this.patientBindingNavigator.Text = "bindingNavigator1";
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
            // patientBindingNavigatorSaveItem
            // 
            this.patientBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.patientBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("patientBindingNavigatorSaveItem.Image")));
            this.patientBindingNavigatorSaveItem.Name = "patientBindingNavigatorSaveItem";
            this.patientBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.patientBindingNavigatorSaveItem.Text = "Save Data";
            this.patientBindingNavigatorSaveItem.Click += new System.EventHandler(this.patientBindingNavigatorSaveItem_Click);
            // 
            // nI_NumberTextBox
            // 
            this.nI_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "NI Number", true));
            this.nI_NumberTextBox.Location = new System.Drawing.Point(129, 38);
            this.nI_NumberTextBox.Name = "nI_NumberTextBox";
            this.nI_NumberTextBox.Size = new System.Drawing.Size(137, 22);
            this.nI_NumberTextBox.TabIndex = 2;
            // 
            // firstnameTextBox
            // 
            this.firstnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Firstname", true));
            this.firstnameTextBox.Location = new System.Drawing.Point(129, 66);
            this.firstnameTextBox.Name = "firstnameTextBox";
            this.firstnameTextBox.Size = new System.Drawing.Size(137, 22);
            this.firstnameTextBox.TabIndex = 4;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Surname", true));
            this.surnameTextBox.Location = new System.Drawing.Point(129, 94);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(137, 22);
            this.surnameTextBox.TabIndex = 6;
            // 
            // date_of_BirthTextBox
            // 
            this.date_of_BirthTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Date of Birth", true));
            this.date_of_BirthTextBox.Location = new System.Drawing.Point(129, 122);
            this.date_of_BirthTextBox.Name = "date_of_BirthTextBox";
            this.date_of_BirthTextBox.Size = new System.Drawing.Size(137, 22);
            this.date_of_BirthTextBox.TabIndex = 8;
            // 
            // billing_NameTextBox
            // 
            this.billing_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Billing Name", true));
            this.billing_NameTextBox.Location = new System.Drawing.Point(408, 38);
            this.billing_NameTextBox.Name = "billing_NameTextBox";
            this.billing_NameTextBox.Size = new System.Drawing.Size(137, 22);
            this.billing_NameTextBox.TabIndex = 10;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(129, 152);
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(137, 51);
            this.addressTextBox.TabIndex = 12;
            // 
            // post_CodeTextBox
            // 
            this.post_CodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Post Code", true));
            this.post_CodeTextBox.Location = new System.Drawing.Point(408, 66);
            this.post_CodeTextBox.Name = "post_CodeTextBox";
            this.post_CodeTextBox.Size = new System.Drawing.Size(137, 22);
            this.post_CodeTextBox.TabIndex = 14;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(408, 94);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(137, 22);
            this.cityTextBox.TabIndex = 16;
            // 
            // countryTextBox
            // 
            this.countryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Country", true));
            this.countryTextBox.Location = new System.Drawing.Point(408, 122);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(137, 22);
            this.countryTextBox.TabIndex = 18;
            // 
            // home_PhoneTextBox
            // 
            this.home_PhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Home Phone", true));
            this.home_PhoneTextBox.Location = new System.Drawing.Point(408, 150);
            this.home_PhoneTextBox.Name = "home_PhoneTextBox";
            this.home_PhoneTextBox.Size = new System.Drawing.Size(137, 22);
            this.home_PhoneTextBox.TabIndex = 20;
            // 
            // mobile_PhoneTextBox
            // 
            this.mobile_PhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Mobile Phone", true));
            this.mobile_PhoneTextBox.Location = new System.Drawing.Point(408, 181);
            this.mobile_PhoneTextBox.Name = "mobile_PhoneTextBox";
            this.mobile_PhoneTextBox.Size = new System.Drawing.Size(137, 22);
            this.mobile_PhoneTextBox.TabIndex = 22;
            // 
            // fax_PhoneTextBox
            // 
            this.fax_PhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Fax Phone", true));
            this.fax_PhoneTextBox.Location = new System.Drawing.Point(718, 38);
            this.fax_PhoneTextBox.Name = "fax_PhoneTextBox";
            this.fax_PhoneTextBox.Size = new System.Drawing.Size(137, 22);
            this.fax_PhoneTextBox.TabIndex = 24;
            // 
            // menoTextBox
            // 
            this.menoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Meno", true));
            this.menoTextBox.Location = new System.Drawing.Point(718, 66);
            this.menoTextBox.Name = "menoTextBox";
            this.menoTextBox.Size = new System.Drawing.Size(137, 22);
            this.menoTextBox.TabIndex = 26;
            // 
            // patient__IDTextBox
            // 
            this.patient__IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Patient  ID", true));
            this.patient__IDTextBox.Location = new System.Drawing.Point(718, 94);
            this.patient__IDTextBox.Name = "patient__IDTextBox";
            this.patient__IDTextBox.Size = new System.Drawing.Size(137, 22);
            this.patient__IDTextBox.TabIndex = 28;
            // 
            // patient_NHS_NumberTextBox
            // 
            this.patient_NHS_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "Patient NHS Number", true));
            this.patient_NHS_NumberTextBox.Location = new System.Drawing.Point(718, 122);
            this.patient_NHS_NumberTextBox.Name = "patient_NHS_NumberTextBox";
            this.patient_NHS_NumberTextBox.Size = new System.Drawing.Size(137, 22);
            this.patient_NHS_NumberTextBox.TabIndex = 30;
            // 
            // eMIS_NumberTextBox
            // 
            this.eMIS_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "EMIS Number", true));
            this.eMIS_NumberTextBox.Location = new System.Drawing.Point(718, 150);
            this.eMIS_NumberTextBox.Name = "eMIS_NumberTextBox";
            this.eMIS_NumberTextBox.Size = new System.Drawing.Size(137, 22);
            this.eMIS_NumberTextBox.TabIndex = 32;
            // 
            // gP_Appointment_RefTextBox
            // 
            this.gP_Appointment_RefTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.patientBindingSource, "GP Appointment Ref", true));
            this.gP_Appointment_RefTextBox.Location = new System.Drawing.Point(718, 178);
            this.gP_Appointment_RefTextBox.Name = "gP_Appointment_RefTextBox";
            this.gP_Appointment_RefTextBox.Size = new System.Drawing.Size(137, 22);
            this.gP_Appointment_RefTextBox.TabIndex = 34;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btExitPatient);
            this.panel1.Controls.Add(this.btClosePatient);
            this.panel1.Controls.Add(this.btSavePatient);
            this.panel1.Controls.Add(this.btPreviousPatient);
            this.panel1.Controls.Add(this.btNextPatient);
            this.panel1.Controls.Add(this.btDeletePatient);
            this.panel1.Controls.Add(this.btAddPatient);
            this.panel1.Location = new System.Drawing.Point(109, 229);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 49);
            this.panel1.TabIndex = 36;
            // 
            // btExitPatient
            // 
            this.btExitPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExitPatient.Location = new System.Drawing.Point(549, 11);
            this.btExitPatient.Name = "btExitPatient";
            this.btExitPatient.Size = new System.Drawing.Size(80, 27);
            this.btExitPatient.TabIndex = 6;
            this.btExitPatient.Text = "Exit";
            this.btExitPatient.UseVisualStyleBackColor = true;
            this.btExitPatient.Click += new System.EventHandler(this.btExitPatient_Click);
            // 
            // btClosePatient
            // 
            this.btClosePatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClosePatient.Location = new System.Drawing.Point(463, 11);
            this.btClosePatient.Name = "btClosePatient";
            this.btClosePatient.Size = new System.Drawing.Size(80, 27);
            this.btClosePatient.TabIndex = 5;
            this.btClosePatient.Text = "Close";
            this.btClosePatient.UseVisualStyleBackColor = true;
            this.btClosePatient.Click += new System.EventHandler(this.btClosePatient_Click);
            // 
            // btSavePatient
            // 
            this.btSavePatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSavePatient.Location = new System.Drawing.Point(377, 11);
            this.btSavePatient.Name = "btSavePatient";
            this.btSavePatient.Size = new System.Drawing.Size(80, 27);
            this.btSavePatient.TabIndex = 4;
            this.btSavePatient.Text = "Save";
            this.btSavePatient.UseVisualStyleBackColor = true;
            this.btSavePatient.Click += new System.EventHandler(this.btSavePatient_Click);
            // 
            // btPreviousPatient
            // 
            this.btPreviousPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPreviousPatient.Location = new System.Drawing.Point(291, 11);
            this.btPreviousPatient.Name = "btPreviousPatient";
            this.btPreviousPatient.Size = new System.Drawing.Size(80, 27);
            this.btPreviousPatient.TabIndex = 3;
            this.btPreviousPatient.Text = "Previous";
            this.btPreviousPatient.UseVisualStyleBackColor = true;
            this.btPreviousPatient.Click += new System.EventHandler(this.btPreviousPatient_Click);
            // 
            // btNextPatient
            // 
            this.btNextPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNextPatient.Location = new System.Drawing.Point(205, 11);
            this.btNextPatient.Name = "btNextPatient";
            this.btNextPatient.Size = new System.Drawing.Size(80, 27);
            this.btNextPatient.TabIndex = 2;
            this.btNextPatient.Text = "Next";
            this.btNextPatient.UseVisualStyleBackColor = true;
            this.btNextPatient.Click += new System.EventHandler(this.btNextPatient_Click);
            // 
            // btDeletePatient
            // 
            this.btDeletePatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDeletePatient.Location = new System.Drawing.Point(119, 11);
            this.btDeletePatient.Name = "btDeletePatient";
            this.btDeletePatient.Size = new System.Drawing.Size(80, 27);
            this.btDeletePatient.TabIndex = 1;
            this.btDeletePatient.Text = "Delete";
            this.btDeletePatient.UseVisualStyleBackColor = true;
            this.btDeletePatient.Click += new System.EventHandler(this.btDeletePatient_Click);
            // 
            // btAddPatient
            // 
            this.btAddPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddPatient.Location = new System.Drawing.Point(33, 11);
            this.btAddPatient.Name = "btAddPatient";
            this.btAddPatient.Size = new System.Drawing.Size(80, 27);
            this.btAddPatient.TabIndex = 0;
            this.btAddPatient.Text = "Add";
            this.btAddPatient.UseVisualStyleBackColor = true;
            this.btAddPatient.Click += new System.EventHandler(this.btAddPatient_Click);
            // 
            // pnPatient
            // 
            this.pnPatient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnPatient.Controls.Add(this.patientDataGridView);
            this.pnPatient.Location = new System.Drawing.Point(29, 298);
            this.pnPatient.Name = "pnPatient";
            this.pnPatient.Size = new System.Drawing.Size(824, 222);
            this.pnPatient.TabIndex = 37;
            // 
            // patientDataGridView
            // 
            this.patientDataGridView.AutoGenerateColumns = false;
            this.patientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17});
            this.patientDataGridView.DataSource = this.patientBindingSource;
            this.patientDataGridView.Location = new System.Drawing.Point(-2, -2);
            this.patientDataGridView.Name = "patientDataGridView";
            this.patientDataGridView.RowTemplate.Height = 24;
            this.patientDataGridView.Size = new System.Drawing.Size(824, 220);
            this.patientDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "NI Number";
            this.dataGridViewTextBoxColumn1.HeaderText = "NI Number";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Firstname";
            this.dataGridViewTextBoxColumn2.HeaderText = "Firstname";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Surname";
            this.dataGridViewTextBoxColumn3.HeaderText = "Surname";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Date of Birth";
            this.dataGridViewTextBoxColumn4.HeaderText = "Date of Birth";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Billing Name";
            this.dataGridViewTextBoxColumn5.HeaderText = "Billing Name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn6.HeaderText = "Address";
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
            this.dataGridViewTextBoxColumn8.DataPropertyName = "City";
            this.dataGridViewTextBoxColumn8.HeaderText = "City";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Country";
            this.dataGridViewTextBoxColumn9.HeaderText = "Country";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Home Phone";
            this.dataGridViewTextBoxColumn10.HeaderText = "Home Phone";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Mobile Phone";
            this.dataGridViewTextBoxColumn11.HeaderText = "Mobile Phone";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Fax Phone";
            this.dataGridViewTextBoxColumn12.HeaderText = "Fax Phone";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Meno";
            this.dataGridViewTextBoxColumn13.HeaderText = "Meno";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Patient  ID";
            this.dataGridViewTextBoxColumn14.HeaderText = "Patient  ID";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Patient NHS Number";
            this.dataGridViewTextBoxColumn15.HeaderText = "Patient NHS Number";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "EMIS Number";
            this.dataGridViewTextBoxColumn16.HeaderText = "EMIS Number";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "GP Appointment Ref";
            this.dataGridViewTextBoxColumn17.HeaderText = "GP Appointment Ref";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 520);
            this.Controls.Add(this.pnPatient);
            this.Controls.Add(this.panel1);
            this.Controls.Add(nI_NumberLabel);
            this.Controls.Add(this.nI_NumberTextBox);
            this.Controls.Add(firstnameLabel);
            this.Controls.Add(this.firstnameTextBox);
            this.Controls.Add(surnameLabel);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(date_of_BirthLabel);
            this.Controls.Add(this.date_of_BirthTextBox);
            this.Controls.Add(billing_NameLabel);
            this.Controls.Add(this.billing_NameTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(post_CodeLabel);
            this.Controls.Add(this.post_CodeTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(countryLabel);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(home_PhoneLabel);
            this.Controls.Add(this.home_PhoneTextBox);
            this.Controls.Add(mobile_PhoneLabel);
            this.Controls.Add(this.mobile_PhoneTextBox);
            this.Controls.Add(fax_PhoneLabel);
            this.Controls.Add(this.fax_PhoneTextBox);
            this.Controls.Add(menoLabel);
            this.Controls.Add(this.menoTextBox);
            this.Controls.Add(patient__IDLabel);
            this.Controls.Add(this.patient__IDTextBox);
            this.Controls.Add(patient_NHS_NumberLabel);
            this.Controls.Add(this.patient_NHS_NumberTextBox);
            this.Controls.Add(eMIS_NumberLabel);
            this.Controls.Add(this.eMIS_NumberTextBox);
            this.Controls.Add(gP_Appointment_RefLabel);
            this.Controls.Add(this.gP_Appointment_RefTextBox);
            this.Controls.Add(this.patientBindingNavigator);
            this.Name = "Form4";
            this.Text = "Patient";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pharmacyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingNavigator)).EndInit();
            this.patientBindingNavigator.ResumeLayout(false);
            this.patientBindingNavigator.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnPatient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.patientDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PharmacyDataSet pharmacyDataSet;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private PharmacyDataSetTableAdapters.PatientTableAdapter patientTableAdapter;
        private PharmacyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator patientBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton patientBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nI_NumberTextBox;
        private System.Windows.Forms.TextBox firstnameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox date_of_BirthTextBox;
        private System.Windows.Forms.TextBox billing_NameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox post_CodeTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.TextBox home_PhoneTextBox;
        private System.Windows.Forms.TextBox mobile_PhoneTextBox;
        private System.Windows.Forms.TextBox fax_PhoneTextBox;
        private System.Windows.Forms.TextBox menoTextBox;
        private System.Windows.Forms.TextBox patient__IDTextBox;
        private System.Windows.Forms.TextBox patient_NHS_NumberTextBox;
        private System.Windows.Forms.TextBox eMIS_NumberTextBox;
        private System.Windows.Forms.TextBox gP_Appointment_RefTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btExitPatient;
        private System.Windows.Forms.Button btClosePatient;
        private System.Windows.Forms.Button btSavePatient;
        private System.Windows.Forms.Button btPreviousPatient;
        private System.Windows.Forms.Button btNextPatient;
        private System.Windows.Forms.Button btDeletePatient;
        private System.Windows.Forms.Button btAddPatient;
        private System.Windows.Forms.Panel pnPatient;
        private System.Windows.Forms.DataGridView patientDataGridView;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
    }
}