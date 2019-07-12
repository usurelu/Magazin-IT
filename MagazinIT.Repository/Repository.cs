using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MagazinIT.Repository
{
    public class Repository
    {
        //public Repository()
        //{ se extrag toate datele din baza de date
        //}
        SqlConnection cs = new SqlConnection("Data Source =  DANY\\SQLEXPRESS; Initial Catalog = MagazinIT;Integrated Security = True");
        public DataSet getAll()
        {
            SqlConnection cs = new SqlConnection("Data Source =  DANY\\SQLEXPRESS; Initial Catalog = MagazinIT;Integrated Security = True");
            cs.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter produseAdaptor = new SqlDataAdapter("select * from Produse", cs);
            produseAdaptor.Fill(ds, "produse");
            cs.Close();
            return ds;
            
        }/// <summary>
        /// se umple comboboxul cu tipul produselor din baza de date
        /// </summary>
        /// <returns></returns>
        public SqlDataReader Fill()
        {
            SqlConnection cs = new SqlConnection("Data Source =  DANY\\SQLEXPRESS; Initial Catalog = MagazinIT;Integrated Security = True");
            cs.Open();
            SqlCommand Query = new SqlCommand("SELECT DISTINCT type FROM Produse", cs);
            SqlDataReader reader = Query.ExecuteReader();
            return reader;
        }/// <summary>
        /// sortare dupa tipul produselor
        /// </summary>
        /// <param name="Type"></param>
        /// <returns></returns>
       public DataSet sort(String Type)
        {
            SqlConnection cs = new SqlConnection("Data Source =  DANY\\SQLEXPRESS; Initial Catalog = MagazinIT;Integrated Security = True");
            DataSet ds = new DataSet();
            SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM Produse WHERE type = @type", cs);
            data.SelectCommand.Parameters.Add(new SqlParameter
            {
                ParameterName = "@type",
                Value = Type,
                SqlDbType = SqlDbType.NChar,
                Size = 100  // Assuming a 2000 char size of the field annotation (-1 for MAX)
            });
            data.Fill(ds, "produse");
            return ds;
        }/// <summary>
        /// cumparare produs
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cantitate"></param>
        /// <returns></returns>
        public SqlDataAdapter cumpara(int id, int cantitate)
        {
            cs.Open();
            SqlDataAdapter data = new SqlDataAdapter();
            data.UpdateCommand = new SqlCommand("UPDATE Produse SET quantity=@quantity WHERE id = @id", cs);
            data.UpdateCommand.Parameters.Add(new SqlParameter
            {
                ParameterName = "@id",
                Value = id,
                SqlDbType = SqlDbType.Int,
                Size = 100  // Assuming a 2000 char size of the field annotation (-1 for MAX)
            });
            data.UpdateCommand.Parameters.Add(new SqlParameter
            {
                ParameterName = "@quantity",
                Value = cantitate,
                SqlDbType = SqlDbType.Int,
                Size = 100
            });
            data.UpdateCommand.ExecuteNonQuery();
            cs.Close();
            return data;
        }
    }   
}
