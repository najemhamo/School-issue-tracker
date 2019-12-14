using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerFinalApp
{
    
    // Klassen DataBase tar datan från databasen
    class DataBase
    {
        // Metoden SetNewOrd lägger ett nytt order och returnerar det nya orderns nummer
        // Metoden tar en klass Klient
        public static int SetNewOrd(Klient k)
        {
            int number = 0;
            try
            {
                using (var db = new SkolOrderEntities())
                {
                    // Den här loopen kollar vilken order är den sista för att sätta den nya orderns
                    foreach (Order o in db.Order)
                    {
                        if (o.OrderNr >= number)
                        {
                            number = o.OrderNr + 1;
                        }
                    }
                    if(number == 0) { number = 1; }

                    db.Order.Add(new Order() { OrderNr = number, Prioritet = 4, Börjat = "Nej" });
                    db.SaveChanges();

                    
                }
                // Om allt går bra så sätts enum Fel i klassen Klient till NO
                k.fel = Fel.NO;
            }
            catch (Exception error)
            {
                // Om ett fel händer så sätts enum Fel till YES och felmedelandet sparas i string FelMedelande i klassen Klient  
                k.fel = Fel.YES;
                k.FelMedelande = error.Message;
            }
            return number;
        }
        // Metoden GetDataFromOrder tar emot ett order nummer och returnerar ett string fält med allt data som ordern innehåller  
        public static string[] GetDataFromOrder(int ordNr, Klient k)
        {
            string[] Data = new string[7];

            try
            {
                using (var db = new SkolOrderEntities())
                {
                    // urval innehåller ordern med den ordernummret
                    var urval = from ord in db.Order where ord.OrderNr == ordNr select ord;

                    Data[0] = urval.First().OrderNr.ToString();
                    Data[1] = urval.First().Ansvarig;
                    Data[2] = urval.First().Avdelning;
                    Data[3] = urval.First().Prioritet.ToString();
                    Data[4] = urval.First().Börjat;
                    Data[5] = urval.First().Klar.ToString();
                    Data[6] = urval.First().BildFormat;
                }
                // Om allt går bra så sätts enum Fel i klassen Klient till NO
                k.fel = Fel.NO;
            }
            catch (Exception error)
            {
                // Om ett fel händer så sätts enum Fel till YES och felmedelandet sparas i string FelMedelande i klassen Klient  
                k.fel = Fel.YES;
                k.FelMedelande = error.Message;
            }
            return Data;
        }
        // Metoden SetDataToOrder tar datan som ett fält och tar ordernummret också och lägger de i databasen.
        public static void SetDataToOrder(int ordNr, string[] data, Klient k)
        {
            try
            {
                using (var db = new SkolOrderEntities())
                {
                    // Den väljer ordern som har den ordernummer som är angivet i metoden
                    var urval = from ord in db.Order where ord.OrderNr == ordNr select ord;

                    if (!data[1].Equals("")) { urval.First().Ansvarig = data[1]; }
                    if (!data[2].Equals("")) { urval.First().Avdelning = data[2]; }
                    urval.First().Prioritet = int.Parse(data[3]);
                    urval.First().Börjat = data[4];
                    if (!data[5].Equals(""))
                    {
                        urval.First().Klar = DateTime.Parse(data[5]);
                    }
                    if (!data[6].Equals("F"))
                    {
                        urval.First().BildFormat = data[6];
                    }
                    db.SaveChanges();
                }
                // Om allt går bra så sätts enum Fel i klassen Klient till NO
                k.fel = Fel.NO;
                   
            }
            catch (Exception error)
            {
                // Om ett fel händer så sätts enum Fel till YES och felmedelandet sparas i string FelMedelande i klassen Klient  
                k.fel = Fel.YES;
                k.FelMedelande = error.Message;
            }
        }
        // Metoden GetStudents returnerar alla studenter med deras lösenord som en string dubbel array
        public static string[,] GetStudents(Klient k)
        {
            string[,] Data = new string[0, 2];
            try
            {
                using (var db = new SkolOrderEntities())
                {

                    Data = new string[db.Elever.Count(), 2];

                    var urval = from elev in db.Elever select elev;

                    int i = 0;
                    // Vi går igenom eleverna och sätter delas namn och lösenord i fältet
                    foreach (Elever elev in urval)
                    {
                        Data[i, 0] = elev.ElevNamn;
                        Data[i, 1] = elev.Losenord;
                        i++;
                    }
                }
                // Om allt går bra så sätts enum Fel i klassen Klient till NO
                k.fel = Fel.NO;
            }
            catch (Exception error)
            {
                // Om ett fel händer så sätts enum Fel till YES och felmedelandet sparas i string FelMedelande i klassen Klient  
                k.fel = Fel.YES;
                k.FelMedelande = error.Message;
            }

            return Data;
        }

        // GetPlaces returnerar alla avdelningar som finns i databasen som en string fält
        public static string[] GetPlaces(Klient k)
        {
            string[] Data = new string[0];
            try
            {
                using (var db = new SkolOrderEntities())
                {
                    Data = new string[db.Avdelningar.Count()];

                    var urval = from avdelning in db.Avdelningar select avdelning;

                    int i = 0;
                    foreach (Avdelningar avdelning in urval)
                    {
                        Data[i] = avdelning.Plats;
                        i++;
                    }
                }
                // Om allt går bra så sätts enum Fel i klassen Klient till NO
                k.fel = Fel.NO;

            }
            catch (Exception error)
            {
                // Om ett fel händer så sätts enum Fel till YES och felmedelandet sparas i string FelMedelande i klassen Klient  
                k.fel = Fel.YES;
                k.FelMedelande = error.Message;
            }

            return Data;
        }
        // Metoden GetAllOrder 
        public static string[,] GetAllOrder(Klient k)
        {
            string[,] Data = new string[0, 7];
            try
            {
                using (var db = new SkolOrderEntities())
                {
                    Data = new string[db.Order.Count(), 7];

                    var urval = from order in db.Order select order;

                    int i = 0;
                    foreach (Order ord in urval)
                    {
                        Data[i, 0] = ord.OrderNr.ToString();
                        Data[i, 1] = ord.Ansvarig;
                        Data[i, 2] = ord.Avdelning;
                        Data[i, 3] = ord.Prioritet.ToString();
                        Data[i, 4] = ord.Börjat;
                        Data[i, 5] = ord.Klar.ToString();
                        Data[i, 6] = ord.BildFormat;

                        i++;
                    }
                }
                // Om allt går bra så sätts enum Fel i klassen Klient till NO
                k.fel = Fel.NO;
            }
            catch (Exception error)
            {
                // Om ett fel händer så sätts enum Fel till YES och felmedelandet sparas i string FelMedelande i klassen Klient  
                k.fel = Fel.YES;
                k.FelMedelande = error.Message;
            }

            return Data;

        }
        public static int[] GetStudentOrder(string StudentName, Klient k)
        {
            int[] Data = new int[0];
            try
            {
                using (var db = new SkolOrderEntities())
                {
                    var urval = from elev in db.Elever where elev.ElevNamn.Equals(StudentName) from order in elev.Order select order;

                    Data = new int[urval.Count()];
                    int i = 0;

                    foreach (Order ord in urval)
                    {
                        Data[i] = ord.OrderNr;
                        i += 1;
                    }
                }
                // Om allt går bra så sätts enum Fel i klassen Klient till NO
                k.fel = Fel.NO;

                // Om eleven har inga ordrar sätts Fel till YES och FelMedelande till F
                if (Data.Length == 0)
                {

                    k.fel = Fel.YES;
                    k.FelMedelande = "F";
                }
                
            }
            catch (Exception error)
            {
                // Om ett fel händer så sätts enum Fel till YES och felmedelandet sparas i string FelMedelande i klassen Klient  
                k.fel = Fel.YES;
                k.FelMedelande = error.Message;
            }

            return Data;

        }

        public static int[] GetPlaceOrder(string Avdelning, Klient k)
        {
            int[] Data = new int[0];
            try
            {
                using (var db = new SkolOrderEntities())
                {
                    var urval = from avdelning in db.Avdelningar where avdelning.Plats.Equals(Avdelning) from order in avdelning.Order select order;

                    Data = new int[urval.Count()];
                    int i = 0;

                    foreach (Order ord in urval)
                    {
                        Data[i] = ord.OrderNr;
                        i += 1;
                    }
                }
                // Om allt går bra så sätts enum Fel i klassen Klient till NO
                k.fel = Fel.NO;

                if (Data.Length == 0)
                {
                    k.fel = Fel.YES;
                    k.FelMedelande = "F";
                }
            }
            catch (Exception error)
            {
                // Om ett fel händer så sätts enum Fel till YES och felmedelandet sparas i string FelMedelande i klassen Klient  
                k.fel = Fel.YES;
                k.FelMedelande = error.Message;
            }

            return Data;

        }

        public static void AddStudent(string StudentName, string Password , Klient k)
        {
            try
            {
                using (var db = new SkolOrderEntities())
                {
                    var urval = from elevv in db.Elever where elevv.ElevNamn.Equals(StudentName) select elevv;

                    if (urval.Count() == 0)
                    {
                        Elever elev = new Elever();
                        elev.ElevNamn = StudentName;
                        elev.Losenord = Password;

                        db.Elever.Add(elev);
                        db.SaveChanges();
                    }
                    else
                    {
                        urval.First().Losenord = Password;
                        db.SaveChanges();
                    }
                }

                // Om allt går bra så sätts enum Fel i klassen Klient till NO
                k.fel = Fel.NO;
            }
            catch (Exception error)
            {
                // Om ett fel händer så sätts enum Fel till YES och felmedelandet sparas i string FelMedelande i klassen Klient  
                k.fel = Fel.YES;
                k.FelMedelande = error.Message;
            }

        }
        
        public static void AddPlace(string place, Klient k)
        {
            try
            {
                using (var db = new SkolOrderEntities())
                {
                    Avdelningar avdelning = new Avdelningar();
                    avdelning.Plats = place;

                    db.Avdelningar.Add(avdelning);
                    db.SaveChanges();
                }
                // Om allt går bra så sätts enum Fel i klassen Klient till NO
                k.fel = Fel.NO;
            }
            catch (Exception error)
            {
                // Om ett fel händer så sätts enum Fel till YES och felmedelandet sparas i string FelMedelande i klassen Klient  
                k.fel = Fel.YES;
                k.FelMedelande = error.Message;
            }

        }
        public static int GetOrderCount(Klient k)
        {
            int order = 0;
            try
            {
                using (var db = new SkolOrderEntities())
                {
                    order = db.Order.Count();
                }
                // Om allt går bra så sätts enum Fel i klassen Klient till NO
                k.fel = Fel.NO;
            }
            catch (Exception error)
            {
                // Om ett fel händer så sätts enum Fel till YES och felmedelandet sparas i string FelMedelande i klassen Klient  
                k.fel = Fel.YES;
                k.FelMedelande = error.ToString();
            }
            return order;
        }
        public static int GetLastOrder(Klient k)
        {
            int order = 0;
            try
            {
                using (var db = new SkolOrderEntities())
                {
                    foreach(Order o in db.Order)
                    {
                        if(o.OrderNr > order)
                        {
                            order = o.OrderNr;
                        }
                    }
                }
                // Om allt går bra så sätts enum Fel i klassen Klient till NO
                k.fel = Fel.NO;
            }
            catch (Exception error)
            {
                // Om ett fel händer så sätts enum Fel till YES och felmedelandet sparas i string FelMedelande i klassen Klient  
                k.fel = Fel.YES;
                k.FelMedelande = error.ToString();
            }
            return order;
        }
        public static void DeletePlace(string place , Klient k)
        {
            try
            {
                using (var db = new SkolOrderEntities())
                {
                   

                        var Place = from avdelning in db.Avdelningar where avdelning.Plats.Equals(place) select avdelning;
                        db.Avdelningar.Remove(Place.First());
                        db.SaveChanges();
                    
                }
                // Om allt går bra så sätts enum Fel i klassen Klient till NO
                k.fel = Fel.NO;
            }
            catch (DbUpdateException)
            {
                // Om avdelningen har ett order sätts enum Fel i klassen Klient till YES.
                string Medelande = "Fel. Du kan inte ta bort en avdelning för att en order är registerad med denna avdelning";
                k.fel = Fel.YES;
                k.FelMedelande = Medelande;
            }
            catch (Exception error)
            {
                // Om ett fel händer så sätts enum Fel till YES och felmedelandet sparas i string FelMedelande i klassen Klient  
                k.fel = Fel.YES;
                k.FelMedelande = error.Message;
            }
        }

        public static void DeleteOrder(int OrderNr,Klient k)
        {
            try
            {
                using (var db = new SkolOrderEntities())
                {
                    
                        var Order = from order in db.Order where order.OrderNr == OrderNr select order;
                        db.Order.Remove(Order.First());
                        db.SaveChanges();

                    // Om allt går bra så sätts enum Fel i klassen Klient till NO
                    k.fel = Fel.NO;

                }
            }
            catch (Exception error)
            {
                // Om ett fel händer så sätts enum Fel till YES och felmedelandet sparas i string FelMedelande i klassen Klient  
                k.fel = Fel.YES;
                k.FelMedelande = error.Message;
            }
        }
        public static void DeleteStudent(string StudentName,Klient k)
        {
            try
            {
                using (var db = new SkolOrderEntities())
                {
                   
                        var Student = from student in db.Elever where student.ElevNamn.Equals(StudentName) select student;
                        db.Elever.Remove(Student.First());
                        db.SaveChanges();

                    // Om allt går bra så sätts enum Fel i klassen Klient till NO
                    k.fel = Fel.NO;
                }
            }
            catch (DbUpdateException)
            {
                // Om eleven har ett order sätts enum Fel i klassen Klient till YES.
                string Medelande = "Fel. Du kan inte ta bort den eleven för att eleven har en order";
                k.fel = Fel.YES;
                k.FelMedelande = Medelande;
            }
            catch (Exception error)
            {
                // Om ett fel händer så sätts enum Fel till YES och felmedelandet sparas i string FelMedelande i klassen Klient  
                k.fel = Fel.YES;
                k.FelMedelande = error.Message;
            }
        }

        public static bool OrderExist(int OrderNr, Klient k)
        {
            bool exist = false;
            try
            {
                using (var db = new SkolOrderEntities())
                {
                    var Order = from order in db.Order where order.OrderNr == OrderNr select order;
                    if (Order.Count() == 1)
                    {
                        exist = true;
                    }
                    // Om allt går bra så sätts enum Fel i klassen Klient till NO
                    k.fel = Fel.NO;
                }
            }
            catch (Exception error)
            {
                // Om ett fel händer så sätts enum Fel till YES och felmedelandet sparas i string FelMedelande i klassen Klient  
                k.fel = Fel.YES;
                k.FelMedelande = error.Message;
            }

            return exist;
        }

        // Den här metoden tar studentens namn och ger tillbaka namnet och lösenordet om det finns
        public static string[] GetStudent(string ElevNamn, Klient k)
        {
            string[] student =  new string[1];

            try
            {
                using (var db = new SkolOrderEntities())
                {
                    var Student = from elev in db.Elever where elev.ElevNamn.Equals(ElevNamn) select elev;
                    if (Student.Count() == 0)
                    {

                    }
                    else
                    {
                        student = new string[2];
                        student[0] = Student.First().ElevNamn;
                        student[1] = Student.First().Losenord;
                    }

                    // Om allt går bra så sätts enum Fel i klassen Klient till NO
                    k.fel = Fel.NO;
                }
            }
            catch (Exception error)
            {
                // Om ett fel händer så sätts enum Fel till YES och felmedelandet sparas i string FelMedelande i klassen Klient  
                k.fel = Fel.YES;
                k.FelMedelande = error.Message;
            }
            return student;
        }

        // Metoden tar Avdelnings namnet och ger tillbaka namnet om det finns
        public static string GetPlace(string AvdelningPlace, Klient k)
        {
            string plats = "No";

            try
            {
                using (var db = new SkolOrderEntities())
                {
                    var Avdelning = from avdelning in db.Avdelningar where avdelning.Plats.Equals(AvdelningPlace) select avdelning;
                    if (Avdelning.Count() == 0)
                    {

                    }
                    else
                    {
                        plats = Avdelning.First().Plats;
                    }

                    // Om allt går bra så sätts enum Fel i klassen Klient till NO
                    k.fel = Fel.NO;
                }
            }
            catch (Exception error)
            {
                // Om ett fel händer så sätts enum Fel till YES och felmedelandet sparas i string FelMedelande i klassen Klient  
                k.fel = Fel.YES;
                k.FelMedelande = error.Message;
            }
            return plats;
        }
        // Metoden tar studentens namn och lösenord och returnerar en bool, true om det finns och false om det inte finns
        public static bool Check(string StudentName,string Password, Klient k)
        {
            bool finns = false;

            try
            {
                using (var db = new SkolOrderEntities())
                {
                    var Student = from elev in db.Elever where elev.ElevNamn == StudentName && elev.Losenord == Password select elev;

                    if(Student.Count() == 1)
                    {
                        finns = true;
                    }

                    // Om allt går bra så sätts enum Fel i klassen Klient till NO
                    k.fel = Fel.NO;
                }
            }
            catch (Exception error)
            {
                // Om ett fel händer så sätts enum Fel till YES och felmedelandet sparas i string FelMedelande i klassen Klient  
                k.fel = Fel.YES;
                k.FelMedelande = error.Message;
            }
            return finns;
        }
    }
}
