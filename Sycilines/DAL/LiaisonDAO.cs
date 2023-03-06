using MySql.Data.MySqlClient;
using ScilyLinesMission2;
using Sycilines.Modele;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Sycilines.DAL
{
    public class LiaisonDAO
    {
        // attributs de connexion statiques
        private static string provider = "localhost";

        private static string dataBase = "sycilines";

        private static string uid = "connexionBDD";

        private static string mdp = "f9(5HttDX0wXqA-R";



        private static ConnexionSql maConnexionSql;


        private static MySqlCommand commande;


        public static List<Liaison> chargementLiaisonSecteur(Secteur secteur)
        {
            List<Liaison> listeLiaison = new List<Liaison>();
            ConnexionSql connexion = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
            connexion.openConnection();
            // Requête qui donne les ports d'arrivées des liaisons du secteur séléctionné
            MySqlCommand liaisonCommande = connexion.reqExec("select P.nom from port P join liaison L On P.id = L.portDepart JOIN secteur S on S.id = L.idSecteur where S.id = " + secteur.getId());
            MySqlDataReader resultLiaison = liaisonCommande.ExecuteReader();
            List<string> listeDepart = new List<string>();
            if (resultLiaison.HasRows) // Condition qui permet de lire chaque element de ligne
            {
                while (resultLiaison.Read())
                {
                    listeDepart.Add(resultLiaison.GetString(0));
                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }
            resultLiaison.Close();
            MySqlCommand liaisonCommande2 = connexion.reqExec("select P.nom from port P join liaison L On P.id = L.portArrivee JOIN secteur S on S.id = L.idSecteur where S.id = " + secteur.getId());
            MySqlDataReader resultLiaison2 = liaisonCommande2.ExecuteReader();
            List<string> listeArrivee = new List<string>();
            if (resultLiaison2.HasRows) // Condition qui permet de lire chaque element de ligne
            {
                while (resultLiaison2.Read())
                {
                    listeArrivee.Add(resultLiaison2.GetString(0));
                }
            }
            else
            {
                Console.WriteLine("No rows found.");
            }
            resultLiaison2.Close();
            MySqlCommand liaisonCommande3 = connexion.reqExec("select id, duree from liaison where S.id = " + secteur.getId()) ;
            MySqlDataReader resultLiaison3 = liaisonCommande2.ExecuteReader();
            int i = 0;
            if (resultLiaison3.HasRows) // Condition qui permet de lire chaque element de ligne
            {
                while (resultLiaison3.Read())
                {
                    int id = (int)resultLiaison3.GetValue(0);
                    string duree = (string)resultLiaison.GetValue(1);
                    
                    Liaison liaison = new Liaison(id, duree, listeDepart[i], listeArrivee[i], secteur.getId());
                    
                    listeLiaison.Add(liaison);
                    i++;

                }
            }
            //fermeture de la connextion
            connexion.closeConnection();

            return listeLiaison;
        }
    } 

}
