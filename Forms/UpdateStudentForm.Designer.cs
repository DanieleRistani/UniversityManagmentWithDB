namespace UniversityManagerWithDB.Forms
{
    partial class UpdateStudentForm
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.universityDBDataSet = new UniversityManagerWithDB.UniversityDBDataSet();
            this.universityDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.universityDBDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.facultiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facultiesTableAdapter = new UniversityManagerWithDB.UniversityDBDataSetTableAdapters.FacultiesTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Maschio = new System.Windows.Forms.RadioButton();
            this.Femmina = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.universityDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityDBDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 126);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(201, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(201, 127);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 20);
            this.textBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Campo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Valore corrente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nuovo valore";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Matricola";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 74);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(150, 20);
            this.textBox3.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(254, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 58);
            this.button1.TabIndex = 9;
            this.button1.Text = "MODIFICA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 58);
            this.button2.TabIndex = 10;
            this.button2.Text = "RESET";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(133, 264);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 58);
            this.button3.TabIndex = 11;
            this.button3.Text = "SELEZIONA STUDENTE";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.Click += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "MODIFICA STUDENTE";
            // 
            // universityDBDataSet
            // 
            this.universityDBDataSet.DataSetName = "UniversityDBDataSet";
            this.universityDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // universityDBDataSetBindingSource
            // 
            this.universityDBDataSetBindingSource.DataSource = this.universityDBDataSet;
            this.universityDBDataSetBindingSource.Position = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.facultiesBindingSource, "faculty_id", true));
            this.comboBox2.DataSource = this.facultiesBindingSource;
            this.comboBox2.DisplayMember = "faculty_name";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 190);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(150, 21);
            this.comboBox2.TabIndex = 13;
            this.comboBox2.ValueMember = "faculty_id";
            // 
            // universityDBDataSetBindingSource1
            // 
            this.universityDBDataSetBindingSource1.DataSource = this.universityDBDataSet;
            this.universityDBDataSetBindingSource1.Position = 0;
            // 
            // facultiesBindingSource
            // 
            this.facultiesBindingSource.DataMember = "Faculties";
            this.facultiesBindingSource.DataSource = this.universityDBDataSetBindingSource;
            // 
            // facultiesTableAdapter
            // 
            this.facultiesTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Facoltà";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(260, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Sesso";
            // 
            // Maschio
            // 
            this.Maschio.AutoSize = true;
            this.Maschio.Location = new System.Drawing.Point(241, 190);
            this.Maschio.Name = "Maschio";
            this.Maschio.Size = new System.Drawing.Size(65, 17);
            this.Maschio.TabIndex = 17;
            this.Maschio.TabStop = true;
            this.Maschio.Text = "Maschio";
            this.Maschio.UseVisualStyleBackColor = true;
            // 
            // Femmina
            // 
            this.Femmina.AutoSize = true;
            this.Femmina.Location = new System.Drawing.Point(241, 214);
            this.Femmina.Name = "Femmina";
            this.Femmina.Size = new System.Drawing.Size(67, 17);
            this.Femmina.TabIndex = 18;
            this.Femmina.TabStop = true;
            this.Femmina.Text = "Femmina";
            this.Femmina.UseVisualStyleBackColor = true;
            // 
            // UpdateStudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 334);
            this.Controls.Add(this.Femmina);
            this.Controls.Add(this.Maschio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Name = "UpdateStudentForm";
            this.Text = "UpdateStudentForm";
            this.Load += new System.EventHandler(this.UpdateStudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.universityDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.universityDBDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultiesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource universityDBDataSetBindingSource;
        private UniversityDBDataSet universityDBDataSet;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource universityDBDataSetBindingSource1;
        private System.Windows.Forms.BindingSource facultiesBindingSource;
        private UniversityDBDataSetTableAdapters.FacultiesTableAdapter facultiesTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton Maschio;
        private System.Windows.Forms.RadioButton Femmina;
    }
}