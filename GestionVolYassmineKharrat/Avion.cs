using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionVolYassmineKharrat
{
    internal class Avion
    {
        String reference,marque;
        int nbpassagers;
        bool disponible;
        static List<Avion> lesAvions = new List<Avion>();

        public string Reference { get => reference; set => reference = value; }
        public string Marque { get => marque; set => marque = value; }
        public int Nbpassagers { get => nbpassagers; set => nbpassagers = value; }
        public bool Disponible { get => disponible; set => disponible = value; }
        internal static List<Avion> LesAvions { get => lesAvions; set => lesAvions = value; }

        public Avion(string reference, string marque, int nbpassagers, bool disponible)
        {
            this.reference = reference;
            this.marque = marque;
            this.nbpassagers = nbpassagers;
            this.disponible = disponible;
        }
        public override string ToString()
        {
            return reference + "|" + marque + "|" + nbpassagers + "|" + disponible;
        }
    }
}
