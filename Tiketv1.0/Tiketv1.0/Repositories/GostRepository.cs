using DBLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiketv1._0.Models;

namespace Tiketv1._0.Repositories
{
    public class GostRepository
    {
        public static Gost GetGost(int id) //Dohvacanje gosta po id-u
        {
            Gost gost = null;

            string sql = $"SELECT * FROM Gost WHERE Id = {id}";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            if (reader.HasRows)
            {
                reader.Read();
                gost = CreateObject(reader);
                reader.Close();
            }

            DB.CloseConnection();
            return gost;
        }

        public static List<Gost> GetGosti() //Dohvacanje svih gostiju iz baze
        {
            var gosti = new List<Gost>(); //Instanciranje liste za tip Gost

            string sql = "SELECT * FROM Gosti "; //Dohavaca sve iz tablice Gost
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Gost gost = CreateObject(reader); //Cita podatke iz baze, metoda je implementirana ispod ove
                gosti.Add(gost);
            }

            reader.Close();
            DB.CloseConnection();

            return gosti;
        }

        private static Gost CreateObject(SqlDataReader reader) //Citanje podataka iz baze
        {
            int id = int.Parse(reader["Id"].ToString());
            string ime = reader["Ime"].ToString();
            string prezime = reader["Prezime"].ToString();
            int oib = int.Parse(reader["OIB"].ToString());
            string vrstaSmjestaja = reader["VrstaSmjestaja"].ToString();
            int brojOsobaUSmjestaju = int.Parse(reader["BrojOsobaUSmjestaju"].ToString());
            int pozicijaSmjestaja = int.Parse(reader["PozicijaSmjestaja"].ToString());

            var gost = new Gost
            {
                Id = id,
                Ime = ime,
                Prezime = prezime,
                OIB = oib,
                VrstaSmjestaja = vrstaSmjestaja,
                BrojOsobaUSmjestaju = brojOsobaUSmjestaju,
                PozicijaSmjestaja = pozicijaSmjestaja
            };

            return gost;
        }

    }
}
