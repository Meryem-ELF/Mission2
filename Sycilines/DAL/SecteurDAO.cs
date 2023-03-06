using MySql.Data.MySqlClient;
using ScilyLinesMission2;
using Sycilines.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sycilines.DAL
{
    public class SecteurDAO
    {
        // attributs de connexion statiques
        private static string provider = "localhost";

        private static string dataBase = "sycilines";

        private static string uid = "connexionBDD";

        private static string mdp = "f9(5HttDX0wXqA-R";



        private static ConnexionSql maConnexionSql;


        private static MySqlCommand commande;

        //Chargement secteur
        public static List<Secteur> chargementSecteur()
        {
            List<Secteur> listeSecteur = new List<Secteur>();
            ConnexionSql connexion = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
            connexion.openConnection();
            MySqlCommand secteurCommande = connexion.reqExec("select id,nom from secteur"); //Requête affichant tous les secteurs
            MySqlDataReader secteur = secteurCommande.ExecuteReader(); //Requete renvoyant plusieurs résultat
            if (secteur.HasRows) //Condition vérifiant si la requête possèdes des résultats
            {
                while (secteur.Read()) //On va lire chaque ligne
                {
                    int id = (int)secteur.GetValue(0);
                    string nom = (string)secteur.GetValue(1);

                    Secteur s = new Secteur(id, nom);

                    listeSecteur.Add(s);
                }
            }
            secteur.Close();
            connexion.closeConnection();

            return listeSecteur;
        }
    }
}
