using MySql.Data.MySqlClient;
using ScilyLinesMission2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sycilines.Vue
{
    public partial class Supprimer : Form
    {
        private int idLiaison;

        public Supprimer(int liaison)
        {
            InitializeComponent();
            this.idLiaison = liaison;
        }

        public int suppressionLiaison()
        {
            ConnexionSql connexion = ConnexionSql.getInstance("localhost", "sycilines", "connexionBDD", "f9(5HttDX0wXqA-R");
            //Requête effectuant la suppresion
            MySqlCommand suppression = connexion.reqExec("Delete from liaison where id=" + this.idLiaison);
            connexion.openConnection();
            int count = suppression.ExecuteNonQuery();
            connexion.closeConnection();
            return count;
        }

        private void suppr_Load(object sender, EventArgs e)
        {
            
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void suppr_Click(object sender, EventArgs e)
        {
            int count = this.suppressionLiaison(); //Appel à la méthode de suppression
            if (count != 0)
            {
                confirmLiaison conf = new confirmLiaison("La liaison a été supprimé.");
                this.Close();
                conf.ShowDialog();
            }
            else
            {
                confirmLiaison conf = new confirmLiaison("Aucune suppréssion n'a été réalisé");
                this.Close();
                conf.ShowDialog();
            }
            
        }
    }
}
