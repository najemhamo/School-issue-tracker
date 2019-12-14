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
    public partial class Anslutning : Form
    {
        DataCenter datacenter;
        public string ip;

        public Anslutning(DataCenter dataCenter)
        {
            InitializeComponent();
            datacenter = dataCenter;
           
            
            FileStream fs = new FileStream("IP.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string ip = sr.ReadLine();
            tbx_ip.Text = ip;
        }

        private void btn_anslut_Click(object sender, EventArgs e)
        {

            ip = tbx_ip.Text;
            datacenter.connect(ip);
            FileStream fs = new FileStream("IP.txt", FileMode.Open, FileAccess.Write);
            StreamWriter stw = new StreamWriter(fs);

            if (datacenter.connected)
            {
               
                stw.WriteLine(ip);

            }
            stw.Close();
            Close();
        }
    }
}
