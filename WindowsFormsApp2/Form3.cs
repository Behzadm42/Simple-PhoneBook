using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE_Phonebook;
using BL_Phonebook;

namespace WindowsFormsApp2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ((Form1)Application.OpenForms["Form1"]).Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BLPhonebook blp = new BLPhonebook();
            var q = blp.read(textBox1.Text);
            if (textBox1.Text == "")
                MessageBox.Show("اطلاعاتی وارد نشده");

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = q;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //BLPhonebook blp = new BLPhonebook();
            //var q = blp.read(textBox1.Text);
            //dataGridView1.DataSource = null;
            //dataGridView1.DataSource = q;
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            BLPhonebook blp = new BLPhonebook();
            var q = blp.read(textBox1.Text);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = q;
        }
    }
}
