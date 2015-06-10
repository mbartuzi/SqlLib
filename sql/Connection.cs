using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace sql
{
    class Connection
    {
        static string str_con =            "user id=John;" +
                                           "password=jakiestam;server=JOHN-PC\\SQLEXPRESS;" +
                                           "Trusted_Connection=yes;" +
                                           "database=testowa; " +
                                           "connection timeout=15";
        SqlConnection bibliotekaConnection = new SqlConnection(str_con);

        public void connect() {
            try
            {
                bibliotekaConnection.Open();
                MessageBox.Show("Próba połączenia z bazą zakończona powodzeniem");
            }
            catch
            {
               MessageBox.Show("Połączenie z bazą danych nie powiodło się");
            }      
        
        }

        public void insert(string tabela, string [] kolumny, string []values) {
            try{
                string tabele = "";
                for (int i = 0; i < kolumny.Length; i++) {
                    tabele += kolumny[i] + ", ";
                }
                string wartosci = "";
                for (int i = 0; i < values.Length; i++){
                    wartosci += "'"+values[i]+"', ";
                }

                SqlCommand myCommand = new SqlCommand("INSERT INTO "+tabela+" ("+tabele+") " +
                                            "Values ("+wartosci+")", bibliotekaConnection);
                 myCommand.ExecuteNonQuery();
                 MessageBox.Show("Zapytanie zostało wysłane poprawnie");
               }
               catch
               {
                   MessageBox.Show("Wysłanie zapytania do bazy nie powiodło się");
               }
        
        }

        public string[] getSingleColumn(string tabela, string kolumna) {
            List<string> tab = new List<string>();

 
            string[] ret = tab.ToArray();
            try
            {
                    SqlCommand myCommand = new SqlCommand("SELECT " + kolumna + " FROM " + tabela, bibliotekaConnection);
                    try
                    {
                        bibliotekaConnection.Open();
                        MessageBox.Show("Próba połączenia z bazą zakończona powodzeniem");
                    }
                    catch
                    {
                        MessageBox.Show("Połączenie z bazą danych nie powiodło się");
                    }

                    try
                    {
                        SqlDataReader sqlReader = myCommand.ExecuteReader();

                        while (sqlReader.Read())
                        {
                            tab.Add(sqlReader[kolumna].ToString());
                        }
                        ret = tab.ToArray();
                        MessageBox.Show("Zapytanie zostało wysłane poprawnie");
                        return ret;
                    }
                    catch
                    {
                        ret[0] = "znowu";
                        return ret;
                    }

            }
            catch
            {
                string[] error = {"Błąd połączenia"};
                MessageBox.Show("Wysłanie zapytania do bazy nie powiodło się\n"+ret);
                return error;
            }
        }



        public void wyslij(string tabela) {
            /* getting column's names */
            string query = "SELECT COLUMN_NAME FROM testowa.INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'autorzy'";
        
        
        
        }

    }
}
