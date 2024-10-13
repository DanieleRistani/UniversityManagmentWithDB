using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityManagerWithDB.Forms
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: questa riga di codice carica i dati nella tabella 'universityDBDataSet.Faculties'. È possibile spostarla o rimuoverla se necessario.
            this.facultiesTableAdapter.Fill(this.universityDBDataSet.Faculties);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string value= textBox1.Text;
            string value2= textBox2.Text;
            string value3 = textBox3.Text;
            string value4 = textBox4.Text;
            string value5 = textBox5.Text;

            string value6 = radioButton1.Text;
            string value7 = radioButton2.Text;

            string value8 = comboBox1.Text;

            int value9 = comboBox1.SelectedIndex+1;

            MessageBox.Show(radioButton1.Checked ?$"{value6}": $"{value7}");
            MessageBox.Show($"{value}|{value2}|{value3}|{value4}|{value5}|{value8}|{value9}");
           


        }


        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.facultiesTableAdapter.FillBy(this.universityDBDataSet.Faculties);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
