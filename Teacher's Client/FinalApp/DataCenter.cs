using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalApp
{

    public enum Fel { YES, NO };
    enum DataType { SetNewOrd, GetDataFromOrder, SetDataToOrder, GetStudents, GetPlaces, GetAllOrder, GetStudentOrder, GetPlaceOrder, AddStudent, AddPlace, GetOrderCount, DeletePlace, DeleteOrder, DeleteStudent, OrderExist, GetStudent, GetPlace, SetBeskrivning, GetBeskrivning, GetImage, SetImage, Check, GetLastOrder  };

    public class DataCenter
    {
        
        TcpClient klient;
        int port = 12345;
        public bool connected;

        public void connect(string IP)
        {
           
            
            klient = new TcpClient();
            klient.NoDelay = true;

            try
            {
                IPAddress ip = IPAddress.Parse(IP);
                klient.Connect(ip, port);
                connected = true;
            }catch(Exception)
            {
                MessageBox.Show("Kunde inte kontakta servern. Det kan bero på att ip addressen är fel eller att server programmet inte är igång.", "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connected = false;
            }
        }

        public int SetNewOrd()
        {

            int number = 0;
            sendType(DataType.SetNewOrd);

            Fel f = (Fel)GetInt();

            if (f == Fel.NO)
            {
                number = GetInt();
            }
            else
            {
                if (connected)
                {
                    string felMedelande = GetString();
                    MessageBox.Show(felMedelande, "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Thread.Sleep(3);
            return number;
        }
        public string[] GetDataFromOrder(int ordNr)
        {
            
            sendType(DataType.GetDataFromOrder);
            GetInt();
            sendInt(ordNr);

            string[] Data = new string[7];


            
            Fel f = (Fel)GetInt();
            sendInt(3);
            if (f == Fel.NO)
            {

                string DataString = GetString();

                

                Data = DataString.Split('#');
            }
            else
            {
                if (connected)
                {
                    string felMedelande = GetString();
                    MessageBox.Show(felMedelande, "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Thread.Sleep(3);
            return Data;
        }
        public void SetDataToOrder(int ordNr, string[] data, bool visa)
        {
            sendType(DataType.SetDataToOrder);
            sendInt(ordNr);
            string DataString = data[0].ToString();

            for (int i = 1; i < data.Length; i++)
            {
                DataString = DataString + '#' + data[i];
            }
            GetInt();
            sendString(DataString);
            

            Fel f = (Fel)GetInt();

            if(f == Fel.NO && visa)
            {
                MessageBox.Show("Datan har sparats :)", "Sparat", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else if(f == Fel.YES)
            {
                if (connected)
                {
                    string felMedelande = GetString();
                    MessageBox.Show(felMedelande, "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Thread.Sleep(3);
        }
        public string[,] GetStudents()
        {
            sendType(DataType.GetStudents);

            string[,] Data = new string[0,2];

            Fel f = (Fel)GetInt();

            sendInt(3);
            if (f == Fel.NO)
            {

                string DataString = GetString();

                if (!DataString.Equals("NO DATA"))
                {
                    string[] Ydata = DataString.Split('#');


                    Data = new string[Ydata.Length, 2];
                    for (int i = 0; i < Ydata.Length; i++)
                    {
                        string[] Xdata = Ydata[i].Split('?');



                        Data[i, 0] = Xdata[0];
                        Data[i, 1] = Xdata[1];
                    }
                }
            }
            else
            {
                if (connected)
                {
                    string felMedelande = GetString();
                    MessageBox.Show(felMedelande, "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            Thread.Sleep(3);
            return Data;
            
        }

        public string[] GetPlaces()
        {
            string[] Data = new string[0];

            sendType(DataType.GetPlaces);

            Fel f = (Fel)GetInt();
            sendInt(3);
            if(f == Fel.NO)
            {
                string DataString = GetString();

                if (!DataString.Equals("NO DATA"))
                {
                    Data = DataString.Split('#');
                }
            }
            else
            {
                if (connected)
                {
                    string felMedelande = GetString();
                    MessageBox.Show(felMedelande, "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Thread.Sleep(3);
            return Data;
        }

        public string[,] GetAllOrder()
        {
            sendType(DataType.GetAllOrder);

            string[,] Data = new string[0, 7];

            Fel f = (Fel)GetInt();

            if (f == Fel.NO)
            {

                string DataString = GetString();

                if (!DataString.Equals("NO DATA"))
                {
                    string[] Ydata = DataString.Split('#');


                    Data = new string[Ydata.Length, 7];
                    for (int i = 0; i < Ydata.Length; i++)
                    {
                        string[] Xdata = Ydata[i].Split('?');



                        Data[i, 0] = Xdata[0];
                        Data[i, 1] = Xdata[1];
                        Data[i, 2] = Xdata[2];
                        Data[i, 3] = Xdata[3];
                        Data[i, 4] = Xdata[4];
                        Data[i, 5] = Xdata[5];
                        Data[i, 6] = Xdata[6];
                    }
                }

            }
            else
            {
                if (connected)
                {
                    string felMedelande = GetString();
                    MessageBox.Show(felMedelande, "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Thread.Sleep(3);
            return Data;

        }
        public int[] GetStudentOrder(string StudentName)
        {
            int[] Data = new int[0];
            sendType(DataType.GetStudentOrder);

            sendString(StudentName);

            Fel f = (Fel)GetInt();

            if (f == Fel.NO)
            {
                string DataString = GetString();

                string[] DataS;

                DataS = DataString.Split('#');

                int length = DataS.Length;
                Data = new int[length];
                for(int i = 0;i < length; i++)
                {
                    Data[i] = int.Parse(DataS[i]);
                }
            }
            else
            {
                string felMedelande = GetString();
                if (felMedelande.Equals("F")) { }
                else { MessageBox.Show(felMedelande, "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            Thread.Sleep(3);
                return Data;

        }

        public int[] GetPlaceOrder(string Avdelning)
        {
            int[] Data = new int[0];
            sendType(DataType.GetPlaceOrder);

            sendString(Avdelning);

            Fel f = (Fel)GetInt();

            if (f == Fel.NO)
            {
                string DataString = GetString();

                string[] DataS;

                DataS = DataString.Split('#');

                int length = DataS.Length;
                Data = new int[length];
                for (int i = 0; i < length; i++)
                {
                    Data[i] = int.Parse(DataS[i]);
                }
            }
            else
            {
                string felMedelande = GetString();
                if (felMedelande.Equals("F")) { }
                else { MessageBox.Show(felMedelande, "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            Thread.Sleep(3);
            return Data;

        }

        public void AddStudent(string StudentName, string Password)
        {
            sendType(DataType.AddStudent);

            sendString(StudentName);
            Thread.Sleep(3);

            if (Password.Equals("")) { Password = "NO DATA"; }
            sendString(Password);

            Fel f = (Fel)GetInt();

            if (f == Fel.YES)
            {
                if(connected)
                {
                    string felMedelande = GetString();
                    MessageBox.Show(felMedelande, "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Thread.Sleep(3);
        }

        public void AddPlace(string place)
        {
            sendType(DataType.AddPlace);

            sendString(place);
            Thread.Sleep(3);
            

            Fel f = (Fel)GetInt();

            if (f == Fel.YES)
            {
                if (connected)
                {
                    string felMedelande = GetString();
                    MessageBox.Show(felMedelande, "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Thread.Sleep(3);
        }
        public int GetOrderCount()
        {
            int order = 0;
            sendType(DataType.GetOrderCount);

            Fel f = (Fel)GetInt();
            sendInt(3);
            if(f == Fel.NO)
            {
                order = GetInt();
            }
            else
            {
                if (connected)
                {
                    string felMedelande = GetString();
                    MessageBox.Show(felMedelande, "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            Thread.Sleep(3);
            return order;
        }
        public int GetLastOrder()
        {
            int order = 0;
            sendType(DataType.GetLastOrder);

            Fel f = (Fel)GetInt();
            sendInt(3);
            if (f == Fel.NO)
            {
                order = GetInt();
            }
            else
            {
                if (connected)
                {
                    string felMedelande = GetString();
                    MessageBox.Show(felMedelande, "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            Thread.Sleep(3);
            return order;
        }
        public void DeletePlace(string place)
        {
            DialogResult res = MessageBox.Show("Vill du ta bort avdelningen " + place, "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                sendType(DataType.DeletePlace);

                Thread.Sleep(3);
                sendString(place);

                Fel f = (Fel)GetInt();

                if (f == Fel.YES)
                {
                    if (connected)
                    {
                        string felMedelande = GetString();
                        MessageBox.Show(felMedelande, "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                Thread.Sleep(3);
            }
        }

        public void DeleteOrder(int OrderNr)
        {
            DialogResult res = MessageBox.Show("Är du säker på att du vill ta bort den här ordern??", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                sendType(DataType.DeleteOrder);

                sendInt(OrderNr);

                Fel f = (Fel)GetInt();

                if (f == Fel.YES)
                {
                    if (connected)
                    {
                        string felMedelande = GetString();
                        MessageBox.Show(felMedelande, "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                Thread.Sleep(3);
            }
        }
        public void DeleteStudent(string StudentName)
        {
            DialogResult res = MessageBox.Show("Vill du ta bort eleven " + StudentName, "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                sendType(DataType.DeleteStudent);

                GetInt();
                sendString(StudentName);

                Fel f = (Fel)GetInt();
                sendInt(100);
                if (f == Fel.YES)
                {
                    if (connected)
                    {
                        string felMedelande = GetString();
                        MessageBox.Show(felMedelande, "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                Thread.Sleep(3);
            }
        }

        public bool OrderExist(int OrderNr)
        {
            sendType(DataType.OrderExist);
            bool exist = false;
            GetInt();

            sendInt(OrderNr);



            Fel f = (Fel)GetInt();
            sendInt(3);
            if (f == Fel.NO)
            {
                exist = GetBool();
            }
            else
            {
                if (connected)
                {
                    string felMedelande = GetString();
                    MessageBox.Show(felMedelande, "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Thread.Sleep(3);
            return exist;
        }

        public string[] GetStudent(string ElevNamn)
        {
            string[] student = new string[1];

            sendType(DataType.GetStudent);

            sendString(ElevNamn);

            Fel f = (Fel)GetInt();

            if (f == Fel.NO)
            {
                string DataString = GetString();

                student = DataString.Split('#');
            }
            else
            {
                if (connected)
                {
                    string felMedelande = GetString();
                    MessageBox.Show(felMedelande, "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return student;
        }
        public string GetPlace(string AvdelningPlace)
        {
            sendType(DataType.GetPlace);
            string plats = "";

            sendString(AvdelningPlace);

            Fel f = (Fel)GetInt();
            if(f == Fel.NO)
            {
                plats = GetString();
            }
            else
            {
                if (connected)
                {
                    string felMedelande = GetString();
                    MessageBox.Show(felMedelande, "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return plats;
        }
        public void SetBeskrivning(string text, string OrderNr)
        {
            sendType(DataType.SetBeskrivning);

            if (text.Equals("") || text.Equals(null))
            {
                text = "NO DATA";
            }

            sendString(text);
            Thread.Sleep(3);
            GetInt();
            sendString(OrderNr);

            Thread.Sleep(3);
        }

        public string GetBeskrivning(string OrderNr)
        {
            sendType(DataType.GetBeskrivning);
            GetInt();
            sendString(OrderNr);
            
            string text = GetString();
            

            if(text.Equals("NO DATA"))
            {
                text = "";
            }
            return text;
        }

        public Image GetImage(int OrderNr, string Format)
        {
            
            sendType(DataType.GetImage);

            GetInt();
            
            sendInt(OrderNr);

            GetInt();
            sendString(Format);

            
            int Lenght = GetInt();

            
            byte[] ImgByte = new byte[Lenght*2];
            klient.GetStream().Read(ImgByte,0,ImgByte.Length);

          
            MemoryStream ms = new MemoryStream(ImgByte);
            
         
            
            Image img = Image.FromStream(ms);
            
            
            return img;
        }
        public void SetImage(Image img, int OrderNr, string Format)
        {
            sendType(DataType.SetImage);

            

            sendInt(OrderNr);

            GetInt();

            sendString(Format);

            GetInt();
            MemoryStream ms = new MemoryStream();

            img.Save(ms, img.RawFormat);

            byte[] ImgByte = ms.ToArray();

            sendInt(ImgByte.Length);

            GetInt();
            Thread.Sleep(30);
            klient.GetStream().Write(ImgByte, 0, ImgByte.Length);
            Thread.Sleep(30);
            Fel f = (Fel)GetInt();
            if(f == Fel.YES)
            {
                if (connected)
                {
                    string felMedelande = GetString();
                    MessageBox.Show(felMedelande, "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public bool Check(string StudentName, string Password)
        {
            bool Finns = false;
            sendType(DataType.Check);

            sendString(StudentName);

            GetString();

            sendString(Password);

            Fel f = (Fel)GetInt();

            if(f == Fel.NO)
            {
                Finns = GetBool();
            }
            else
            {
                if (connected)
                {
                    string felMedelande = GetString();
                    MessageBox.Show(felMedelande, "Fel", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            return Finns;
        }
        private void sendType (DataType type)
        {
            if (connected)
            {
                byte[] typeBitar = BitConverter.GetBytes((int)type);

                klient.GetStream().Write(typeBitar, 0, typeBitar.Length);
            }
        }

        public async void sendInt(int num)
        {
            if (connected)
            {
                byte[] sendData = BitConverter.GetBytes(num);
                await klient.GetStream().WriteAsync(sendData, 0, sendData.Length);
            }
            
        }

        public async void sendString( string text)
        {
            if (connected)
            {
                byte[] sendData = Encoding.Unicode.GetBytes(text);

                await klient.GetStream().WriteAsync(sendData, 0, sendData.Length);
            }
        }
        public int GetInt()
        {
            int num = 0;
            if (connected)
            {
                byte[] recieveData = new byte[1000];
                klient.GetStream().Read(recieveData, 0, recieveData.Length);
                 num = BitConverter.ToInt32(recieveData, 0);

                Thread.Sleep(3);
            }
            return num;


        }

        public string GetString()
        {
            string text = "";
            if (connected)
            {
                byte[] recieveData = new byte[1000];
                int n = klient.GetStream().Read(recieveData, 0, recieveData.Length);
                text = Encoding.Unicode.GetString(recieveData, 0, n);

                Thread.Sleep(3);
            }
            return text;

        }
         public bool GetBool()
        {
            bool bo = false;
            if (connected)
            {
                byte[] recieveData = new byte[1000];
                klient.GetStream().Read(recieveData, 0, recieveData.Length);

                Thread.Sleep(3);
                bo = BitConverter.ToBoolean(recieveData, 0);
            }
            return bo;
        }
    }
}



