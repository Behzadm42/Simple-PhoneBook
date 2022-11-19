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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int counter;
        private void Form1_Load(object sender, EventArgs e)
        {
            counter = 0;
            BLPhonebook blp = new BLPhonebook();
            var z= blp.read();
            foreach (var item in z)
            {
                counter++;
            }
            textBox4.Text = counter.ToString();
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Hide();

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide();
        }
        /// <summary>
        ///  all Variable
        /// </summary>
        public static bool b = false;
        public static int id = 0;
        private void buttonX1_Click(object sender, EventArgs e)
        {
            Phonebook ph = new Phonebook();
            ph.name = textBox1.Text;
            ph.number = maskedTextBox1.Text;
            ph.address = textBox3.Text;
            ph.note = richTextBox1.Text;
    
            if (ph.name.Trim().Length==0)
            {
                MessageBox.Show("لطفا نام و نام خانوادگی رو وارد کنید ");
                textBox1.Focus();
            }
            else if (ph.number.Trim().Length != 11)
            {
                MessageBox.Show("لطفا شماره تلفن را وارد کنید ");
                maskedTextBox1.Focus();
                
            }
            else if (ph.address.Trim().Length == 0)
            {
                MessageBox.Show("لطفا آدرس را وارد کنید ");
                textBox3.Focus();
            }
            else
            {
                BLPhonebook blp = new BLPhonebook();
                //--------------

                if (b == false)
                {
                    #region aaa

                    DialogResult d = new DialogResult();
                    if (blp.exist(ph) != true)
                    {
                        d = MessageBox.Show("مشخصات این فرد در بانک اطلاعاتی موجود نیست \nآیا مایل به ثبت اطلاعات هستید ", "تاییده", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                        if (d == DialogResult.OK)
                        {
                            if (blp.insert(ph))
                            {
                                MessageBox.Show("مشخصات این فرد در بانک اطلاعاتی ثبت شد. ");
                                counter++;
                                textBox4.Text = counter.ToString();
                               
                            }
                            else
                                MessageBox.Show("ثیت نشد");
                           
                        }
                    }
                    else
                        MessageBox.Show("مشخصات این فرد در بانک اطلاعاتی موجود میباشد ");
                    #endregion
                }
                else
                {
                  
                      blp.update(id, ph);
                    b = false;
                    buttonX1.Text = "اضافه کردن";

                }






                //-----------------

                //if (blp.insert(ph))
                //{
                //    MessageBox.Show("ثیت شد");
                //    counter++;
                //    textBox4.Text = counter.ToString();
                //}
                //else
                //    MessageBox.Show("ثیت نشد");
            }

        }


        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void maskedTextBox1_Enter(object sender, EventArgs e)
        {
            maskedTextBox1.Clear();
            maskedTextBox1.Focus();
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
         
            foreach (var item in Controls)
            {
                if ( item.GetType().ToString() == "System.Windows.Forms.RichTextBox")
                {
                    
                    (item as RichTextBox).Clear();
                }
            }
            foreach (var item in Controls)
            {
                if ( item.GetType().ToString() == "System.Windows.Forms.MaskedTextBox")
                {
                    
                    (item as MaskedTextBox).Clear();
                   
                }
            }
            foreach (var item in Controls)
            {
                if (item.GetType().ToString() == "System.Windows.Forms.TextBox")
                {
                    (item as TextBox).Clear();

                }
            }


        }


    }
}
