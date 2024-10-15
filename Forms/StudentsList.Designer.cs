namespace UniversityManagerWithDB.Forms
{
    partial class StudentsList
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentmatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentsurnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentgenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentdateofenrollmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentfacultyidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.universityDBDataSet = new UniversityManagerWithDB.UniversityDBDataSet();
            this.studentsTableAdapter = new UniversityManagerWithDB.UniversityDBDataSetTableAdapters.StudentsTableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.matricolaToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.matricolaToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityDBDataSet)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentidDataGridViewTextBoxColumn,
            this.studentmatDataGridViewTextBoxColumn,
            this.studentnameDataGridViewTextBoxColumn,
            this.studentsurnameDataGridViewTextBoxColumn,
            this.studentageDataGridViewTextBoxColumn,
            this.studentgenderDataGridViewTextBoxColumn,
            this.studentdateofenrollmentDataGridViewTextBoxColumn,
            this.studentfacultyidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(851, 315);
            this.dataGridView1.TabIndex = 0;
            // 
            // studentidDataGridViewTextBoxColumn
            // 
            this.studentidDataGridViewTextBoxColumn.DataPropertyName = "student_id";
            this.studentidDataGridViewTextBoxColumn.HeaderText = "student_id";
            this.studentidDataGridViewTextBoxColumn.Name = "studentidDataGridViewTextBoxColumn";
            this.studentidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentmatDataGridViewTextBoxColumn
            // 
            this.studentmatDataGridViewTextBoxColumn.DataPropertyName = "student_mat";
            this.studentmatDataGridViewTextBoxColumn.HeaderText = "student_mat";
            this.studentmatDataGridViewTextBoxColumn.Name = "studentmatDataGridViewTextBoxColumn";
            this.studentmatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentnameDataGridViewTextBoxColumn
            // 
            this.studentnameDataGridViewTextBoxColumn.DataPropertyName = "student_name";
            this.studentnameDataGridViewTextBoxColumn.HeaderText = "student_name";
            this.studentnameDataGridViewTextBoxColumn.Name = "studentnameDataGridViewTextBoxColumn";
            this.studentnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentsurnameDataGridViewTextBoxColumn
            // 
            this.studentsurnameDataGridViewTextBoxColumn.DataPropertyName = "student_surname";
            this.studentsurnameDataGridViewTextBoxColumn.HeaderText = "student_surname";
            this.studentsurnameDataGridViewTextBoxColumn.Name = "studentsurnameDataGridViewTextBoxColumn";
            this.studentsurnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentageDataGridViewTextBoxColumn
            // 
            this.studentageDataGridViewTextBoxColumn.DataPropertyName = "student_age";
            this.studentageDataGridViewTextBoxColumn.HeaderText = "student_age";
            this.studentageDataGridViewTextBoxColumn.Name = "studentageDataGridViewTextBoxColumn";
            this.studentageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentgenderDataGridViewTextBoxColumn
            // 
            this.studentgenderDataGridViewTextBoxColumn.DataPropertyName = "student_gender";
            this.studentgenderDataGridViewTextBoxColumn.HeaderText = "student_gender";
            this.studentgenderDataGridViewTextBoxColumn.Name = "studentgenderDataGridViewTextBoxColumn";
            this.studentgenderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentdateofenrollmentDataGridViewTextBoxColumn
            // 
            this.studentdateofenrollmentDataGridViewTextBoxColumn.DataPropertyName = "student_date_of_enrollment";
            this.studentdateofenrollmentDataGridViewTextBoxColumn.HeaderText = "student_date_of_enrollment";
            this.studentdateofenrollmentDataGridViewTextBoxColumn.Name = "studentdateofenrollmentDataGridViewTextBoxColumn";
            this.studentdateofenrollmentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentfacultyidDataGridViewTextBoxColumn
            // 
            this.studentfacultyidDataGridViewTextBoxColumn.DataPropertyName = "student_faculty_id";
            this.studentfacultyidDataGridViewTextBoxColumn.HeaderText = "student_faculty_id";
            this.studentfacultyidDataGridViewTextBoxColumn.Name = "studentfacultyidDataGridViewTextBoxColumn";
            this.studentfacultyidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentsBindingSource
            // 
            this.studentsBindingSource.DataMember = "Students";
            this.studentsBindingSource.DataSource = this.universityDBDataSet;
            // 
            // universityDBDataSet
            // 
            this.universityDBDataSet.DataSetName = "UniversityDBDataSet";
            this.universityDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matricolaToolStripLabel,
            this.matricolaToolStripTextBox,
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(883, 25);
            this.fillByToolStrip.TabIndex = 1;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // matricolaToolStripLabel
            // 
            this.matricolaToolStripLabel.Name = "matricolaToolStripLabel";
            this.matricolaToolStripLabel.Size = new System.Drawing.Size(60, 22);
            this.matricolaToolStripLabel.Text = "Matricola:";
            // 
            // matricolaToolStripTextBox
            // 
            this.matricolaToolStripTextBox.Name = "matricolaToolStripTextBox";
            this.matricolaToolStripTextBox.Size = new System.Drawing.Size(100, 23);
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 19);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click_2);
            // 
            // StudentsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 450);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Name = "StudentsList";
            this.Text = "StudentsList";
            this.Load += new System.EventHandler(this.StudentsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityDBDataSet)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private UniversityDBDataSet universityDBDataSet;
        private System.Windows.Forms.BindingSource studentsBindingSource;
        private UniversityDBDataSetTableAdapters.StudentsTableAdapter studentsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentmatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentsurnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentgenderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentdateofenrollmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentfacultyidDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripLabel matricolaToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox matricolaToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
    }
}