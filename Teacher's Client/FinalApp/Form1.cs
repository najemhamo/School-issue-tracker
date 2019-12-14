using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace FinalApp
{
    public partial class Form1 : Form
    {
        AnslutningForm af;
        Image Bild;
        string fileEnd;
        bool FinnsBild = false;
        int NumricValue;
        bool t = false;
        DataCenter DataBase;
        public Form1()
        {
             
            InitializeComponent();

            DataBase = new DataCenter();

            FileStream fs = new FileStream("IP.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string ip = sr.ReadLine();
            Console.WriteLine(ip);
            DataBase.connect(ip);

            sr.Close();
            fs.Close();
            
            //  Bild = DataBase.GetImage(1,"png");
            //   pbx_BildBox.Image = Bild;



            Start();
            

        }
        //Avslutning


        private void Avbryt_Click(object sender, EventArgs e)
        {
          
                this.Close();
            
         
        }

        private void avslutaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            tpc_Tabell.Visible = false;
            pnl_app.Visible = true;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (t)
            {
                DialogResult res = MessageBox.Show("Du har inte sparat, Vill du spara??", "Exit", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    SaveData(NumricValue, false);
                    e.Cancel = false;
                }
                else if (res == DialogResult.No)
                {
                    e.Cancel = false;

                }
                else
                {
                    e.Cancel = true;
                }
            

                }
        }

        private void Beskrivning_TextChanged(object sender, EventArgs e)
        {
            t = true;
        }

        private void Ansvaring_TextChanged(object sender, EventArgs e)
        {
            t = true;
        }

        private void Avdelning_TextChanged(object sender, EventArgs e)
        {
            t = true;
        }

        private void OrderNr_ValueChanged(object sender, EventArgs e)
        {
            
            if (t)
            {
                DialogResult dg = MessageBox.Show("Du har inte sparat. Vill du Spara??","Spara" , MessageBoxButtons.YesNoCancel,MessageBoxIcon.Information);
                if (dg == DialogResult.Yes)
                {
                    SaveData(NumricValue, false);
                    FillData();
                    NumricValue = (int)nud_OrderNr.Value;
                    t = false;

                }
                else if (dg == DialogResult.No)
                {
                    FillData();
                    NumricValue = (int)nud_OrderNr.Value;
                    t = false;
                }
                else
                {
                    nud_OrderNr.Value = NumricValue;
                    t = true;
                }

            }else
            {
                int Ordrar = DataBase.GetOrderCount();

                
                if (Ordrar != 0)
                {
                    if (DataBase.OrderExist((int)nud_OrderNr.Value))
                    {
                        NumricValue = (int)nud_OrderNr.Value;
                        FillData();
                        
                    }
                    else
                    {
                        int diff = NumricValue - (int)nud_OrderNr.Value;
                        if (diff > 0)
                        {
                            if ((nud_OrderNr.Value - 1) < nud_OrderNr.Minimum)
                            {
                                nud_OrderNr.Value = NumricValue;
                            }
                            else
                            {

                                nud_OrderNr.Value = nud_OrderNr.Value - 1;
                            }
                        } else if (diff < 0)
                        {
                            if ((nud_OrderNr.Value + 1) > nud_OrderNr.Maximum)
                            {
                                nud_OrderNr.Value = NumricValue;
                            }
                            else
                            {
                                nud_OrderNr.Value = nud_OrderNr.Value + 1;
                            }
                        }
                    }
                }
      
                t = false;
            }

            


        }
        //Spara

        private void Spara_Click(object sender, EventArgs e)
        {
           
           

            SaveData(NumricValue,true);
            

        }

        private void InfogaBtn_Click(object sender, EventArgs e)
        {
            
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try { Bild.Dispose(); } catch (Exception) { }
                Bild = Image.FromFile(openFileDialog1.FileName);
                pbx_BildBox.Image = Bild;

                
                
                string[] file = openFileDialog1.SafeFileName.Split('.');
                fileEnd = file[file.Length -1];

                

                FinnsBild = true;
                t = true;
            }
        }
        
       public void FillData()
        {
            Console.WriteLine("FillData");
            string[] Data = DataBase.GetDataFromOrder(NumricValue);

           

            cbx_Ansvaring.Text = Data[1];
            cbx_Avdelning.Text = Data[2];
            
            nud_Prio.Value = int.Parse(Data[3]);
            if (Data[4].Equals("Ja"))
            {
                rdb_JaBtn.Checked = true;
            }
            else
            {
                rdb_NejBtn.Checked = true;
            }
            tbx_datum.Text = Data[5];

            tbx_Beskrivning.Text = DataBase.GetBeskrivning(Data[0]);
            Console.WriteLine(Data[6]);
            if (Data[6] != null && Data[6] != "")
            {
                Console.WriteLine( Data[0] + " Format: " + Data[6]);
                try { Bild.Dispose(); } catch(Exception) { }

               // Bild = Image.FromFile("Data/" + Data[0] + "." + Data[6]);

                Bild = DataBase.GetImage(int.Parse(Data[0]),Data[6]);
                pbx_BildBox.Image = Bild;

                
                fileEnd = Data[6];

                FinnsBild = true;

              
            }
            else
            {
                FinnsBild = false;
                pbx_BildBox.Image = null;
                fileEnd = "";
            }

            
            
        }
        
        // Spara 
         public void SaveData(int Value, bool visa)
        {
            try
            {
                string[] Data = new string[7];

                Data[0] = Value.ToString();
                Data[1] = cbx_Ansvaring.Text;
                Data[2] = cbx_Avdelning.Text;
                Data[3] = nud_Prio.Value.ToString();
                if (rdb_JaBtn.Checked)
                {
                    Data[4] = "Ja";
                }
                else if(rdb_NejBtn.Checked)
                {
                    Data[4] = "Nej";
                }

                Data[5] = tbx_datum.Text;

                if (FinnsBild)
                {

                    string FilNamn = "Data/" + Data[0] + "." + fileEnd;




                    //   try
                    //  {
                    //     Bild.Save(FilNamn);
                    //  }
                    //   catch (Exception error) { }

                    DataBase.SetImage(Bild, int.Parse(Data[0]), fileEnd);
                    Data[6] = fileEnd;
                }

                DataBase.SetDataToOrder(Value, Data, visa);




                DataBase.SetBeskrivning(tbx_Beskrivning.Text,Data[0]);

                dgv_ordrar.Rows.Clear();
                int spinner = DataBase.GetOrderCount();
                string[,] OrderData = DataBase.GetAllOrder();

                for (int i = 0; i < spinner; i++)
                {
                    dgv_ordrar.Rows.Add(OrderData[i, 0], OrderData[i, 1], OrderData[i, 2], OrderData[i, 3], OrderData[i, 4], OrderData[i, 5]);
                }


                t = false;

            }catch(Exception error)
            {
                MessageBox.Show(error.Message,null,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
                
        }

        private void nyOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            int sif = DataBase.SetNewOrd();


            DataBase.SetBeskrivning("", sif.ToString());


            nud_OrderNr.Maximum = sif;
            nud_OrderNr.Value = sif;

            dgv_ordrar.Rows.Clear();
            string[,] OrderData = DataBase.GetAllOrder();

            for (int i = 0; i < DataBase.GetOrderCount(); i++)
            {
                dgv_ordrar.Rows.Add(OrderData[i, 0], OrderData[i, 1], OrderData[i, 2], OrderData[i, 3], OrderData[i, 4], OrderData[i, 5]);
            }

            EnableData(true);
            rdb_NejBtn.Checked = true;
        }

        private void nud_Prio_ValueChanged(object sender, EventArgs e)
        {
            t = true;
        }

        private void rdb_JaBtn_CheckedChanged(object sender, EventArgs e)
        {
            t = true;
        }

        private void rdb_NejBtn_CheckedChanged(object sender, EventArgs e)
        {
            t = true;
        }

        private void tbx_datum_TextChanged(object sender, EventArgs e)
        {
            t = true;
        }

        private void sparaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveData(NumricValue, true);
        }

        private void ansvarigaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tpc_Tabell.Visible = true;
            pnl_app.Visible = false;

            tpc_Tabell.SelectedIndex = 2;
        }

        private void ordrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void avdelningarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tpc_Tabell.Visible = true;
            pnl_app.Visible = false;

            tpc_Tabell.SelectedIndex = 1;
        }

        private void orderarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tpc_Tabell.Visible = true;
            pnl_app.Visible = false;

            tpc_Tabell.SelectedIndex = 0;
        }

        private void FillComboBoxes()
        {
            cbx_Ansvaring.Items.Clear();
            cbx_ansvarigaOrdrar.Items.Clear();
            cbx_Avdelning.Items.Clear();
            cbx_avdelningarOrdrar.Items.Clear();
            dgv_Avdelningar.Rows.Clear();
            dgv_elever.Rows.Clear();
            cbx_SearchWord.Items.Clear();

            string[,] elever = DataBase.GetStudents();
            string[] avdelningar = DataBase.GetPlaces();
            int indexCombo = cbx_SearchOrder.SelectedIndex;
          

            for (int i = 0;i < elever.GetLength(0); i++)
            {
                cbx_Ansvaring.Items.Add(elever[i,0]);
                cbx_ansvarigaOrdrar.Items.Add(elever[i, 0]);
                 if(indexCombo == 0)
                {
                    cbx_SearchWord.Items.Add(elever[i, 0]);
                    cbx_SearchWord.SelectedIndex = i;
                }
                dgv_elever.Rows.Add(elever[i,0],elever[i,1]);
                
            }
            
            foreach (string avdelning in avdelningar)
            {
                cbx_Avdelning.Items.Add(avdelning);
                cbx_avdelningarOrdrar.Items.Add(avdelning);
                if (indexCombo == 1)
                {
                    cbx_SearchWord.Items.Add(avdelning);
                }
                dgv_Avdelningar.Rows.Add(avdelning);
                cbx_SearchWord.Text = avdelning;

            }
            

        }

        private void dgv_ordrar_SelectionChanged(object sender, EventArgs e)
        {
            

            

        }

        private void dgv_ordrar_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void dgv_ordrar_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            try
            {
                tbx_orderNr.Text = e.Row.Cells[0].Value.ToString();

                try { cbx_ansvarigaOrdrar.Text = e.Row.Cells[1].Value.ToString(); }catch(Exception err) { cbx_ansvarigaOrdrar.Text = ""; }

                try { cbx_avdelningarOrdrar.Text = e.Row.Cells[2].Value.ToString(); } catch (Exception err) { cbx_avdelningarOrdrar.Text = ""; }

                nud_PrioOrder.Value = decimal.Parse(e.Row.Cells[3].Value.ToString());

                string borjat = e.Row.Cells[4].Value.ToString();

                if (borjat.Equals("Ja"))
                {
                    rdb_jaOrder.Checked = true;
                } else if (borjat.Equals("Nej"))
                {
                    rdb_nejOrder.Checked = true;
                }

                tbx_KlarOrder.Text = e.Row.Cells[5].Value.ToString();
             

            }
            catch(Exception error) {  }
        }

        private void btn_Sok_Click(object sender, EventArgs e)
        {
            dgv_ordrar.Rows.Clear();
           
            
                dgv_ordrar.Rows.Clear();
                int[] OrderNumbers = null;
                if (cbx_SearchOrder.SelectedIndex == 0)
                {
                    OrderNumbers = DataBase.GetStudentOrder(cbx_SearchWord.Text);
                }
                else if (cbx_SearchOrder.SelectedIndex == 1)
                {
                    OrderNumbers = DataBase.GetPlaceOrder(cbx_SearchWord.Text);
                }



                
                for (int i = 0; i < OrderNumbers.Length; i++)
                {
                    
                    string[] OrderData = DataBase.GetDataFromOrder(OrderNumbers[i]);
                    dgv_ordrar.Rows.Add(OrderData[0], OrderData[1], OrderData[2], OrderData[3], OrderData[4], OrderData[5]);
                }
               
            
            

           
        }

        private void tbx_SearchWord_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_Avdelningar_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbx_avdelningAdd.Text = dgv_Avdelningar.Rows[e.RowIndex].Cells[0].Value.ToString();
            }catch(Exception er) { }
        }

        private void btn_AddAvdelning_Click(object sender, EventArgs e)
        {
            DataBase.AddPlace(tbx_avdelningAdd.Text);
            FillComboBoxes();
        }

        private void btn_AvdelningRemove_Click(object sender, EventArgs e)
        {
            DataBase.DeletePlace(tbx_avdelningAdd.Text);
            FillComboBoxes();
        }

        private void btn_OrderRemove_Click(object sender, EventArgs e)
        {
            DataBase.DeleteOrder(int.Parse(tbx_orderNr.Text));
            

            if(DataBase.GetOrderCount() == 0)
            {
                EnableData(false);
            }

        }

        private void btn_OrderUpdate_Click(object sender, EventArgs e)
        {
            string[] Data = new string[7];

            Data[0] = tbx_orderNr.Text;
            Data[1] = cbx_ansvarigaOrdrar.Text;
            Data[2] = cbx_avdelningarOrdrar.Text;
            Data[3] = nud_PrioOrder.Value.ToString();
            if (rdb_jaOrder.Checked)
            {
                Data[4] = "Ja";
            }
            else if(rdb_nejOrder.Checked)
            {
                Data[4] = "Nej";
            }

            Data[5] = tbx_KlarOrder.Text;
            Data[6] = "F";
            DataBase.SetDataToOrder(int.Parse(tbx_orderNr.Text), Data, false);
            
            if(nud_OrderNr.Value == int.Parse(tbx_orderNr.Text)) { FillData(); }
            
        }

        private void dgv_elever_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            try { tbx_StudentName.Text = e.Row.Cells[0].Value.ToString(); } catch (Exception) { tbx_StudentName.Text = ""; }
            try { tbx_Password.Text = e.Row.Cells[1].Value.ToString(); } catch (Exception) { tbx_Password.Text = ""; }
        }

        private void btn_AddStudent_Click(object sender, EventArgs e)
        {
            DataBase.AddStudent(tbx_StudentName.Text,tbx_Password.Text);
            FillComboBoxes();
        }

        private void btn_RemoveStudent_Click(object sender, EventArgs e)
        {
            DataBase.DeleteStudent(tbx_StudentName.Text);
            FillComboBoxes();
        }

        private void btn_SokElev_Click(object sender, EventArgs e)
        {
            string ElevNamn = tbx_ElevNamn.Text;
            if (ElevNamn.Equals(""))
            {
                string[,] elever = DataBase.GetStudents();
               
                dgv_elever.Rows.Clear();

                for (int i = 0; i < elever.GetLength(0); i++)
                {
                  
                    

                    dgv_elever.Rows.Add(elever[i, 0], elever[i, 1]);
                }
            }
            else
            {
                string[] Elev = DataBase.GetStudent(ElevNamn);
                
                if (Elev.Length == 1)
                {
                    MessageBox.Show("Det finns ingen elev som har namnet " + ElevNamn, null, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dgv_elever.Rows.Clear();
                    dgv_elever.Rows.Add(Elev[0], Elev[1]);
                }
                
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string AvdelningsNamn = tbx_AvdelningSok.Text;

            if (AvdelningsNamn.Equals(""))
            {
                dgv_Avdelningar.Rows.Clear();

                string[] avdelningar = DataBase.GetPlaces();
                foreach (string avdelning1 in avdelningar)
                {


                    dgv_Avdelningar.Rows.Add(avdelning1);

                }
            }
            else
            {
                string avdelning = DataBase.GetPlace(AvdelningsNamn);

                if (avdelning.Equals("No"))
                {
                    MessageBox.Show("Det finns ingen avdelning som heter " + AvdelningsNamn, null, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dgv_Avdelningar.Rows.Clear();

                    dgv_Avdelningar.Rows.Add(avdelning);

                }
            }
        }
        public void EnableData(bool enb)
        {
            nud_OrderNr.Enabled = enb;

            cbx_Ansvaring.Enabled = enb;
            cbx_Avdelning.Enabled = enb;

            nud_Prio.Enabled = enb;

            

            tbx_datum.Enabled = enb;

            tbx_Beskrivning.Enabled = enb;

            btn_InfogaBtn.Enabled = enb;

            btn_Spara.Enabled = enb;

            pbx_BildBox.Image = null;


        }
        public void Start()
        {
            int spinner = DataBase.GetLastOrder();
            string[,] OrderData = DataBase.GetAllOrder();


            if (OrderData.GetLength(0) != 0)
            {

                nud_OrderNr.Maximum = spinner;
                nud_OrderNr.Value = spinner;

            }
            else
            {
                EnableData(false);
                nud_OrderNr.Value = 0;

            }
            FillComboBoxes();
            

            for (int i = 0; i < OrderData.GetLength(0); i++)
            {
                dgv_ordrar.Rows.Add(OrderData[i, 0], OrderData[i, 1], OrderData[i, 2], OrderData[i, 3], OrderData[i, 4], OrderData[i, 5]);
            }



            t = false;
            NumricValue = (int)nud_OrderNr.Value;

            cbx_SearchOrder.SelectedIndex = 0;
        }

        private void anslutningenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            af = new AnslutningForm(DataBase, this);
            af.Show();
            
        }

        private void cbx_SearchOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            FillComboBoxes();
        }

        private void btn_VisaAllaOrder_Click(object sender, EventArgs e)
        {
            dgv_ordrar.Rows.Clear();
            int spinner = DataBase.GetOrderCount();
            string[,] OrderData = DataBase.GetAllOrder();

            for (int i = 0; i < spinner; i++)
            {
                dgv_ordrar.Rows.Add(OrderData[i, 0], OrderData[i, 1], OrderData[i, 2], OrderData[i, 3], OrderData[i, 4], OrderData[i, 5]);
            }
        }

        private void OmOssToolStripMenuItem_Click(object sender, EventArgs e)
        {
            om about = new om();
            about.Show();
        }

        private void tpg_order_Click(object sender, EventArgs e)
        {

        }
    }
}
