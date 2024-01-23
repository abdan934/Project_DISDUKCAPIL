using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Form_Projek_Akhir.model;

namespace Form_Projek_Akhir.View
{
    public partial class Form1 : Form
    {
        USER USER = new USER();

        public Form1()
        {
            InitializeComponent();
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah akan keluar dari sistem..?",
            "KONFIRMASI",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }            

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            panel3.BackColor = Color.White;
            panel4.BackColor = SystemColors.Control;
            textBox2.BackColor = SystemColors.Control;
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
            panel4.BackColor = Color.White;
            textBox1.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (USER.login(textBox1.Text,textBox2.Text))
            {
                MenuUtama menu = new MenuUtama(USER.tampilusernamebyUser(textBox1.Text)) ;
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Maaf, Username/Password salah." + "\nSilahkan koreksi kembali.", "KESALAHAN",
               MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                textBox1.Focus();
                //MenuUtama menu = new MenuUtama() ;
                //menu.Show();
                //this.Hide();

                //LoginForm login = new LoginForm();
                //login.Show(); 
                //Close();
                //masukkin di tombol logout? biar balik ke login
                //masukkin juga di tombol close bagian transaksi biar balik ke home

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Refresh();
            textBox1.Focus();
        }








    }
}
