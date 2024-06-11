using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeLearning
{
    internal class Fasada
    {
        private readonly Podsystem1 _podsystem1;
        private readonly Podsystem2 _podsystem2;

        public Fasada(Podsystem1 podsystem1, Podsystem2 podsystem2)
        {
            _podsystem1 = podsystem1;
            _podsystem2 = podsystem2;
        }

        public string Operacja()
        {
            string wiadomosc = "Rozpoczecie operacji w podsystemie numer 1";
            wiadomosc += _podsystem1.Operacja1();
            wiadomosc += _podsystem1.Operacja2();
            wiadomosc += "\nRozpoczecie operacji w podsystemie numer 2";
            wiadomosc += _podsystem2.Operacja1();
            wiadomosc += _podsystem2.Operacja2();
            wiadomosc += "\nZakonczenie wszystkich operacji";
            return wiadomosc;
        }
    }
}
