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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        int id = 0;
        private void buttonX1_Click(object sender, EventArgs e)
        {
            ((Form1)Application.OpenForms["Form1"]).Show();
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            BLPhonebook blp = new BLPhonebook();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = blp.read();
        }

        private void آپدیتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                BLPhonebook blp = new BLPhonebook();
                Phonebook ph1 = new Phonebook();

                ph1 = blp.read(id);

                ((Form1)Application.OpenForms["Form1"]).textBox1.Text = ph1.name;
                ((Form1)Application.OpenForms["Form1"]).maskedTextBox1.Text = ph1.number;
                ((Form1)Application.OpenForms["Form1"]).textBox3.Text = ph1.address;
                ((Form1)Application.OpenForms["Form1"]).richTextBox1.Text = ph1.note;
                Form1.b = true;
                Form1.id = id;

                ((Form1)Application.OpenForms["Form1"]).buttonX1.Text = "بروزرسانی ";
                ((Form1)Application.OpenForms["Form1"]).Show();
                this.Close();
            }
            else
                MessageBox.Show("هیچ سطری انتخاب نشده");
        }

        private void حذفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BLPhonebook blp = new BLPhonebook();
            if (id != 0)
            {
                blp.delete3(id);
                MessageBox.Show("حذف");
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = blp.read();
            }
            else
                MessageBox.Show("هیچ سطری انتخاب نشده");
            id = 0;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //string s1 = (dataGridView1.Rows[e.RowIndex].Cells[0].Value).ToString();
            //string s2 = (dataGridView1.Rows[e.RowIndex].Cells[1].Value).ToString();
            //id = hu.read1(s1, s2);
            id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);

        }
    }
}
