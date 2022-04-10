
namespace EmployeeManagementSystem
{
    partial class Register
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
            this.dataGridViewRegister = new System.Windows.Forms.DataGridView();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.groupBoxNote = new System.Windows.Forms.GroupBox();
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.labelDataStartDate = new System.Windows.Forms.Label();
            this.monthCalendarRegister = new System.Windows.Forms.MonthCalendar();
            this.labelSearch = new System.Windows.Forms.Label();
            this.groupBoxRegisterForm = new System.Windows.Forms.GroupBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxFirstname = new System.Windows.Forms.TextBox();
            this.checkBoxToSAgreed = new System.Windows.Forms.CheckBox();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelSector = new System.Windows.Forms.Label();
            this.labelToS = new System.Windows.Forms.Label();
            this.textBoxSector = new System.Windows.Forms.TextBox();
            this.radioButtonOther = new System.Windows.Forms.RadioButton();
            this.labelGender = new System.Windows.Forms.Label();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.groupBoxControls = new System.Windows.Forms.GroupBox();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelAccountType = new System.Windows.Forms.Label();
            this.labelAccountStatus = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegister)).BeginInit();
            this.groupBoxNote.SuspendLayout();
            this.groupBoxRegisterForm.SuspendLayout();
            this.groupBoxControls.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewRegister
            // 
            this.dataGridViewRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRegister.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewRegister.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewRegister.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridViewRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRegister.GridColor = System.Drawing.SystemColors.WindowFrame;
            this.dataGridViewRegister.Location = new System.Drawing.Point(3, 32);
            this.dataGridViewRegister.Name = "dataGridViewRegister";
            this.dataGridViewRegister.Size = new System.Drawing.Size(1206, 201);
            this.dataGridViewRegister.TabIndex = 17;
            this.dataGridViewRegister.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRegister_CellDoubleClick);
            this.dataGridViewRegister.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewRegister_CellFormatting);
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Location = new System.Drawing.Point(633, 186);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(58, 13);
            this.labelStartDate.TabIndex = 24;
            this.labelStartDate.Text = "Start Date:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(121, 6);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(785, 20);
            this.textBoxSearch.TabIndex = 20;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // groupBoxNote
            // 
            this.groupBoxNote.Controls.Add(this.textBoxNote);
            this.groupBoxNote.Location = new System.Drawing.Point(706, 186);
            this.groupBoxNote.Name = "groupBoxNote";
            this.groupBoxNote.Size = new System.Drawing.Size(501, 94);
            this.groupBoxNote.TabIndex = 23;
            this.groupBoxNote.TabStop = false;
            this.groupBoxNote.Text = "Note";
            // 
            // textBoxNote
            // 
            this.textBoxNote.Location = new System.Drawing.Point(6, 19);
            this.textBoxNote.Multiline = true;
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.Size = new System.Drawing.Size(489, 69);
            this.textBoxNote.TabIndex = 18;
            // 
            // labelDataStartDate
            // 
            this.labelDataStartDate.AutoSize = true;
            this.labelDataStartDate.Location = new System.Drawing.Point(633, 211);
            this.labelDataStartDate.Name = "labelDataStartDate";
            this.labelDataStartDate.Size = new System.Drawing.Size(0, 13);
            this.labelDataStartDate.TabIndex = 25;
            // 
            // monthCalendarRegister
            // 
            this.monthCalendarRegister.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendarRegister.Location = new System.Drawing.Point(980, 18);
            this.monthCalendarRegister.Name = "monthCalendarRegister";
            this.monthCalendarRegister.TabIndex = 22;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSearch.Location = new System.Drawing.Point(36, 11);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(56, 15);
            this.labelSearch.TabIndex = 19;
            this.labelSearch.Text = "Search:";
            // 
            // groupBoxRegisterForm
            // 
            this.groupBoxRegisterForm.Controls.Add(this.labelAccountStatus);
            this.groupBoxRegisterForm.Controls.Add(this.comboBoxStatus);
            this.groupBoxRegisterForm.Controls.Add(this.labelAccountType);
            this.groupBoxRegisterForm.Controls.Add(this.comboBoxType);
            this.groupBoxRegisterForm.Controls.Add(this.labelPassword);
            this.groupBoxRegisterForm.Controls.Add(this.textBoxPassword);
            this.groupBoxRegisterForm.Controls.Add(this.labelUsername);
            this.groupBoxRegisterForm.Controls.Add(this.textBoxUsername);
            this.groupBoxRegisterForm.Controls.Add(this.labelID);
            this.groupBoxRegisterForm.Controls.Add(this.textBoxID);
            this.groupBoxRegisterForm.Controls.Add(this.textBoxAddress);
            this.groupBoxRegisterForm.Controls.Add(this.labelFirstName);
            this.groupBoxRegisterForm.Controls.Add(this.textBoxFirstname);
            this.groupBoxRegisterForm.Controls.Add(this.checkBoxToSAgreed);
            this.groupBoxRegisterForm.Controls.Add(this.radioButtonMale);
            this.groupBoxRegisterForm.Controls.Add(this.labelAddress);
            this.groupBoxRegisterForm.Controls.Add(this.labelLastName);
            this.groupBoxRegisterForm.Controls.Add(this.textBoxEmail);
            this.groupBoxRegisterForm.Controls.Add(this.textBoxLastName);
            this.groupBoxRegisterForm.Controls.Add(this.labelEmail);
            this.groupBoxRegisterForm.Controls.Add(this.labelSector);
            this.groupBoxRegisterForm.Controls.Add(this.labelToS);
            this.groupBoxRegisterForm.Controls.Add(this.textBoxSector);
            this.groupBoxRegisterForm.Controls.Add(this.radioButtonOther);
            this.groupBoxRegisterForm.Controls.Add(this.labelGender);
            this.groupBoxRegisterForm.Controls.Add(this.radioButtonFemale);
            this.groupBoxRegisterForm.Location = new System.Drawing.Point(19, 12);
            this.groupBoxRegisterForm.Name = "groupBoxRegisterForm";
            this.groupBoxRegisterForm.Size = new System.Drawing.Size(608, 261);
            this.groupBoxRegisterForm.TabIndex = 20;
            this.groupBoxRegisterForm.TabStop = false;
            this.groupBoxRegisterForm.Text = "Register Form";
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "User",
            "Admin"});
            this.comboBoxType.Location = new System.Drawing.Point(394, 86);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(177, 21);
            this.comboBoxType.TabIndex = 23;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(297, 66);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(73, 15);
            this.labelPassword.TabIndex = 21;
            this.labelPassword.Text = "Password:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.AcceptsReturn = true;
            this.textBoxPassword.Location = new System.Drawing.Point(382, 61);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(189, 20);
            this.textBoxPassword.TabIndex = 22;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.Location = new System.Drawing.Point(297, 40);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(77, 15);
            this.labelUsername.TabIndex = 19;
            this.labelUsername.Text = "Username:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.AcceptsReturn = true;
            this.textBoxUsername.Location = new System.Drawing.Point(382, 35);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(189, 20);
            this.textBoxUsername.TabIndex = 20;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(17, 205);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(25, 15);
            this.labelID.TabIndex = 17;
            this.labelID.Text = "ID:";
            // 
            // textBoxID
            // 
            this.textBoxID.Enabled = false;
            this.textBoxID.Location = new System.Drawing.Point(102, 200);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(189, 20);
            this.textBoxID.TabIndex = 18;
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(102, 139);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(189, 20);
            this.textBoxAddress.TabIndex = 16;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFirstName.Location = new System.Drawing.Point(17, 40);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(79, 15);
            this.labelFirstName.TabIndex = 0;
            this.labelFirstName.Text = "First name:";
            // 
            // textBoxFirstname
            // 
            this.textBoxFirstname.AcceptsReturn = true;
            this.textBoxFirstname.Location = new System.Drawing.Point(102, 35);
            this.textBoxFirstname.Name = "textBoxFirstname";
            this.textBoxFirstname.Size = new System.Drawing.Size(189, 20);
            this.textBoxFirstname.TabIndex = 2;
            // 
            // checkBoxToSAgreed
            // 
            this.checkBoxToSAgreed.AutoSize = true;
            this.checkBoxToSAgreed.Location = new System.Drawing.Point(102, 234);
            this.checkBoxToSAgreed.Name = "checkBoxToSAgreed";
            this.checkBoxToSAgreed.Size = new System.Drawing.Size(60, 17);
            this.checkBoxToSAgreed.TabIndex = 3;
            this.checkBoxToSAgreed.Text = "Agreed";
            this.checkBoxToSAgreed.UseVisualStyleBackColor = true;
            this.checkBoxToSAgreed.CheckedChanged += new System.EventHandler(this.checkBoxToSAgreed_CheckedChanged);
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(102, 177);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(48, 17);
            this.radioButtonMale.TabIndex = 4;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(17, 144);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(62, 15);
            this.labelAddress.TabIndex = 15;
            this.labelAddress.Text = "Address:";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastName.Location = new System.Drawing.Point(17, 66);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(76, 15);
            this.labelLastName.TabIndex = 5;
            this.labelLastName.Text = "LastName:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(102, 113);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(189, 20);
            this.textBoxEmail.TabIndex = 14;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(102, 61);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(189, 20);
            this.textBoxLastName.TabIndex = 6;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(17, 118);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(48, 15);
            this.labelEmail.TabIndex = 13;
            this.labelEmail.Text = "Email:";
            // 
            // labelSector
            // 
            this.labelSector.AutoSize = true;
            this.labelSector.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSector.Location = new System.Drawing.Point(17, 92);
            this.labelSector.Name = "labelSector";
            this.labelSector.Size = new System.Drawing.Size(52, 15);
            this.labelSector.TabIndex = 7;
            this.labelSector.Text = "Sector:";
            // 
            // labelToS
            // 
            this.labelToS.AutoSize = true;
            this.labelToS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToS.Location = new System.Drawing.Point(17, 233);
            this.labelToS.Name = "labelToS";
            this.labelToS.Size = new System.Drawing.Size(36, 15);
            this.labelToS.TabIndex = 12;
            this.labelToS.Text = "ToS:";
            // 
            // textBoxSector
            // 
            this.textBoxSector.Location = new System.Drawing.Point(102, 87);
            this.textBoxSector.Name = "textBoxSector";
            this.textBoxSector.Size = new System.Drawing.Size(189, 20);
            this.textBoxSector.TabIndex = 8;
            // 
            // radioButtonOther
            // 
            this.radioButtonOther.AutoSize = true;
            this.radioButtonOther.Location = new System.Drawing.Point(221, 177);
            this.radioButtonOther.Name = "radioButtonOther";
            this.radioButtonOther.Size = new System.Drawing.Size(51, 17);
            this.radioButtonOther.TabIndex = 11;
            this.radioButtonOther.TabStop = true;
            this.radioButtonOther.Text = "Other";
            this.radioButtonOther.UseVisualStyleBackColor = true;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.Location = new System.Drawing.Point(17, 177);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(58, 15);
            this.labelGender.TabIndex = 9;
            this.labelGender.Text = "Gender:";
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(156, 177);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(59, 17);
            this.radioButtonFemale.TabIndex = 10;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // groupBoxControls
            // 
            this.groupBoxControls.Controls.Add(this.buttonExport);
            this.groupBoxControls.Controls.Add(this.buttonClear);
            this.groupBoxControls.Controls.Add(this.buttonDelete);
            this.groupBoxControls.Controls.Add(this.buttonRegister);
            this.groupBoxControls.Controls.Add(this.buttonUpdate);
            this.groupBoxControls.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBoxControls.Location = new System.Drawing.Point(633, 12);
            this.groupBoxControls.Name = "groupBoxControls";
            this.groupBoxControls.Size = new System.Drawing.Size(335, 168);
            this.groupBoxControls.TabIndex = 21;
            this.groupBoxControls.TabStop = false;
            this.groupBoxControls.Text = "Controls";
            // 
            // buttonExport
            // 
            this.buttonExport.BackColor = System.Drawing.Color.Green;
            this.buttonExport.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExport.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonExport.Image = global::EmployeeManagementSystem.Properties.Resources.export__1_;
            this.buttonExport.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonExport.Location = new System.Drawing.Point(116, 68);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(104, 38);
            this.buttonExport.TabIndex = 21;
            this.buttonExport.Text = "Excel Export";
            this.buttonExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonExport.UseVisualStyleBackColor = false;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Green;
            this.buttonClear.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonClear.Image = global::EmployeeManagementSystem.Properties.Resources.refresh__2_;
            this.buttonClear.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonClear.Location = new System.Drawing.Point(116, 24);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(104, 38);
            this.buttonClear.TabIndex = 20;
            this.buttonClear.Text = "Clear Form";
            this.buttonClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Green;
            this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonDelete.Image = global::EmployeeManagementSystem.Properties.Resources.delete__1_;
            this.buttonDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonDelete.Location = new System.Drawing.Point(6, 112);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(104, 38);
            this.buttonDelete.TabIndex = 19;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.Green;
            this.buttonRegister.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonRegister.Image = global::EmployeeManagementSystem.Properties.Resources.diskette;
            this.buttonRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRegister.Location = new System.Drawing.Point(6, 24);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(104, 38);
            this.buttonRegister.TabIndex = 1;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.BackColor = System.Drawing.Color.Green;
            this.buttonUpdate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonUpdate.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.buttonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonUpdate.Image = global::EmployeeManagementSystem.Properties.Resources.refresh;
            this.buttonUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUpdate.Location = new System.Drawing.Point(6, 68);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(104, 38);
            this.buttonUpdate.TabIndex = 18;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonUpdate.UseVisualStyleBackColor = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.groupBoxControls);
            this.panel2.Controls.Add(this.groupBoxRegisterForm);
            this.panel2.Controls.Add(this.monthCalendarRegister);
            this.panel2.Controls.Add(this.labelDataStartDate);
            this.panel2.Controls.Add(this.groupBoxNote);
            this.panel2.Controls.Add(this.labelStartDate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1214, 287);
            this.panel2.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.dataGridViewRegister);
            this.panel1.Controls.Add(this.textBoxSearch);
            this.panel1.Controls.Add(this.labelSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 287);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1214, 236);
            this.panel1.TabIndex = 28;
            // 
            // labelAccountType
            // 
            this.labelAccountType.AutoSize = true;
            this.labelAccountType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccountType.Location = new System.Drawing.Point(297, 92);
            this.labelAccountType.Name = "labelAccountType";
            this.labelAccountType.Size = new System.Drawing.Size(91, 15);
            this.labelAccountType.TabIndex = 24;
            this.labelAccountType.Text = "Account type:";
            // 
            // labelAccountStatus
            // 
            this.labelAccountStatus.AutoSize = true;
            this.labelAccountStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccountStatus.Location = new System.Drawing.Point(297, 118);
            this.labelAccountStatus.Name = "labelAccountStatus";
            this.labelAccountStatus.Size = new System.Drawing.Size(103, 15);
            this.labelAccountStatus.TabIndex = 26;
            this.labelAccountStatus.Text = "Account status:";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Active",
            "Disabled"});
            this.comboBoxStatus.Location = new System.Drawing.Point(406, 113);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(165, 21);
            this.comboBoxStatus.TabIndex = 25;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1214, 523);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Register_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegister)).EndInit();
            this.groupBoxNote.ResumeLayout(false);
            this.groupBoxNote.PerformLayout();
            this.groupBoxRegisterForm.ResumeLayout(false);
            this.groupBoxRegisterForm.PerformLayout();
            this.groupBoxControls.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewRegister;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.GroupBox groupBoxNote;
        private System.Windows.Forms.TextBox textBoxNote;
        private System.Windows.Forms.Label labelDataStartDate;
        private System.Windows.Forms.MonthCalendar monthCalendarRegister;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.GroupBox groupBoxRegisterForm;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxFirstname;
        private System.Windows.Forms.CheckBox checkBoxToSAgreed;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelSector;
        private System.Windows.Forms.Label labelToS;
        private System.Windows.Forms.TextBox textBoxSector;
        private System.Windows.Forms.RadioButton radioButtonOther;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.GroupBox groupBoxControls;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label labelAccountStatus;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label labelAccountType;
    }
}