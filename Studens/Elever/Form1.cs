using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elever
{
    public partial class Form1 : Form
    {
        Anslutning af;
        DataCenter UP;
        ElevApp EA;
        bool CHECK;
        public Form1()
        {
            InitializeComponent();
            UP = new DataCenter();
       //     UP.connect("127.0.0.1");
            EA = new ElevApp();

            FileStream fs = new FileStream("IP.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string ip = sr.ReadLine();
            Console.WriteLine(ip);
            UP.connect(ip);

            sr.Close();
            fs.Close();
        }

        private void Login_Click(object sender, EventArgs e)
        {

            CHECK = UP.Check(username_box.Text, password_box.Text);
            if (CHECK)
            {
                Hide();
                EA.Show();
                EA.Data = UP;
                EA.Elev = username_box.Text;
                EA.MainForm = this;
                EA.Fixing();
            }
            else
            {
                MessageBox.Show("Fel med andvändare eller lösenord! Försök igen!", "Fel", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

        }


        private void Show_box_CheckedChanged(object sender, EventArgs e)
        {
            if (Show_box.Checked)
            {
                password_box.UseSystemPasswordChar = false;
            }
            else
            {
                password_box.UseSystemPasswordChar = true;
            }
        }

        private void Avbryte_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Username_box_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                password_box.Focus();
            }
        }

        private void Password_box_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                login.Focus();
            }
        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                Avbryte.Focus();
            }
        }

        private void anslutningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            af = new Anslutning(UP);
            af.Show();
        }

        private void Show_box_CheckedChanged_1(object sender, EventArgs e)
        {
            password_box.UseSystemPasswordChar = !password_box.UseSystemPasswordChar;
        }
    }
}
