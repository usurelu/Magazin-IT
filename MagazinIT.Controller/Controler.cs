using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagazinIT.Repository;
using System.Data.SqlClient;
using System.Data;
namespace MagazinIT.Controller
{
    public class Controler
    {
        Repository.Repository rep = new Repository.Repository();
        //public Controler()
        //{
        //}Aduce din baza de date toate inregistrarile
       // SqlConnection cs = new SqlConnection("Data Source =  DANY\\SQLEXPRESS; Initial Catalog = MagazinIT;Integrated Security = True");
        public  DataSet getAll()
        {
            DataSet ds = new DataSet();
            ds = rep.getAll();
            return ds;

        }/// <summary>
        /// Completeaza ComboBoxul cu tipurile produselor
        /// </summary>
        /// <returns></returns>
        public SqlDataReader getFill()
        {
            SqlDataReader reader = rep.Fill();
            return reader;
        }
        /// <summary>
        /// Sorteaza dupa tipul selectat din combobox
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public DataSet sort(string type)
        {
            return rep.sort(type);
        }/// <summary>
        /// Se cumpara produsul
        /// </summary>
        /// <param name="id"></param>
        /// <param name="cantitate"></param>
        /// <returns></returns>
        public SqlDataAdapter cumpara(int id,int cantitate)
        {
            return rep.cumpara(id,cantitate);
        }
    }
}
