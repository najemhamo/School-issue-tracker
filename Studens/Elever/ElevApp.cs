using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elever
{
    public partial class ElevApp : Form
    {
        public DataCenter Data;
        public string Elev;
        int[] Order;
        lösenord bytt = new lösenord();
        public Form1 MainForm;
        string[] data;
        

        public ElevApp()
        {
            InitializeComponent();
        }

        private void Nud_OrderNr_ValueChanged(object sender, EventArgs e)
        {
            Data.GetOrderCount();

            int V = (int)nud_OrderNr.Value -1;
          //  MessageBox.Show(V.ToString());
            data = Data.GetDataFromOrder(Order[V]);
            avdelning_box.Text = data[2];
            if (!data[6].Equals(""))
            {
                
                Image img = Data.GetImage(Order[V], data[6]);
                Bild_Box.Image = img;
            }
            else
            {
                Bild_Box.Image = null;
            }
            string beskrivning = Data.GetBeskrivning(Order[V].ToString());
            Beskrivning_box.Text = beskrivning;
            Prio_nud.Value = int.Parse(data[3]);
            Signatur_box.Text = data[5];
            if (data[4].Equals("Ja"))
            {
                JaBtn.Checked = true;
            }
            else if (data[4].Equals("Nej"))
            {
                NejBtn.Checked = true;
            }
        }
        public void Fixing()
        {
            Order = Data.GetStudentOrder(Elev);
            
            nud_OrderNr.Maximum = Order.Length;
            nud_OrderNr.Value = Order.Length;
            nud_OrderNr.Minimum = 1;
           // MessageBox.Show(Order.Length.ToString());
        }

        private void Btn_Avbryt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ByttLösenordToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            bytt.Show();
            bytt.Elev = Elev;
            bytt.DT = Data;
        }

      
        private void ElevApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm.Close();
        }

        private void btn_Spara_Click(object sender, EventArgs e)
        {
            if (JaBtn.Checked)
            {
                data[4] = "Ja";
                
            }
            if (NejBtn.Checked)
            {
                data[4] = "Nej";
            }
            data[5] = Signatur_box.Text;
            Data.SetDataToOrder(Order[(int)nud_OrderNr.Value], data, true);
        }

        private void omOssToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Om info = new Om();
            info.Show();
        }

        private void btn_uppdate_Click(object sender, EventArgs e)
        {
            Order = Data.GetStudentOrder(Elev);
            nud_OrderNr.Maximum = Order.Length;
            nud_OrderNr.Value = Order.Length;

        }
    }
}
