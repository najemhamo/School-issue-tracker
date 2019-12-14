using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerFinalApp
{
    // enum DataType är gjort för att servern ska veta vad klienten vill ha för data
    enum DataType { SetNewOrd, GetDataFromOrder, SetDataToOrder, GetStudents, GetPlaces, GetAllOrder, GetStudentOrder, GetPlaceOrder, AddStudent, AddPlace, GetOrderCount, DeletePlace, DeleteOrder, DeleteStudent, OrderExist, GetStudent, GetPlace, SetBeskrivning, GetBeskrivning, GetImage, SetImage,Check,GetLastOrder};

    public partial class Form1 : Form
    {
        int port = 12345;
        TcpListener Lysnare;
       
        string textMain;

        // Listan klient ska innehålla alla klienter som konektar servern
        List<Klient> klienter = new List<Klient>();

        public Form1()
        {
            InitializeComponent();

            Lysnare = new TcpListener(IPAddress.Any, port);
            
            Lysnare.Start();
            Anslut();
        }
           
        // Metoden Anslut vänter på att en ny klient ska anslute 
        public async void Anslut()
        {
            try
            {
                TcpClient klent = await Lysnare.AcceptTcpClientAsync();

                // Metoden skapar en en Klient klass och lägger TcpClient i den
                Klient k = new Klient();

                k.klient = klent;
                k.fel = Fel.NO;
                k.FelMedelande = "";

                // Klienten adderas i listan
                klienter.Add(k);

                // Metoden Anslut anropas igen för att vänta på en ny klient
                Anslut();
                
                // Metoden Lyssna anropas  
                 Lyssna(k);
            

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, null, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        // Metoden Lyssna lyssnar på vad klienten vill och skickar datan till han
        public async void Lyssna(Klient k)
        {
            

            try
            {
                // Tar emot enum DataType från användaren
                byte[] recieveData = new byte[1000];
                await k.klient.GetStream().ReadAsync(recieveData, 0, recieveData.Length);
                int typeNumber = BitConverter.ToInt32(recieveData, 0);


                DataType type = (DataType)typeNumber;
                lbx_listan.Items.Add(type);
                //_________________________________________________

                // Metoden i klassen DataBase som motsvarar DataType anropas och Datan skickas till användaren
                // Om det händer ett fel så skickas felmedelandet istället av datan
                if (type == DataType.SetNewOrd)
                {
                    int orderNew = DataBase.SetNewOrd(k);

                    sendInt(k.klient, (int)k.fel);

                    if (k.fel == Fel.NO)
                    {
                        sendInt(k.klient, orderNew);
                    }
                    else
                    {
                        sendString(k.klient, k.FelMedelande);
                    }

                }
                else if (type == DataType.GetDataFromOrder)
                {
                    sendInt(k.klient, 3);
                    int ordNr = GetInt(k.klient);



                    string[] OrderData = DataBase.GetDataFromOrder(ordNr, k);

                    sendInt(k.klient, (int)k.fel);
                    GetInt(k.klient);
                    if (k.fel == Fel.NO)
                    {

                        string DataString = OrderData[0];

                        for (int i = 1; i < OrderData.Length; i++)
                        {
                           // Fältet omvandlas till en string och delas med en # imellan så att klienten kan dela den och omvandla den till ett fält igen
                            DataString = DataString + "#" + OrderData[i];
                        }

                        sendString(k.klient, DataString);
                    }
                    else
                    {
                        sendString(k.klient, k.FelMedelande);
                    }

                }
                else if (type == DataType.GetOrderCount)
                {

                    int order = DataBase.GetOrderCount(k);

                    sendInt(k.klient, (int)k.fel);

                    GetInt(k.klient);
                    if (k.fel == Fel.NO)
                    {
                        sendInt(k.klient, order);
                    }
                    else
                    {
                        sendString(k.klient, k.FelMedelande);
                    }
                }

                else if (type == DataType.GetPlaces)
                {
                    string[] places = DataBase.GetPlaces(k);

                    sendInt(k.klient, (int)k.fel);
                    GetInt(k.klient);
                    if (k.fel == Fel.NO)
                    {
                        if (places.Length != 0)
                        {
                            string DataString = places[0];

                            for (int i = 1; i < places.Length; i++)
                            {
                                // Fältet omvandlas till en string och delas med en # imellan så att klienten kan dela den och omvandla den till ett fält igen
                                DataString = DataString + "#" + places[i];
                            }

                            sendString(k.klient, DataString);
                        }
                        else
                        {
                            sendString(k.klient, "NO DATA");
                        }
                    }
                    else
                    {
                        sendString(k.klient, k.FelMedelande);
                    }
                }
                else if (type == DataType.GetStudents)
                {
                    string[,] students = DataBase.GetStudents(k);

                    sendInt(k.klient, (int)k.fel);
                    GetInt(k.klient);
                    if (k.fel == Fel.NO)
                    {

                        string DataString = "";

                        for (int i = 0; i < students.GetLength(0); i++)
                        {
                            DataString = DataString + students[i, 0];
                            // Dubbelfältet omvandlas till en string och delas med en ? och # imellan så att klienten kan dela den och omvandla den till ett fält igen
                            for (int t = 1; t < students.GetLength(1); t++)
                            {

                                DataString = DataString + "?" + students[i, t];
                            }
                            if (i != students.GetLength(0) - 1)
                            {
                                
                                DataString = DataString + "#";
                            }

                        }

                        if (DataString.Equals(""))
                        {
                            DataString = "NO DATA";
                        }
                        sendString(k.klient, DataString);
                    }
                    else
                    {
                        sendString(k.klient, k.FelMedelande);
                    }
                }
                else if (type == DataType.GetAllOrder)
                {
                    string[,] Order = DataBase.GetAllOrder(k);

                    sendInt(k.klient, (int)k.fel);
                    if (k.fel == Fel.NO)
                    {

                        string DataString = "";

                        for (int i = 0; i < Order.GetLength(0); i++)
                        {
                            DataString = DataString + Order[i, 0];
                            for (int t = 1; t < Order.GetLength(1); t++)
                            {
                                // Dubbelfältet omvandlas till en string och delas med en ? och # imellan så att klienten kan dela den och omvandla den till ett fält igen
                                DataString = DataString + "?" + Order[i, t];
                            }
                            if (i != Order.GetLength(0) - 1)
                            {
                                DataString = DataString + "#";
                            }

                        }
                        if (DataString.Equals(""))
                        {
                            DataString = "NO DATA";
                        }

                        sendString(k.klient, DataString);
                    }
                    else
                    {
                        sendString(k.klient, k.FelMedelande);
                    }
                }
                else if (type == DataType.GetStudentOrder)
                {
                    string studentName = GetString(k.klient);
                    int[] studentOrder = DataBase.GetStudentOrder(studentName, k);

                    sendInt(k.klient, (int)k.fel);

                    if (k.fel == Fel.NO)
                    {
                        string DataString = studentOrder[0].ToString();

                        for (int i = 1; i < studentOrder.Length; i++)
                        {
                            // Fältet omvandlas till en string och delas med en # imellan så att klienten kan dela den och omvandla den till ett fält igen
                            DataString = DataString + '#' + studentOrder[i];
                        }
                        sendString(k.klient, DataString);
                    }
                    else
                    {
                        sendString(k.klient, k.FelMedelande);
                    }
                }
                else if (type == DataType.GetPlaceOrder)
                {
                    string PlaceName = GetString(k.klient);
                    int[] PlaceOrder = DataBase.GetPlaceOrder(PlaceName, k);

                    sendInt(k.klient, (int)k.fel);

                    if (k.fel == Fel.NO)
                    {
                        string DataString = PlaceOrder[0].ToString();

                        for (int i = 1; i < PlaceOrder.Length; i++)
                        {
                            // Fältet omvandlas till en string och delas med en # imellan så att klienten kan dela den och omvandla den till ett fält igen
                            DataString = DataString + '#' + PlaceOrder[i];
                        }
                        sendString(k.klient, DataString);
                    }
                    else
                    {
                        sendString(k.klient, k.FelMedelande);
                    }
                    Thread.Sleep(3);
                }
                else if (type == DataType.SetDataToOrder)
                {
                    // Servern får ett fält i form av en string
                    int ordNr = GetInt(k.klient);
                    sendInt(k.klient,100);
                    string DataString = GetString(k.klient);

                    Thread.Sleep(3);
                    
                    // Servern delar den med hjälp av tecknet # som ligger imellan varje string i fältet
                    string[] Data = DataString.Split('#');

                    DataBase.SetDataToOrder(ordNr, Data, k);

                    sendInt(k.klient, (int)k.fel);
                    if (k.fel == Fel.YES)
                    {
                        sendString(k.klient, k.FelMedelande);
                    }

                    Thread.Sleep(3);

                }
                else if (type == DataType.AddStudent)
                {
                    string StudentName = GetString(k.klient);
                    Thread.Sleep(3);
                    string Password = GetString(k.klient);

                    if (Password.Equals("NO DATA"))
                    {
                        Password = "";
                    }
                    DataBase.AddStudent(StudentName, Password, k);

                    sendInt(k.klient, (int)k.fel);

                    if (k.fel == Fel.YES)
                    {
                        sendString(k.klient, k.FelMedelande);
                    }

                }
                else if (type == DataType.AddPlace)
                {
                    string place = GetString(k.klient);

                    DataBase.AddPlace(place, k);

                    sendInt(k.klient, (int)k.fel);

                    if (k.fel == Fel.YES)
                    {
                        sendString(k.klient, k.FelMedelande);
                    }
                }
                else if (type == DataType.DeletePlace)
                {
                    string place = GetString(k.klient);

                    DataBase.DeletePlace(place, k);

                    sendInt(k.klient, (int)k.fel);
                    if (k.fel == Fel.YES)
                    {
                        sendString(k.klient, k.FelMedelande);
                    }
                    Thread.Sleep(3);

                }
                else if (type == DataType.DeleteOrder)
                {
                    int ordNr = GetInt(k.klient);

                    DataBase.DeleteOrder(ordNr, k);

                    sendInt(k.klient, (int)k.fel);
                    if (k.fel == Fel.YES)
                    {
                        sendString(k.klient, k.FelMedelande);
                    }
                    Thread.Sleep(3);
                }
                else if (type == DataType.DeleteStudent)
                {
                    sendInt(k.klient, 100);
                    string StudentName = GetString(k.klient);

                    DataBase.DeleteStudent(StudentName, k);

                    sendInt(k.klient, (int)k.fel);
                    if (k.fel == Fel.YES)
                    {
                        GetInt(k.klient);
                        sendString(k.klient, k.FelMedelande);
                    }
                    Thread.Sleep(3);
                }

                else if (type == DataType.GetStudent)
                {
                    string ElevNamn = GetString(k.klient);

                    string[] StudentData = DataBase.GetStudent(ElevNamn, k);
                    sendInt(k.klient, (int)k.fel);

                    if (k.fel == Fel.NO)
                    {
                        string DataString = "NO DATA";
                        if (StudentData.Length != 1)
                        {
                            DataString = StudentData[0] + "#" + StudentData[1];
                        }
                        sendString(k.klient, DataString);
                    }
                    else
                    {
                        sendString(k.klient, k.FelMedelande);
                    }
                    Thread.Sleep(3);
                }
                else if (type == DataType.GetPlace)
                {
                    string avdelning = GetString(k.klient);

                    string DataString = DataBase.GetPlace(avdelning, k);

                    sendInt(k.klient, (int)k.fel);
                    if (k.fel == Fel.NO)
                    {
                        sendString(k.klient, DataString);
                    }
                    else
                    {
                        sendString(k.klient, k.FelMedelande);
                    }
                }
                else if (type == DataType.OrderExist)
                {
                    sendInt(k.klient, 3);
                    int OrderNr = GetInt(k.klient);

                    bool exist = DataBase.OrderExist(OrderNr, k);

                    sendInt(k.klient, (int)k.fel);
                    GetInt(k.klient);
                    if (k.fel == Fel.NO)
                    {
                        sendBool(k.klient, exist);
                    }
                    else
                    {
                        sendString(k.klient, k.FelMedelande);
                    }
                }
                // SetBeskrivning finns inte i klassen DataBase för att beskrivningen ligger inte i databasen utan i en text fil
                // Metoden finns för att användaren ska spara beskrivningen
                else if (type == DataType.SetBeskrivning)
                {
                    // Tar emot texten som användare vill spara
                    string text = GetString(k.klient);
                    if (text.Equals("NO DATA"))
                    {
                        text = "";
                    }
                    // Serven tar ordernummret från klienten
                    sendInt(k.klient, 100);
                    string OrderNr = GetString(k.klient);

                    Thread.Sleep(3);
                    // Servern plockar textfilen med hjälp av ordernummer och sätter texten i den
                    FileStream fs = new FileStream("Data/" + OrderNr + ".txt", FileMode.Create, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.Write(text);
                    sw.Close();
                    fs.Close();
                }
                // GetBeskrivning finns inte i klassen DataBase för att beskrivningen ligger inte i databasen utan i en text fil
                // Metoden finns för att användaren ska ta beskrivningen från servern
                else if (type == DataType.GetBeskrivning)
                {
                    sendInt(k.klient, 3);

                    // Serven tar ordernummret från klienten
                    string OrderNr = GetString(k.klient);
                    string text;
                    try
                    {
                        // Servern plockar textfilen med hjälp av ordernummer och sätter texten i den
                        FileStream fs = new FileStream("Data/" + OrderNr + ".txt", FileMode.Open, FileAccess.Read);
                        StreamReader sr = new StreamReader(fs);

                        // Den läser texten och skickar den till klienten
                        text = sr.ReadToEnd();
                        sr.Close();
                        fs.Close();
                    }
                    catch (Exception)
                    {
                        text = "";
                    }
                   
                    Thread.Sleep(3);
                    if (text.Equals(""))
                    {
                        text = "NO DATA";
                    }
                    sendString(k.klient, text);
                }
                // GetImage finns inte i klassen DataBase för att bilden ligger inte i databasen utan i en bild fil
                // Metoden finns för att användaren ska ta bilden från servern
                else if (type == DataType.GetImage)
                {
                    sendInt(k.klient, 3);
                    // Ordernummret tas från klienten
                    int OrderNr = GetInt(k.klient);
                    sendInt(k.klient, 3);

                    // Servern tar bildformatet från klienten för att den ska veta vilken bild den ska plocka
                    string Format = GetString(k.klient);

                    // Den plockar bilden
                    Image img = Image.FromFile("Data/" + OrderNr + "." + Format);

                    MemoryStream ms = new MemoryStream();

                    // Bilden omvandlas till en stream 
                    img.Save(ms, img.RawFormat);

                    // Stream omvandlas till en byte fält för att skickas till klienten
                    var ImgByte = ms.ToArray();
                    img.Dispose();
                    
                    // Storleken på bilden skickas till klienten
                    sendInt(k.klient, ImgByte.Length);
                    Thread.Sleep(30);
                    // byte fältet med bilden skickas sen till användaren
                    k.klient.GetStream().Write(ImgByte, 0, ImgByte.Length);
                    Thread.Sleep(30);
                }
                else if (type == DataType.SetImage)
                {
                    int OrderNr = GetInt(k.klient);

                    sendInt(k.klient, 3);

                    string Format = GetString(k.klient);

                    sendInt(k.klient, 3);

                    int Lenght = GetInt(k.klient);

                    sendInt(k.klient, 3);
                    try
                    {
                        byte[] ImgByte = new byte[Lenght * 2];

                        k.klient.GetStream().Read(ImgByte, 0, ImgByte.Length);


                        MemoryStream ms = new MemoryStream(ImgByte);


                        Image img = Image.FromStream(ms);

                        if (File.Exists("Data/" + OrderNr + "." + Format))
                        {
                            File.Delete("Data/" + OrderNr + "." + Format); 
                        }
                        if (Format.Equals("jpg"))
                        {
                            img.Save("Data/" + OrderNr + "." + Format, ImageFormat.Jpeg);
                        }else if (Format.Equals("png"))
                        {
                            img.Save("Data/" + OrderNr + "." + Format, ImageFormat.Png);
                        }
                        k.fel = Fel.NO;
                        sendInt(k.klient, (int)k.fel);
                    }
                    catch (ExternalException)
                    {
                        k.fel = Fel.NO;
                        sendInt(k.klient, (int)k.fel);
                    }
                    catch (Exception error)
                    {

                        k.fel = Fel.YES;
                        k.FelMedelande = error.ToString();
                        sendInt(k.klient, (int)k.fel);
                        sendString(k.klient, k.FelMedelande);
                    }
                }
                else if (type == DataType.Check)
                {
                    string StudentName = GetString(k.klient);
                    sendString(k.klient, StudentName);
                    string Password = GetString(k.klient);

                    bool Finns = DataBase.Check(StudentName, Password, k);

                    sendInt(k.klient, (int)k.fel);

                    if (k.fel == Fel.NO)
                    {
                        sendBool(k.klient, Finns);
                    }
                    else
                    {
                        sendString(k.klient, k.FelMedelande);
                    }
                }else if (type == DataType.GetLastOrder)
                {
                    int order = DataBase.GetLastOrder(k);

                    sendInt(k.klient, (int)k.fel);

                    GetInt(k.klient);
                    if (k.fel == Fel.NO)
                    {
                        sendInt(k.klient, order);
                    }
                    else
                    {
                        sendString(k.klient, k.FelMedelande);
                    }
                }
                lbx_listan.Items.Add((int)type);
                Lyssna(k);
            }
            catch (Exception)
            {
                klienter.Remove(k);
            }
            
        }



        public async void sendInt(TcpClient k, int num)
        {
            try
            {
                byte[] sendData = BitConverter.GetBytes(num);
                await k.GetStream().WriteAsync(sendData, 0, sendData.Length);
            }catch(Exception)
            {

            }
            
            
        }

        public async void sendString(TcpClient k, string text)
        {
            try
            {
                byte[] sendData = Encoding.Unicode.GetBytes(text);
                await k.GetStream().WriteAsync(sendData, 0, sendData.Length);
            }
            catch (Exception)
            {
        
            }

        }
        public int GetInt(TcpClient k)
        {
            int num = 0;
            try
            {
                byte[] recieveData = new byte[1000];
                k.GetStream().Read(recieveData, 0, recieveData.Length);
                num = BitConverter.ToInt32(recieveData, 0);
            }
            catch (Exception)
            {
               
            }

            return num;

        
        }

        public string GetString(TcpClient k)
        {
            string text = "";
            try
            {
                byte[] recieveData = new byte[1000];
                int n = k.GetStream().Read(recieveData, 0, recieveData.Length);
                text = Encoding.Unicode.GetString(recieveData, 0, n);
            }
            catch (Exception)
            {
              
            }


            return text;
        }
        public async void sendBool(TcpClient k, bool Bool)
        {
            try
            {
                byte[] sendData = BitConverter.GetBytes(Bool);
                await k.GetStream().WriteAsync(sendData, 0, sendData.Length);
            }
            catch (Exception)
            {
            
            }

        }

        private void lbx_listan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
