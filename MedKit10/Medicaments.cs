using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Net;
using System.Security.Policy;

namespace MedKit10
{
    /// <summary>
    /// Klasa zawiera metody pozwalające na dodawanie rekordów do bazy danych z wartości wprowadzonych przez użytkownika
    /// </summary>
    public partial class Medicaments : Form
    {
        public Medicaments()
        {
            InitializeComponent();
        }

        private void Medicaments_Load_1(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            loadData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Meds_Taken(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            loadData();
        }
        /// <summary>
        /// Klasa dodawania oraz modyfikacji rekordów bazy danych
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-BQITBQR\\SQLEXPRESS;Initial Catalog=MedkitDB;Integrated Security=True");
                con.Open();
                bool status = false;
                if (comboBox1.SelectedIndex == 0)
                {
                    status = true;
                }
                else
                {
                    status = false;
                }

                var sqlQuery = "";
                //Sprawdza czy lek istnieje w bazie, jeżeli tak to aktualizauje go z parametrów podanych przeż użytkownika

                if (IfMedExists(con, textBox1.Text))
                {
                    sqlQuery = @"UPDATE [Medicaments] SET [Nazwa] =  '" + textBox2.Text + "',[Ilość] = '" + textBox3.Text + "' ,[Zażywanie] = '" + status + "' ,[Pozostało] = '" + textBox5.Text + "',[Cena] = '" + textBox6.Text + "' ,[Opis] = '" + textBox7.Text + "' WHERE  [Id] ='" + textBox1.Text + "'";
                    MessageBox.Show("Lek zakutalizowany");
                }
                else
                {
                    sqlQuery = @"INSERT INTO[MedkitDB].[dbo].[Medicaments]
          ([Id]
           ,[Nazwa]
           ,[Ilość]
           ,[Zażywanie]
           ,[Pozostało]
           ,[Cena]
           ,[Opis])
     VALUES

('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + status + "', '" + textBox5.Text + "', '" + textBox6.Text + "', '" + textBox7.Text + "')";
                    MessageBox.Show("Lek o ID: " + textBox1.Text + " został dodany do bazy");
                }

                SqlCommand cmd = new SqlCommand(sqlQuery, con);


                object o = cmd.ExecuteNonQuery();

                //Reading data
                loadData();
                button1.Text = "Dodaj";

                con.Close();
                ResetRecords();
            }

            //  DataTable dtable = new DataTable();
            //dtable.Columns.AddRange(new DataColumn[1] {new DataColumn("Id") });
            // dtable.Columns["Id"].AutoIncrement = true;
            // dtable.Columns["Id"].AutoIncrementSeed = 1;
            // dtable.Columns["Id"].AutoIncrementStep = 1;

        }
        /// <summary>
        /// Metoda sprawdza czy lek o wpisanym ID istnieje w bazie danych
        /// </summary>
        /// <param name="con">Connection String</param>
        /// <param name="Id">ID leku podawane przez użytkownika </param>
        /// <returns>
        /// zwracam prawdę lub fałsz
        /// </returns>
        public bool IfMedExists(SqlConnection con, string Id)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select 1 From [Medicaments] WHERE [Id] ='" + Id + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
       /// <summary>
       /// Metoda zaczytująca dane do DataGrindView
       /// </summary>
        public void loadData()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-BQITBQR\\SQLEXPRESS;Initial Catalog=MedkitDB;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select * From [MedkitDB].[dbo].[Medicaments]", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
           dataGridView1.Rows.Clear();
            foreach (DataRow item in dt.Rows)
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = item["Id"].ToString();
                dataGridView1.Rows[n].Cells[1].Value = item["Nazwa"].ToString();
                dataGridView1.Rows[n].Cells[2].Value = item["Ilość"].ToString();
                dataGridView1.Rows[n].Cells[3].Value = item["Zażywanie"].ToString();
                dataGridView1.Rows[n].Cells[4].Value = item["Pozostało"].ToString();
                dataGridView1.Rows[n].Cells[5].Value = item["Cena"].ToString();
                dataGridView1.Rows[n].Cells[6].Value = item["Opis"].ToString();
                if ((bool)item["Zażywanie"])
                {
                    dataGridView1.Rows[n].Cells[3].Value = "Zażywam";
                }
                else
                {
                    dataGridView1.Rows[n].Cells[3].Value = "Niezazywam";
                }

            }

        }
      
        /// <summary>
        /// Aktualizowanie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        
        {
            button1.Text = "Zaktualizuj";
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            comboBox1.SelectedText = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

            if (dataGridView1.SelectedRows[0].Cells[3].Value.ToString() == "Zażywam")
            {
                comboBox1.SelectedIndex = 1;
            }
            else
            {
                comboBox1.SelectedIndex = 0;
            }

        }
        /// <summary>
        /// Usuwanie rekordów
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            if(Validation()){
                ShareSqlCom sqlCom = new ShareSqlCom();


                SqlConnection con = new SqlConnection("Data Source=DESKTOP-BQITBQR\\SQLEXPRESS;Initial Catalog=MedkitDB;Integrated Security=True");
                var sqlQuery = "";
                if (IfMedExists(con, textBox1.Text))
                {
                    con.Open();
                    sqlQuery = @"DELETE FROM [Medicaments] WHERE  [Id] ='" + textBox1.Text + "'";
                    SqlCommand cmd = new SqlCommand(sqlQuery, con);
                    object o = cmd.ExecuteNonQuery();
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Rekord nie istnieje");
                }

                //Wczytywanie danych
                loadData();
                ResetRecords();
            }

            


        }



       public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Walidacja danych
        /// </summary>
        /// <returns>
        /// zwaraca prawdę lub fałsz
        /// </returns>
        public bool Validation()
        {
            bool result = false;
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox3.Text) && comboBox1.SelectedIndex > -1 && !string.IsNullOrEmpty(textBox5.Text) && !string.IsNullOrEmpty(textBox6.Text) &&
                !string.IsNullOrEmpty(textBox7.Text)) {
                result = true; 
            }
            return result;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        /// <summary>
        /// Resetowanie pól 
        /// </summary>
        private void ResetRecords()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            comboBox1.SelectedIndex = -1;
            button1.Text = "Dodaj";
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ResetRecords();
        }
    }

}
