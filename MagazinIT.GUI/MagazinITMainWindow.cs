using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using MagazinIT.Controller;
using MagazinIT.Repository;
namespace MagazinIT.GUI
{
    public partial class MagazinITMainWindow : Form
    {
       
       Controler ctr = new Controler();
       SqlConnection cs = new SqlConnection("Data Source =  DANY\\SQLEXPRESS; Initial Catalog = MagazinIT;Integrated Security = True");
        DataSet copieds;
      

        public MagazinITMainWindow()
        {

            InitializeComponent();
            // Application.EnableVisualStyles();
            // Application.SetCompatibleTextRenderingDefault(false);
            //  Application.Run(new MagazinITMainWindow());
            FillCombo();
        }

        void FillCombo()
        {
            cs.Open();
          //  SqlCommand Query = new SqlCommand("SELECT DISTINCT type FROM Produse", cs);
            try
            {
                SqlDataReader reader = ctr.getFill();

                    while (reader.Read())
                    {
                        string stype = reader.GetString(0).Replace(" ","");
                        Type.Items.Add(stype);
                    }
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            cs.Close();

        }
        /// <summary>
        /// incarcarea datelor in DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MagazinITMainWindow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'magazinITDataSet1.Produse' table. You can move, or remove it, as needed.
            try
            {
                //deschidem conexiunea
                cs.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
            DataSet ds = new DataSet();
            ds = ctr.getAll();
            //SqlDataAdapter produseAdaptor = new SqlDataAdapter("select * from Produse",cs);
            //produseAdaptor.Fill(ds, "produse");
            produseGridView.DataSource = ds.Tables["produse"];
            for (int j = 0; j < this.produseGridView.Columns.Count; j++)
            {
                this.cosGridView.Columns.Add(this.produseGridView.Columns[j].Clone() as DataGridViewColumn);
            }
            cs.Close();
        }
        /// <summary>
        /// Sortarea Listei de produse dupa tip
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            cs.Open();
            DataSet ds = new DataSet();
            ds = ctr.sort(Type.Text.ToString());
            produseGridView.DataSource = ds.Tables["produse"];
            cs.Close();
            
        }
        /// <summary>
        /// Afisarea tuturor produselor disponibile
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnshow_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'magazinITDataSet1.Produse' table. You can move, or remove it, as needed.
            try
            {
                //deschidem conexiunea
                cs.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DataSet ds = new DataSet();
            //SqlDataAdapter produseAdaptor = new SqlDataAdapter("select * from Produse", cs);
            //produseAdaptor.Fill(ds, "produse");
            ds = ctr.getAll();
            produseGridView.DataSource = ds.Tables["produse"];//ds.Tables[0]
            cs.Close();
        }
        /// <summary>
        ///  cantitate este cantitatea introdusa de utilizator pentru a cumpara
        /// cantitatea maxima 10000
        /// cantitatea minima 0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuy_Click(object sender, EventArgs e)
        {
            cs.Open();
            int cantitate = Convert.ToInt32(produseGridView.CurrentRow.Cells[3].Value.ToString()); //cantitatea selectata;
            int id = Convert.ToInt32(produseGridView.CurrentRow.Cells[0].Value.ToString());//id de pe linia selectata
            int cantitateadorita = Convert.ToInt32(btnQuantityInput.Text);//cantitatea introdusa
            if (cantitate < cantitateadorita)
            {
                MessageBox.Show("Cantitatea aleasa este prea mare . Nu este disponibila");
            }
            else
            {
                cantitate = cantitate - cantitateadorita;
            }
            DataSet ds = new DataSet();
            SqlDataAdapter data = new SqlDataAdapter();
            ctr.cumpara(id, cantitate);
            //data.UpdateCommand.ExecuteNonQuery();
            cs.Close();
            btnshow_Click(null,null);
          
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(produseGridView.CurrentRow.Cells[0].Value.ToString());
            string name = produseGridView.CurrentRow.Cells[1].Value.ToString();
            string type = produseGridView.CurrentRow.Cells[2].Value.ToString();
            int price = Convert.ToInt32(produseGridView.CurrentRow.Cells[4].Value.ToString());
            //int index = cosGridView.Rows.Add();
            // DataSet ds = new DataSet();
            // DataGridViewColumn textColumn = new DataGridViewColumn();// cosGridView.Rows.Add("id", "name","type","quantity","price");
            int cantitate = Convert.ToInt32(produseGridView.CurrentRow.Cells[3].Value.ToString());
            int cantitateInput = Convert.ToInt32(btnQuantityInput.Text);
            bool found = false;
            if (cantitate < cantitateInput)
            {
                MessageBox.Show(" Cantiatea nu este disponibila ");
            }
            else
            {
                for (int i = 0; i < cosGridView.Rows.Count; i++)
                {
                    if (Convert.ToInt32(cosGridView.Rows[i].Cells[0].Value) == id)
                    {
                        MessageBox.Show("Obiectul a mai fost adaugat");
                        found = true;
                    }

                }
                if (!found)
                {
                    DataGridViewRow row = (DataGridViewRow)cosGridView.Rows[0].Clone(); //here you get a reference to added row
                    row.Cells[0].Value = id;
                    row.Cells[1].Value = name;
                    row.Cells[2].Value = type;
                    row.Cells[3].Value = cantitateInput;
                    row.Cells[4].Value = price;
                    cosGridView.Rows.Add(row);
               
                }
                


            }
        }
        /// <summary>
        /// min Input = 1;
        /// max Input = 1000;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTotal_Click(object sender, EventArgs e)
        {
            int total = 0;
            int cantitateprodus = 0;
            int cantitate = 0;
            int id = 0;
            for (int i = 0; i < cosGridView.Rows.Count; i++)
            {
                cantitate = Convert.ToInt32(cosGridView.Rows[i].Cells[3].Value);
                int pret = Convert.ToInt32(cosGridView.Rows[i].Cells[4].Value);
                total = total + cantitate * pret;
                
                id = Convert.ToInt32(cosGridView.Rows[i].Cells[0].Value);
                for (int j = 0; j < produseGridView.Rows.Count; j++)
                {
                    int idprodus = Convert.ToInt32(produseGridView.Rows[j].Cells[0].Value);
                    if (id == idprodus)
                    {
                        cantitateprodus = Convert.ToInt32(produseGridView.Rows[j].Cells[3].Value);
                    }
                }
                int restulcantitate = cantitateprodus - cantitate;
                ctr.cumpara(id, restulcantitate);
            }

            MessageBox.Show(total.ToString());
            foreach (DataGridViewRow row in cosGridView.Rows)
            {
                cosGridView.Rows.Clear();
            }
        }

        public void Ascending()
        {
            produseGridView.Sort(produseGridView.Columns[4], ListSortDirection.Ascending);
        }

        public void Descending()
        {
            produseGridView.Sort(produseGridView.Columns[4], ListSortDirection.Descending);
        }

        //public void Sorting(Action<string> myMethodName)
        //{
        //    myMethodName("");
        //}

        public delegate void Sort();
        
        private void rbAscended_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAscended.Checked == true)
            {
                Sort sorting = new Sort(Ascending);///  sort (numele functiei)
                sorting();
            }
            if (rbDescended.Checked == true)
            {
                Sort sorting = new Sort(Descending);
                sorting();
            }
        }

        
    }
}
