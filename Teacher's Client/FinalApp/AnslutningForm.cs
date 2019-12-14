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

namespace FinalApp
{
    public partial class AnslutningForm : Form
    {
        DataCenter datacenter;
        Form1 f;
        public string ip;
        public AnslutningForm(DataCenter datacenter, Form1 f)
        {
            InitializeComponent();
            this.datacenter = datacenter;
            this.f = f;
            FileStream fs = new FileStream("IP.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string ip = sr.ReadLine();
           

            sr.Close();
            fs.Close();

            tbx_ip.Text = ip;
        }

        private void btn_anslut_Click(object sender, EventArgs e)
        {
            ip = tbx_ip.Text;
            datacenter.connect(ip);
            FileStream fs = new FileStream("IP.txt",FileMode.Open,FileAccess.Write);
            StreamWriter stw = new StreamWriter(fs);
            
            if (datacenter.connected)
            {
                f.Start();
                f.EnableData(true);

                stw.WriteLine(ip);
                
            }
            stw.Close();
            Close();
        }

        private void AnslutningForm_Load(object sender, EventArgs e)
        {

        }

        private void AnslutningForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void AnslutningForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
