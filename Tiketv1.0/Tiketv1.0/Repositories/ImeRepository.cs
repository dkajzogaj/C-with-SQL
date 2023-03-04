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
    public class ImeRepository
    {
        public static Gost DohvatiIme(int id)
        {
            Gost gost = null;
            string sql = $"SELECT Ime FROM Gosti WHERE Id = {id}";
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

        public static List<Gost> DohvatiImena()
        {
            List<Gost> gosti = new List<Gost>();
            string sql = "SELECT * FROM Gosti";
            DB.OpenConnection();
            var reader = DB.GetDataReader(sql);
            while (reader.Read())
            {
                Gost activity = CreateObject(reader);
                gosti.Add(activity);
            }
            reader.Close();
            DB.CloseConnection();
            return gosti;

        }

        private static Gost CreateObject(SqlDataReader reader)
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

