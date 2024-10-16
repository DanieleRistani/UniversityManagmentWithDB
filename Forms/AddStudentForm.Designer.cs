﻿namespace UniversityManagerWithDB.Forms
{
    partial class AddStudentForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.facultiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.universityDBDataSet = new UniversityManagerWithDB.UniversityDBDataSet();
            this.facultiesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.universityDBDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.universityDBDataSet1 = new UniversityManagerWithDB.UniversityDBDataSet();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.facultiesTableAdapter = new UniversityManagerWithDB.UniversityDBDataSetTableAdapters.FacultiesTableAdapter();
            this.facultiesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.facultiesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.facultiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultiesBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityDBDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultiesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultiesBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricola";
           
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cognome";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Età";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data di Iscrizione";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sesso";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 360);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Facoltà";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(210, 454);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "Crea";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.facultiesBindingSource, "faculty_name", true));
            this.comboBox1.DataSource = this.facultiesBindingSource;
            this.comboBox1.DisplayMember = "faculty_name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 385);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(189, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.ValueMember = "faculty_id";
            // 
            // facultiesBindingSource
            // 
            this.facultiesBindingSource.DataMember = "Faculties";
            this.facultiesBindingSource.DataSource = this.universityDBDataSet;
            // 
            // universityDBDataSet
            // 
            this.universityDBDataSet.DataSetName = "UniversityDBDataSet";
            this.universityDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facultiesBindingSource3
            // 
            this.facultiesBindingSource3.DataMember = "Faculties";
            this.facultiesBindingSource3.DataSource = this.universityDBDataSet1BindingSource;
            // 
            // universityDBDataSet1BindingSource
            // 
            this.universityDBDataSet1BindingSource.DataSource = this.universityDBDataSet1;
            this.universityDBDataSet1BindingSource.Position = 0;
            // 
            // universityDBDataSet1
            // 
            this.universityDBDataSet1.DataSetName = "UniversityDBDataSet";
            this.universityDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(12, 305);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(67, 17);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Femmina";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(12, 328);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(65, 17);
            this.radioButton2.TabIndex = 11;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Maschio";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 20);
            this.textBox1.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 100);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(189, 20);
            this.textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 149);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(189, 20);
            this.textBox3.TabIndex = 14;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 197);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(189, 20);
            this.textBox4.TabIndex = 15;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(12, 247);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(189, 20);
            this.textBox5.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(89, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(144, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "INSERIMENTO STUDENTE";
            // 
            // facultiesTableAdapter
            // 
            this.facultiesTableAdapter.ClearBeforeFill = true;
            // 
            // facultiesBindingSource1
            // 
            this.facultiesBindingSource1.DataMember = "Faculties";
            this.facultiesBindingSource1.DataSource = this.universityDBDataSet1;
            // 
            // facultiesBindingSource2
            // 
            this.facultiesBindingSource2.DataMember = "Faculties";
            this.facultiesBindingSource2.DataSource = this.universityDBDataSet1BindingSource;
            // 
            // AddStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 511);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddStudentForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.facultiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultiesBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityDBDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultiesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultiesBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label8;
        private UniversityDBDataSet universityDBDataSet;
        private System.Windows.Forms.BindingSource facultiesBindingSource;
        private UniversityDBDataSetTableAdapters.FacultiesTableAdapter facultiesTableAdapter;
        private System.Windows.Forms.BindingSource universityDBDataSet1BindingSource;
        private UniversityDBDataSet universityDBDataSet1;
        private System.Windows.Forms.BindingSource facultiesBindingSource1;
        private System.Windows.Forms.BindingSource facultiesBindingSource2;
        private System.Windows.Forms.BindingSource facultiesBindingSource3;
    }
}