namespace LMS
{
    partial class Admin_Requests
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
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ID = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.registrationRequestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lMSDataSet = new LMS.LMSDataSet();
            this.registration_RequestsTableAdapter = new LMS.LMSDataSetTableAdapters.Registration_RequestsTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lMSDataSet2 = new LMS.LMSDataSet2();
            this.registrationRequestsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.registration_RequestsTableAdapter1 = new LMS.LMSDataSet2TableAdapters.Registration_RequestsTableAdapter();
            this.lMSDataSet1 = new LMS.LMSDataSet1();
            this.lMSDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registrationRequestsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.registrationRequestsBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.registration_RequestsTableAdapter2 = new LMS.LMSDataSet1TableAdapters.Registration_RequestsTableAdapter();
            this.registrationRequestsBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lMSDataSet4 = new LMS.LMSDataSet4();
            this.registrationRequestsBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.registration_RequestsTableAdapter3 = new LMS.LMSDataSet4TableAdapters.Registration_RequestsTableAdapter();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.registrationRequestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lMSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lMSDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationRequestsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lMSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lMSDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationRequestsBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationRequestsBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationRequestsBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lMSDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationRequestsBindingSource5)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(309, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 108;
            this.button1.Text = "Proceed";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(309, 255);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 107;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(24, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 22);
            this.label1.TabIndex = 106;
            this.label1.Text = "Requests";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label4.Location = new System.Drawing.Point(97, 182);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 22);
            this.label4.TabIndex = 104;
            this.label4.Text = "Account Status";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Pending",
            "Approved",
            "Reject"});
            this.comboBox1.Location = new System.Drawing.Point(279, 186);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 103;
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ID.Location = new System.Drawing.Point(101, 67);
            this.ID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ID.Name = "ID";
            this.ID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ID.Size = new System.Drawing.Size(92, 22);
            this.ID.TabIndex = 100;
            this.ID.Text = "Username";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(279, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 99;
            // 
            // registrationRequestsBindingSource
            // 
            this.registrationRequestsBindingSource.DataMember = "Registration_Requests";
            this.registrationRequestsBindingSource.DataSource = this.lMSDataSet;
            // 
            // lMSDataSet
            // 
            this.lMSDataSet.DataSetName = "LMSDataSet";
            this.lMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registration_RequestsTableAdapter
            // 
            this.registration_RequestsTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Location = new System.Drawing.Point(101, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 111;
            this.label2.Text = "Password";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(279, 106);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 110;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label3.Location = new System.Drawing.Point(101, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(121, 22);
            this.label3.TabIndex = 113;
            this.label3.Text = "Account Type";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(279, 146);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 112;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(204, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 114;
            this.button2.Text = "Next";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(204, 255);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 115;
            this.button4.Text = "Previous";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lMSDataSet2
            // 
            this.lMSDataSet2.DataSetName = "LMSDataSet2";
            this.lMSDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registrationRequestsBindingSource1
            // 
            this.registrationRequestsBindingSource1.DataMember = "Registration_Requests";
            this.registrationRequestsBindingSource1.DataSource = this.lMSDataSet2;
            // 
            // registration_RequestsTableAdapter1
            // 
            this.registration_RequestsTableAdapter1.ClearBeforeFill = true;
            // 
            // lMSDataSet1
            // 
            this.lMSDataSet1.DataSetName = "LMSDataSet1";
            this.lMSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lMSDataSet1BindingSource
            // 
            this.lMSDataSet1BindingSource.DataSource = this.lMSDataSet1;
            this.lMSDataSet1BindingSource.Position = 0;
            // 
            // registrationRequestsBindingSource2
            // 
            this.registrationRequestsBindingSource2.DataMember = "Registration_Requests";
            this.registrationRequestsBindingSource2.DataSource = this.lMSDataSet;
            // 
            // registrationRequestsBindingSource3
            // 
            this.registrationRequestsBindingSource3.DataMember = "Registration_Requests";
            this.registrationRequestsBindingSource3.DataSource = this.lMSDataSet1;
            // 
            // registration_RequestsTableAdapter2
            // 
            this.registration_RequestsTableAdapter2.ClearBeforeFill = true;
            // 
            // registrationRequestsBindingSource4
            // 
            this.registrationRequestsBindingSource4.DataMember = "Registration_Requests";
            this.registrationRequestsBindingSource4.DataSource = this.lMSDataSet2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.registrationRequestsBindingSource5;
            this.dataGridView1.Location = new System.Drawing.Point(12, 298);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(379, 150);
            this.dataGridView1.TabIndex = 116;
            // 
            // lMSDataSet4
            // 
            this.lMSDataSet4.DataSetName = "LMSDataSet4";
            this.lMSDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registrationRequestsBindingSource5
            // 
            this.registrationRequestsBindingSource5.DataMember = "Registration_Requests";
            this.registrationRequestsBindingSource5.DataSource = this.lMSDataSet4;
            // 
            // registration_RequestsTableAdapter3
            // 
            this.registration_RequestsTableAdapter3.ClearBeforeFill = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // Admin_Requests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 460);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.textBox1);
            this.Name = "Admin_Requests";
            this.Text = "Admin_Requests";
            this.Load += new System.EventHandler(this.Admin_Requests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registrationRequestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lMSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lMSDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationRequestsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lMSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lMSDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationRequestsBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationRequestsBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationRequestsBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lMSDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationRequestsBindingSource5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox textBox1;
        private LMSDataSet lMSDataSet;
        private System.Windows.Forms.BindingSource registrationRequestsBindingSource;
        private LMSDataSetTableAdapters.Registration_RequestsTableAdapter registration_RequestsTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private LMSDataSet2 lMSDataSet2;
        private System.Windows.Forms.BindingSource registrationRequestsBindingSource1;
        private LMSDataSet2TableAdapters.Registration_RequestsTableAdapter registration_RequestsTableAdapter1;
        private LMSDataSet1 lMSDataSet1;
        private System.Windows.Forms.BindingSource lMSDataSet1BindingSource;
        private System.Windows.Forms.BindingSource registrationRequestsBindingSource2;
        private System.Windows.Forms.BindingSource registrationRequestsBindingSource3;
        private LMSDataSet1TableAdapters.Registration_RequestsTableAdapter registration_RequestsTableAdapter2;
        private System.Windows.Forms.BindingSource registrationRequestsBindingSource4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private LMSDataSet4 lMSDataSet4;
        private System.Windows.Forms.BindingSource registrationRequestsBindingSource5;
        private LMSDataSet4TableAdapters.Registration_RequestsTableAdapter registration_RequestsTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
    }
}