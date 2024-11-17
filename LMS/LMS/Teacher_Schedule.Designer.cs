namespace LMS
{
    partial class Teacher_Schedule
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
            this.lMSDataSet1 = new LMS.LMSDataSet1();
            this.registrationRequestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registration_RequestsTableAdapter = new LMS.LMSDataSet1TableAdapters.Registration_RequestsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.lMSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationRequestsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1010, 356);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 109;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lMSDataSet1
            // 
            this.lMSDataSet1.DataSetName = "LMSDataSet1";
            this.lMSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registrationRequestsBindingSource
            // 
            this.registrationRequestsBindingSource.DataMember = "Registration_Requests";
            this.registrationRequestsBindingSource.DataSource = this.lMSDataSet1;
            // 
            // registration_RequestsTableAdapter
            // 
            this.registration_RequestsTableAdapter.ClearBeforeFill = true;
            // 
            // Teacher_Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 409);
            this.Controls.Add(this.button3);
            this.Name = "Teacher_Schedule";
            this.Text = "Teacher_Schedule";
            this.Load += new System.EventHandler(this.Teacher_Schedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lMSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registrationRequestsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private LMSDataSet1 lMSDataSet1;
        private System.Windows.Forms.BindingSource registrationRequestsBindingSource;
        private LMSDataSet1TableAdapters.Registration_RequestsTableAdapter registration_RequestsTableAdapter;
    }
}