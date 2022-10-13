using MySql.Data.MySqlClient;
using System;

namespace ScilyLinesMission2
{ 
        public class ConnexionSql

        {

            // Variable locale pour stocker usne référence vers l'instance
            private static ConnexionSql connection = null;

            private MySqlConnection mySqlCn;
            private static readonly object mylock = new object();



            public ConnexionSql(string unProvider, string uneDataBase, string unUid, string unMdp)
            {

                try
                {
                    string connString;
                    connString = "SERVER=" + unProvider + ";" + "DATABASE=" +
                    uneDataBase + ";" + "UID=" + unUid + ";" + "PASSWORD=" + unMdp + ";";
                    try
                    {
                        mySqlCn = new MySqlConnection(connString);
                    }
                    catch (Exception emp)
                    {
                        throw (emp);
                    }
                }
                catch (Exception emp)
                {
                    throw (emp);
                }
            }

            /**
            * méthode de création d'une instance de connexion si elle n'existe pas (singleton)
            */
            public static ConnexionSql getInstance(string unProvider, string uneDataBase, string
           unUid, string unMdp)
            {
                lock ((mylock))
                {

                    try
                    {

                        if (null == connection)
                        { // Premier appel
                            connection = new ConnexionSql(unProvider, uneDataBase, unUid, unMdp);
                        }
                    }
                    catch (Exception emp)
                    {

                        throw (emp);
                    }
                    return connection;
                }
            }

            /**
            * Ouverture de la connexion
            */
            public void openConnection()
            {
                try
                {
                    mySqlCn.Open();
                }
                catch (Exception emp)
                {
                    throw (emp);
                }
            }
            /**
            * Fermeture de la connexion
            */
            public void closeConnection()
            {
                mySqlCn.Close();
            }
            /**
            * Exécution d'une requête
            */
            public MySqlCommand reqExec(string req)
            {
                MySqlCommand mysqlCom = new MySqlCommand(req, this.mySqlCn);
                return (mysqlCom);
            }
        }
    }
