using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sycilines
{
    public class Liaison
    {
        private int id;
        private string duree;
        private string depart;
        private string arrivee;
        private int idSecteur;

        public Liaison(int id, string duree, string depart, string arrivee, int idSecteur)
        {
            this.id = id;
            this.duree = duree;
            this.depart = depart;
            this.arrivee = arrivee;
            this.idSecteur = idSecteur;
        }

        public void setDuree(string duree)
        {
            this.duree = duree;
        }

        public void setDepart(string depart)
        {
            this.depart = depart;
        }

        public void setArrivee(string arrivee)
        {
            this.arrivee=arrivee;
        }

        public string getDuree()
        {
            return this.duree;
        }

        public string getDepart()
        {
            return this.depart;
        }

        public string getArrivee()
        {
            return this.arrivee;
        }

        public int getId()
        {
            return this.id;
        }

        public override string ToString()
        {
            return "La liaison partant de " + this.depart + " en direction de " + this.arrivee + " pour une durée de "+ this.duree;
        }
    }
}
