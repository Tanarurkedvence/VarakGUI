using System;
using System.Collections.Generic;
using System.Text;

namespace VarakGUI
{
    internal class Var
    {
        public Var(string l)
        {
            var r = l.Split("\t");
            Id = int.Parse(r[0]);
            Nev = r[1];
            Telepules = r[2];
            Megye = r[3];
            Latogato2023 = int.Parse(r[4]);
            Latogato2024 = int.Parse(r[5]);
            Jegyar  = int.Parse(r[6]);
        }

        public int Id { get; set; }
        public string Nev { get; set; }
        public string Telepules { get; set; }
        public string Megye { get; set; }
        public int Latogato2023 { get; set; }
        public int Latogato2024 { get; set; }
        public int Jegyar { get; set; }

    }
}
