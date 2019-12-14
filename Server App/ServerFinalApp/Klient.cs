using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerFinalApp
{
    // enum Fel har två värden YES eller NO
    public enum Fel {YES,NO};

    // Klassen klient innehåller TcpClient för klienten och en Fel enum och felmedelandet
    // Klassen är gjort för fel hantering
    public class Klient
    {
        public TcpClient klient;
        public Fel fel;
        public string FelMedelande;
    }
}
