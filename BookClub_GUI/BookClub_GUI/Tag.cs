using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookClub_GUI
{
    class Tag
    {
        string csaladnev;
        int id;
        string utonev;

        public Tag(string csaladnev, int id, string utonev)
        {
            this.csaladnev = csaladnev;
            this.id = id;
            this.utonev = utonev;
        }

        public string Csaladnev { get => csaladnev; }
        public int Id { get => id; }
        public string Utonev { get => utonev;}
        public string Nev { get => this.Csaladnev + " " + this.Utonev; }

        public override string ToString()
        {
            return Nev;
        }
    }
}
