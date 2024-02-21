namespace appTextFiles
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dgvEmployeeTable = new DataGridView();
            cbDepartament = new ComboBox();
            label9 = new Label();
            btnDelete = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSearch = new Button();
            txtAge = new TextBox();
            txtSecondName = new TextBox();
            txtName = new TextBox();
            btnSave = new Button();
            btnOpenFile = new Button();
            tabPage2 = new TabPage();
            label8 = new Label();
            dgvContactos = new DataGridView();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtEmailSql = new TextBox();
            txtPhoneSql = new TextBox();
            txtNameSql = new TextBox();
            btnDeleteSql = new Button();
            btnUpdateSql = new Button();
            btnInsert = new Button();
            tabPage3 = new TabPage();
            btnUpdate = new Button();
            label14 = new Label();
            txtNameDA = new TextBox();
            cbDepartamentDA = new ComboBox();
            button2 = new Button();
            label11 = new Label();
            label13 = new Label();
            button3 = new Button();
            txtID = new TextBox();
            button4 = new Button();
            dgvEmpTabl = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            label10 = new Label();
            btnOpenDA = new Button();
            ID = new DataGridViewTextBoxColumn();
            NName = new DataGridViewTextBoxColumn();
            PPhone = new DataGridViewTextBoxColumn();
            EEmail = new DataGridViewTextBoxColumn();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployeeTable).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvContactos).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpTabl).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(-1, -1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1034, 446);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Gray;
            tabPage1.Controls.Add(dgvEmployeeTable);
            tabPage1.Controls.Add(cbDepartament);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(btnDelete);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(btnSearch);
            tabPage1.Controls.Add(txtAge);
            tabPage1.Controls.Add(txtSecondName);
            tabPage1.Controls.Add(txtName);
            tabPage1.Controls.Add(btnSave);
            tabPage1.Controls.Add(btnOpenFile);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1026, 413);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Sequential Operations";
            // 
            // dgvEmployeeTable
            // 
            dgvEmployeeTable.AllowUserToAddRows = false;
            dgvEmployeeTable.AllowUserToResizeColumns = false;
            dgvEmployeeTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvEmployeeTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployeeTable.EnableHeadersVisualStyles = false;
            dgvEmployeeTable.Location = new Point(56, 103);
            dgvEmployeeTable.MultiSelect = false;
            dgvEmployeeTable.Name = "dgvEmployeeTable";
            dgvEmployeeTable.ReadOnly = true;
            dgvEmployeeTable.RowHeadersVisible = false;
            dgvEmployeeTable.RowHeadersWidth = 51;
            dgvEmployeeTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployeeTable.Size = new Size(503, 215);
            dgvEmployeeTable.StandardTab = true;
            dgvEmployeeTable.TabIndex = 17;
            // 
            // cbDepartament
            // 
            cbDepartament.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDepartament.FormattingEnabled = true;
            cbDepartament.Items.AddRange(new object[] { "Office", "Library", "Servers", "Administration" });
            cbDepartament.Location = new Point(754, 226);
            cbDepartament.Name = "cbDepartament";
            cbDepartament.Size = new Size(205, 28);
            cbDepartament.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Narrow", 12F);
            label9.Location = new Point(693, 60);
            label9.Name = "label9";
            label9.Size = new Size(55, 24);
            label9.TabIndex = 15;
            label9.Text = "Name";
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Arial Narrow", 10.8F);
            btnDelete.Location = new Point(799, 336);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(160, 46);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 12F);
            label4.Location = new Point(638, 230);
            label4.Name = "label4";
            label4.Size = new Size(106, 24);
            label4.TabIndex = 13;
            label4.Text = "Departament";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F);
            label3.Location = new Point(705, 178);
            label3.Name = "label3";
            label3.Size = new Size(39, 24);
            label3.TabIndex = 12;
            label3.Text = "Age";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F);
            label2.Location = new Point(636, 120);
            label2.Name = "label2";
            label2.Size = new Size(112, 24);
            label2.TabIndex = 11;
            label2.Text = "Second name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(56, 42);
            label1.Name = "label1";
            label1.Size = new Size(333, 46);
            label1.TabIndex = 10;
            label1.Text = "Employee registration";
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Arial Narrow", 10.8F);
            btnSearch.Location = new Point(633, 336);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(160, 46);
            btnSearch.TabIndex = 9;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(754, 175);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(205, 27);
            txtAge.TabIndex = 7;
            // 
            // txtSecondName
            // 
            txtSecondName.Location = new Point(754, 117);
            txtSecondName.Name = "txtSecondName";
            txtSecondName.Size = new Size(205, 27);
            txtSecondName.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.Location = new Point(754, 57);
            txtName.Name = "txtName";
            txtName.Size = new Size(205, 27);
            txtName.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Arial Narrow", 10.8F);
            btnSave.Location = new Point(633, 284);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(326, 46);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnOpenFile
            // 
            btnOpenFile.Font = new Font("Arial Narrow", 10.8F);
            btnOpenFile.Location = new Point(56, 337);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(160, 45);
            btnOpenFile.TabIndex = 1;
            btnOpenFile.Text = "Open";
            btnOpenFile.UseVisualStyleBackColor = true;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Gray;
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(dgvContactos);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(txtEmailSql);
            tabPage2.Controls.Add(txtPhoneSql);
            tabPage2.Controls.Add(txtNameSql);
            tabPage2.Controls.Add(btnDeleteSql);
            tabPage2.Controls.Add(btnUpdateSql);
            tabPage2.Controls.Add(btnInsert);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1026, 413);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Indexed Sequential Operations";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Narrow", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(55, 46);
            label8.Name = "label8";
            label8.Size = new Size(148, 46);
            label8.TabIndex = 29;
            label8.Text = "Contacts";
            // 
            // dgvContactos
            // 
            dgvContactos.AllowUserToAddRows = false;
            dgvContactos.AllowUserToResizeColumns = false;
            dgvContactos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvContactos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContactos.Columns.AddRange(new DataGridViewColumn[] { ID, NName, PPhone, EEmail });
            dgvContactos.EnableHeadersVisualStyles = false;
            dgvContactos.Location = new Point(55, 95);
            dgvContactos.MultiSelect = false;
            dgvContactos.Name = "dgvContactos";
            dgvContactos.ReadOnly = true;
            dgvContactos.RowHeadersVisible = false;
            dgvContactos.RowHeadersWidth = 51;
            dgvContactos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvContactos.Size = new Size(567, 253);
            dgvContactos.StandardTab = true;
            dgvContactos.TabIndex = 28;
            dgvContactos.MouseClick += dgvContacts_MouseClick;
            dgvContactos.MouseDoubleClick += dgvContacts_MouseDoubleClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 12F);
            label5.Location = new Point(704, 190);
            label5.Name = "label5";
            label5.Size = new Size(51, 24);
            label5.TabIndex = 27;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 12F);
            label6.Location = new Point(698, 146);
            label6.Name = "label6";
            label6.Size = new Size(57, 24);
            label6.TabIndex = 26;
            label6.Text = "Phone";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Narrow", 12F);
            label7.Location = new Point(700, 98);
            label7.Name = "label7";
            label7.Size = new Size(55, 24);
            label7.TabIndex = 25;
            label7.Text = "Name";
            // 
            // txtEmailSql
            // 
            txtEmailSql.Location = new Point(761, 190);
            txtEmailSql.Name = "txtEmailSql";
            txtEmailSql.Size = new Size(202, 27);
            txtEmailSql.TabIndex = 23;
            // 
            // txtPhoneSql
            // 
            txtPhoneSql.Location = new Point(761, 143);
            txtPhoneSql.Name = "txtPhoneSql";
            txtPhoneSql.Size = new Size(202, 27);
            txtPhoneSql.TabIndex = 22;
            // 
            // txtNameSql
            // 
            txtNameSql.Location = new Point(761, 95);
            txtNameSql.Name = "txtNameSql";
            txtNameSql.Size = new Size(202, 27);
            txtNameSql.TabIndex = 21;
            // 
            // btnDeleteSql
            // 
            btnDeleteSql.Font = new Font("Arial Narrow", 10.8F);
            btnDeleteSql.Location = new Point(696, 301);
            btnDeleteSql.Name = "btnDeleteSql";
            btnDeleteSql.Size = new Size(136, 46);
            btnDeleteSql.TabIndex = 19;
            btnDeleteSql.Text = "Delete";
            btnDeleteSql.UseVisualStyleBackColor = true;
            btnDeleteSql.Click += btnDeleteSql_Click;
            // 
            // btnUpdateSql
            // 
            btnUpdateSql.Font = new Font("Arial Narrow", 10.8F);
            btnUpdateSql.Location = new Point(838, 301);
            btnUpdateSql.Name = "btnUpdateSql";
            btnUpdateSql.Size = new Size(125, 46);
            btnUpdateSql.TabIndex = 17;
            btnUpdateSql.Text = "Update";
            btnUpdateSql.UseVisualStyleBackColor = true;
            btnUpdateSql.Click += btnUpdateSql_Click;
            // 
            // btnInsert
            // 
            btnInsert.Font = new Font("Arial Narrow", 10.8F);
            btnInsert.Location = new Point(696, 249);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(267, 46);
            btnInsert.TabIndex = 15;
            btnInsert.Text = "Add";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.Gray;
            tabPage3.Controls.Add(btnUpdate);
            tabPage3.Controls.Add(label14);
            tabPage3.Controls.Add(txtNameDA);
            tabPage3.Controls.Add(cbDepartamentDA);
            tabPage3.Controls.Add(button2);
            tabPage3.Controls.Add(label11);
            tabPage3.Controls.Add(label13);
            tabPage3.Controls.Add(button3);
            tabPage3.Controls.Add(txtID);
            tabPage3.Controls.Add(button4);
            tabPage3.Controls.Add(dgvEmpTabl);
            tabPage3.Controls.Add(label10);
            tabPage3.Controls.Add(btnOpenDA);
            tabPage3.ForeColor = Color.Black;
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1026, 413);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Direct Access";
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Arial Narrow", 10.8F);
            btnUpdate.Location = new Point(334, 335);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(160, 46);
            btnUpdate.TabIndex = 32;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial Narrow", 12F);
            label14.Location = new Point(654, 149);
            label14.Name = "label14";
            label14.Size = new Size(55, 24);
            label14.TabIndex = 31;
            label14.Text = "Name";
            // 
            // txtNameDA
            // 
            txtNameDA.Location = new Point(715, 146);
            txtNameDA.Name = "txtNameDA";
            txtNameDA.Size = new Size(205, 27);
            txtNameDA.TabIndex = 30;
            // 
            // cbDepartamentDA
            // 
            cbDepartamentDA.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDepartamentDA.FormattingEnabled = true;
            cbDepartamentDA.Items.AddRange(new object[] { "Office", "Library", "Servers", "Administration" });
            cbDepartamentDA.Location = new Point(715, 189);
            cbDepartamentDA.Name = "cbDepartamentDA";
            cbDepartamentDA.Size = new Size(205, 28);
            cbDepartamentDA.TabIndex = 29;
            // 
            // button2
            // 
            button2.Font = new Font("Arial Narrow", 10.8F);
            button2.Location = new Point(760, 299);
            button2.Name = "button2";
            button2.Size = new Size(160, 46);
            button2.TabIndex = 28;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Narrow", 12F);
            label11.Location = new Point(599, 193);
            label11.Name = "label11";
            label11.Size = new Size(106, 24);
            label11.TabIndex = 27;
            label11.Text = "Departament";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial Narrow", 12F);
            label13.Location = new Point(682, 103);
            label13.Name = "label13";
            label13.Size = new Size(27, 24);
            label13.TabIndex = 25;
            label13.Text = "ID";
            // 
            // button3
            // 
            button3.Font = new Font("Arial Narrow", 10.8F);
            button3.Location = new Point(594, 299);
            button3.Name = "button3";
            button3.Size = new Size(160, 46);
            button3.TabIndex = 24;
            button3.Text = "Search";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(715, 100);
            txtID.Name = "txtID";
            txtID.Size = new Size(205, 27);
            txtID.TabIndex = 22;
            // 
            // button4
            // 
            button4.Font = new Font("Arial Narrow", 10.8F);
            button4.Location = new Point(594, 247);
            button4.Name = "button4";
            button4.Size = new Size(326, 46);
            button4.TabIndex = 21;
            button4.Text = "Save";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // dgvEmpTabl
            // 
            dgvEmpTabl.AllowUserToAddRows = false;
            dgvEmpTabl.AllowUserToResizeColumns = false;
            dgvEmpTabl.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgvEmpTabl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpTabl.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column5 });
            dgvEmpTabl.EnableHeadersVisualStyles = false;
            dgvEmpTabl.Location = new Point(115, 103);
            dgvEmpTabl.MultiSelect = false;
            dgvEmpTabl.Name = "dgvEmpTabl";
            dgvEmpTabl.ReadOnly = true;
            dgvEmpTabl.RowHeadersVisible = false;
            dgvEmpTabl.RowHeadersWidth = 51;
            dgvEmpTabl.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpTabl.Size = new Size(379, 215);
            dgvEmpTabl.StandardTab = true;
            dgvEmpTabl.TabIndex = 20;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "NAME";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "DEPARTAMENT";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 125;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Narrow", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(115, 40);
            label10.Name = "label10";
            label10.Size = new Size(333, 46);
            label10.TabIndex = 19;
            label10.Text = "Employee registration";
            // 
            // btnOpenDA
            // 
            btnOpenDA.Font = new Font("Arial Narrow", 10.8F);
            btnOpenDA.Location = new Point(115, 335);
            btnOpenDA.Name = "btnOpenDA";
            btnOpenDA.Size = new Size(160, 45);
            btnOpenDA.TabIndex = 18;
            btnOpenDA.Text = "Open";
            btnOpenDA.UseVisualStyleBackColor = true;
            btnOpenDA.Click += btnOpenDA_Click;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 125;
            // 
            // NName
            // 
            NName.HeaderText = "Name";
            NName.MinimumWidth = 6;
            NName.Name = "NName";
            NName.ReadOnly = true;
            NName.Width = 125;
            // 
            // PPhone
            // 
            PPhone.HeaderText = "Phone";
            PPhone.MinimumWidth = 6;
            PPhone.Name = "PPhone";
            PPhone.ReadOnly = true;
            PPhone.Width = 125;
            // 
            // EEmail
            // 
            EEmail.HeaderText = "Email";
            EEmail.MinimumWidth = 6;
            EEmail.Name = "EEmail";
            EEmail.ReadOnly = true;
            EEmail.Width = 125;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 439);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployeeTable).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvContactos).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpTabl).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnOpenFile;
        private Button btnSave;
        private TextBox txtAge;
        private TextBox txtSecondName;
        private TextBox txtName;
        private Button btnSearch;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnDelete;
        private Button btnDeleteSql;
        private Button btnUpdateSql;
        private Button btnInsert;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtEmailSql;
        private TextBox txtPhoneSql;
        private TextBox txtNameSql;
        private Label label9;
        private ComboBox cbDepartament;
        private DataGridView dgvEmployeeTable;
        private DataGridView dgvContactos;
        private Label label8;
        private TabPage tabPage3;
        private DataGridView dgvEmpTabl;
        private Label label10;
        private Button btnOpenDA;
        private Label label14;
        private TextBox txtNameDA;
        private ComboBox cbDepartamentDA;
        private Button button2;
        private Label label11;
        private Label label12;
        private Label label13;
        private Button button3;
        private TextBox txtAgeDA;
        private TextBox txtID;
        private Button button4;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column5;
        private Button btnUpdate;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NName;
        private DataGridViewTextBoxColumn PPhone;
        private DataGridViewTextBoxColumn EEmail;
    }
}
