namespace LMS
{
    partial class Student_Result
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
            this.button3 = new System.Windows.Forms.Button();
            this.resultsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lMSDataSet7 = new LMS.LMSDataSet7();
            this.resultsTableAdapter = new LMS.LMSDataSet7TableAdapters.ResultsTableAdapter();
            this.resultsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lMSDataSet71 = new LMS.LMSDataSet7();
            this.registrationRequestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registration_RequestsTableAdapter = new LMS.LMSDataSet7TableAdapters.Registration_RequestsTableAdapter();
            this.resultsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rollNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hours1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marks1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hours2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marks2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hours3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marks3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hours4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marks4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hours5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marks5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade5DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hours6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marks6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grade6DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gPADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semesterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fillBy1ToolStrip = new System.Windows.Forms.ToolStrip();
            this.userToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.userToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillBy1ToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lMSDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lMSDataSet71)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationRequestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource2)).BeginInit();
            this.fillBy1ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(707, 361);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 110;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // resultsBindingSource
            // 
            this.resultsBindingSource.DataMember = "Results";
            this.resultsBindingSource.DataSource = this.lMSDataSet7;
            // 
            // lMSDataSet7
            // 
            this.lMSDataSet7.DataSetName = "LMSDataSet7";
            this.lMSDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // resultsTableAdapter
            // 
            this.resultsTableAdapter.ClearBeforeFill = true;
            // 
            // resultsBindingSource1
            // 
            this.resultsBindingSource1.DataMember = "Results";
            this.resultsBindingSource1.DataSource = this.lMSDataSet7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.rollNoDataGridViewTextBoxColumn,
            this.sessionDataGridViewTextBoxColumn,
            this.subject1DataGridViewTextBoxColumn,
            this.hours1DataGridViewTextBoxColumn,
            this.marks1DataGridViewTextBoxColumn,
            this.grade1DataGridViewTextBoxColumn,
            this.subject2DataGridViewTextBoxColumn,
            this.hours2DataGridViewTextBoxColumn,
            this.marks2DataGridViewTextBoxColumn,
            this.grade2DataGridViewTextBoxColumn,
            this.subject3DataGridViewTextBoxColumn,
            this.hours3DataGridViewTextBoxColumn,
            this.marks3DataGridViewTextBoxColumn,
            this.grade3DataGridViewTextBoxColumn,
            this.subject4DataGridViewTextBoxColumn,
            this.hours4DataGridViewTextBoxColumn,
            this.marks4DataGridViewTextBoxColumn,
            this.grade4DataGridViewTextBoxColumn,
            this.subject5DataGridViewTextBoxColumn,
            this.hours5DataGridViewTextBoxColumn,
            this.marks5DataGridViewTextBoxColumn,
            this.grade5DataGridViewTextBoxColumn,
            this.subject6DataGridViewTextBoxColumn,
            this.hours6DataGridViewTextBoxColumn,
            this.marks6DataGridViewTextBoxColumn,
            this.grade6DataGridViewTextBoxColumn,
            this.gPADataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.semesterDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.resultsBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(26, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(730, 150);
            this.dataGridView1.TabIndex = 111;
            // 
            // lMSDataSet71
            // 
            this.lMSDataSet71.DataSetName = "LMSDataSet7";
            this.lMSDataSet71.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registrationRequestsBindingSource
            // 
            this.registrationRequestsBindingSource.DataMember = "Registration_Requests";
            this.registrationRequestsBindingSource.DataSource = this.lMSDataSet71;
            // 
            // registration_RequestsTableAdapter
            // 
            this.registration_RequestsTableAdapter.ClearBeforeFill = true;
            // 
            // resultsBindingSource2
            // 
            this.resultsBindingSource2.DataMember = "Results";
            this.resultsBindingSource2.DataSource = this.lMSDataSet71;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // rollNoDataGridViewTextBoxColumn
            // 
            this.rollNoDataGridViewTextBoxColumn.DataPropertyName = "RollNo";
            this.rollNoDataGridViewTextBoxColumn.HeaderText = "RollNo";
            this.rollNoDataGridViewTextBoxColumn.Name = "rollNoDataGridViewTextBoxColumn";
            // 
            // sessionDataGridViewTextBoxColumn
            // 
            this.sessionDataGridViewTextBoxColumn.DataPropertyName = "Session";
            this.sessionDataGridViewTextBoxColumn.HeaderText = "Session";
            this.sessionDataGridViewTextBoxColumn.Name = "sessionDataGridViewTextBoxColumn";
            // 
            // subject1DataGridViewTextBoxColumn
            // 
            this.subject1DataGridViewTextBoxColumn.DataPropertyName = "Subject1";
            this.subject1DataGridViewTextBoxColumn.HeaderText = "Subject1";
            this.subject1DataGridViewTextBoxColumn.Name = "subject1DataGridViewTextBoxColumn";
            // 
            // hours1DataGridViewTextBoxColumn
            // 
            this.hours1DataGridViewTextBoxColumn.DataPropertyName = "Hours1";
            this.hours1DataGridViewTextBoxColumn.HeaderText = "Hours1";
            this.hours1DataGridViewTextBoxColumn.Name = "hours1DataGridViewTextBoxColumn";
            // 
            // marks1DataGridViewTextBoxColumn
            // 
            this.marks1DataGridViewTextBoxColumn.DataPropertyName = "Marks1";
            this.marks1DataGridViewTextBoxColumn.HeaderText = "Marks1";
            this.marks1DataGridViewTextBoxColumn.Name = "marks1DataGridViewTextBoxColumn";
            // 
            // grade1DataGridViewTextBoxColumn
            // 
            this.grade1DataGridViewTextBoxColumn.DataPropertyName = "Grade1";
            this.grade1DataGridViewTextBoxColumn.HeaderText = "Grade1";
            this.grade1DataGridViewTextBoxColumn.Name = "grade1DataGridViewTextBoxColumn";
            // 
            // subject2DataGridViewTextBoxColumn
            // 
            this.subject2DataGridViewTextBoxColumn.DataPropertyName = "Subject2";
            this.subject2DataGridViewTextBoxColumn.HeaderText = "Subject2";
            this.subject2DataGridViewTextBoxColumn.Name = "subject2DataGridViewTextBoxColumn";
            // 
            // hours2DataGridViewTextBoxColumn
            // 
            this.hours2DataGridViewTextBoxColumn.DataPropertyName = "Hours2";
            this.hours2DataGridViewTextBoxColumn.HeaderText = "Hours2";
            this.hours2DataGridViewTextBoxColumn.Name = "hours2DataGridViewTextBoxColumn";
            // 
            // marks2DataGridViewTextBoxColumn
            // 
            this.marks2DataGridViewTextBoxColumn.DataPropertyName = "Marks2";
            this.marks2DataGridViewTextBoxColumn.HeaderText = "Marks2";
            this.marks2DataGridViewTextBoxColumn.Name = "marks2DataGridViewTextBoxColumn";
            // 
            // grade2DataGridViewTextBoxColumn
            // 
            this.grade2DataGridViewTextBoxColumn.DataPropertyName = "Grade2";
            this.grade2DataGridViewTextBoxColumn.HeaderText = "Grade2";
            this.grade2DataGridViewTextBoxColumn.Name = "grade2DataGridViewTextBoxColumn";
            // 
            // subject3DataGridViewTextBoxColumn
            // 
            this.subject3DataGridViewTextBoxColumn.DataPropertyName = "Subject3";
            this.subject3DataGridViewTextBoxColumn.HeaderText = "Subject3";
            this.subject3DataGridViewTextBoxColumn.Name = "subject3DataGridViewTextBoxColumn";
            // 
            // hours3DataGridViewTextBoxColumn
            // 
            this.hours3DataGridViewTextBoxColumn.DataPropertyName = "Hours3";
            this.hours3DataGridViewTextBoxColumn.HeaderText = "Hours3";
            this.hours3DataGridViewTextBoxColumn.Name = "hours3DataGridViewTextBoxColumn";
            // 
            // marks3DataGridViewTextBoxColumn
            // 
            this.marks3DataGridViewTextBoxColumn.DataPropertyName = "Marks3";
            this.marks3DataGridViewTextBoxColumn.HeaderText = "Marks3";
            this.marks3DataGridViewTextBoxColumn.Name = "marks3DataGridViewTextBoxColumn";
            // 
            // grade3DataGridViewTextBoxColumn
            // 
            this.grade3DataGridViewTextBoxColumn.DataPropertyName = "Grade3";
            this.grade3DataGridViewTextBoxColumn.HeaderText = "Grade3";
            this.grade3DataGridViewTextBoxColumn.Name = "grade3DataGridViewTextBoxColumn";
            // 
            // subject4DataGridViewTextBoxColumn
            // 
            this.subject4DataGridViewTextBoxColumn.DataPropertyName = "Subject4";
            this.subject4DataGridViewTextBoxColumn.HeaderText = "Subject4";
            this.subject4DataGridViewTextBoxColumn.Name = "subject4DataGridViewTextBoxColumn";
            // 
            // hours4DataGridViewTextBoxColumn
            // 
            this.hours4DataGridViewTextBoxColumn.DataPropertyName = "Hours4";
            this.hours4DataGridViewTextBoxColumn.HeaderText = "Hours4";
            this.hours4DataGridViewTextBoxColumn.Name = "hours4DataGridViewTextBoxColumn";
            // 
            // marks4DataGridViewTextBoxColumn
            // 
            this.marks4DataGridViewTextBoxColumn.DataPropertyName = "Marks4";
            this.marks4DataGridViewTextBoxColumn.HeaderText = "Marks4";
            this.marks4DataGridViewTextBoxColumn.Name = "marks4DataGridViewTextBoxColumn";
            // 
            // grade4DataGridViewTextBoxColumn
            // 
            this.grade4DataGridViewTextBoxColumn.DataPropertyName = "Grade4";
            this.grade4DataGridViewTextBoxColumn.HeaderText = "Grade4";
            this.grade4DataGridViewTextBoxColumn.Name = "grade4DataGridViewTextBoxColumn";
            // 
            // subject5DataGridViewTextBoxColumn
            // 
            this.subject5DataGridViewTextBoxColumn.DataPropertyName = "Subject5";
            this.subject5DataGridViewTextBoxColumn.HeaderText = "Subject5";
            this.subject5DataGridViewTextBoxColumn.Name = "subject5DataGridViewTextBoxColumn";
            // 
            // hours5DataGridViewTextBoxColumn
            // 
            this.hours5DataGridViewTextBoxColumn.DataPropertyName = "Hours5";
            this.hours5DataGridViewTextBoxColumn.HeaderText = "Hours5";
            this.hours5DataGridViewTextBoxColumn.Name = "hours5DataGridViewTextBoxColumn";
            // 
            // marks5DataGridViewTextBoxColumn
            // 
            this.marks5DataGridViewTextBoxColumn.DataPropertyName = "Marks5";
            this.marks5DataGridViewTextBoxColumn.HeaderText = "Marks5";
            this.marks5DataGridViewTextBoxColumn.Name = "marks5DataGridViewTextBoxColumn";
            // 
            // grade5DataGridViewTextBoxColumn
            // 
            this.grade5DataGridViewTextBoxColumn.DataPropertyName = "Grade5";
            this.grade5DataGridViewTextBoxColumn.HeaderText = "Grade5";
            this.grade5DataGridViewTextBoxColumn.Name = "grade5DataGridViewTextBoxColumn";
            // 
            // subject6DataGridViewTextBoxColumn
            // 
            this.subject6DataGridViewTextBoxColumn.DataPropertyName = "Subject6";
            this.subject6DataGridViewTextBoxColumn.HeaderText = "Subject6";
            this.subject6DataGridViewTextBoxColumn.Name = "subject6DataGridViewTextBoxColumn";
            // 
            // hours6DataGridViewTextBoxColumn
            // 
            this.hours6DataGridViewTextBoxColumn.DataPropertyName = "Hours6";
            this.hours6DataGridViewTextBoxColumn.HeaderText = "Hours6";
            this.hours6DataGridViewTextBoxColumn.Name = "hours6DataGridViewTextBoxColumn";
            // 
            // marks6DataGridViewTextBoxColumn
            // 
            this.marks6DataGridViewTextBoxColumn.DataPropertyName = "Marks6";
            this.marks6DataGridViewTextBoxColumn.HeaderText = "Marks6";
            this.marks6DataGridViewTextBoxColumn.Name = "marks6DataGridViewTextBoxColumn";
            // 
            // grade6DataGridViewTextBoxColumn
            // 
            this.grade6DataGridViewTextBoxColumn.DataPropertyName = "Grade6";
            this.grade6DataGridViewTextBoxColumn.HeaderText = "Grade6";
            this.grade6DataGridViewTextBoxColumn.Name = "grade6DataGridViewTextBoxColumn";
            // 
            // gPADataGridViewTextBoxColumn
            // 
            this.gPADataGridViewTextBoxColumn.DataPropertyName = "GPA";
            this.gPADataGridViewTextBoxColumn.HeaderText = "GPA";
            this.gPADataGridViewTextBoxColumn.Name = "gPADataGridViewTextBoxColumn";
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "Department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Department";
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            // 
            // semesterDataGridViewTextBoxColumn
            // 
            this.semesterDataGridViewTextBoxColumn.DataPropertyName = "Semester";
            this.semesterDataGridViewTextBoxColumn.HeaderText = "Semester";
            this.semesterDataGridViewTextBoxColumn.Name = "semesterDataGridViewTextBoxColumn";
            // 
            // fillBy1ToolStrip
            // 
            this.fillBy1ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripLabel,
            this.userToolStripTextBox,
            this.fillBy1ToolStripButton});
            this.fillBy1ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillBy1ToolStrip.Name = "fillBy1ToolStrip";
            this.fillBy1ToolStrip.Size = new System.Drawing.Size(863, 25);
            this.fillBy1ToolStrip.TabIndex = 112;
            this.fillBy1ToolStrip.Text = "fillBy1ToolStrip";
            // 
            // userToolStripLabel
            // 
            this.userToolStripLabel.Name = "userToolStripLabel";
            this.userToolStripLabel.Size = new System.Drawing.Size(32, 22);
            this.userToolStripLabel.Text = "user:";
            // 
            // userToolStripTextBox
            // 
            this.userToolStripTextBox.Name = "userToolStripTextBox";
            this.userToolStripTextBox.Size = new System.Drawing.Size(100, 23);
            // 
            // fillBy1ToolStripButton
            // 
            this.fillBy1ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillBy1ToolStripButton.Name = "fillBy1ToolStripButton";
            this.fillBy1ToolStripButton.Size = new System.Drawing.Size(45, 19);
            this.fillBy1ToolStripButton.Text = "FillBy1";
            this.fillBy1ToolStripButton.Click += new System.EventHandler(this.fillBy1ToolStripButton_Click_1);
            // 
            // Student_Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 430);
            this.Controls.Add(this.fillBy1ToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Name = "Student_Result";
            this.Text = "Student_Result";
            this.Load += new System.EventHandler(this.Student_Result_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lMSDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lMSDataSet71)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationRequestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultsBindingSource2)).EndInit();
            this.fillBy1ToolStrip.ResumeLayout(false);
            this.fillBy1ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private LMSDataSet7 lMSDataSet7;
        private System.Windows.Forms.BindingSource resultsBindingSource;
        private LMSDataSet7TableAdapters.ResultsTableAdapter resultsTableAdapter;
        private System.Windows.Forms.BindingSource resultsBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private LMSDataSet7 lMSDataSet71;
        private System.Windows.Forms.BindingSource registrationRequestsBindingSource;
        private LMSDataSet7TableAdapters.Registration_RequestsTableAdapter registration_RequestsTableAdapter;
        private System.Windows.Forms.BindingSource resultsBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hours1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marks1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grade1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hours2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marks2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grade2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hours3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marks3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grade3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hours4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marks4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grade4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hours5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marks5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grade5DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hours6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marks6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grade6DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gPADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillBy1ToolStrip;
        private System.Windows.Forms.ToolStripLabel userToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox userToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillBy1ToolStripButton;
    }
}