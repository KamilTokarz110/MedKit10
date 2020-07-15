using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedKit10
{
    /// <summary>
    /// Klasa zawiera funkcję do wyświetlania oraz wyszukiwania leku po nazwie
    /// </summary>
    public partial class MyMeds : Form
    {
        public MyMeds()
        {
            InitializeComponent();
        }

        /// <summary>
        /// funkcja wczytująca dane z bazy do DataGrindView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MyMeds_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'medkitDBDataSet3.Medicaments' . Możesz go przenieść lub usunąć.
            this.medicamentsTableAdapter3.Fill(this.medkitDBDataSet3.Medicaments);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'medkitDBDataSet2.Medicaments' . Możesz go przenieść lub usunąć.
            // this.medicamentsTableAdapter2.Fill(this.medkitDBDataSet2.Medicaments);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'medkitDBDataSet1.Medicaments' . Możesz go przenieść lub usunąć.
            // this.medicamentsTableAdapter1.Fill(this.medkitDBDataSet1.Medicaments);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'medkitDBDataSet.Medicaments' . Możesz go przenieść lub usunąć.
            //  this.medicamentsTableAdapter.Fill(this.medkitDBDataSet.Medicaments);
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-BQITBQR\\SQLEXPRESS;Initial Catalog=MedkitDB;Integrated Security=True");
            string sqlquery = "SELECT * FROM [MedkitDB].[dbo].[Medicaments]";
            con.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, con);
            SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();


        }

      

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-BQITBQR\\SQLEXPRESS;Initial Catalog=MedkitDB;Integrated Security=True");
        }
        /// <summary>
        /// Funkcja Wywołania Reminder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {

            Reminder rem = new Reminder();
           // rem.Show();
            rem.textBox1.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            rem.textBox2.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            rem.ShowDialog();

            // int a = dataGridView1.SelectedRows[0].Cells[2].Value;
            // a--;
            // dataGridView1.SelectedRows[0].Cells[2].Value = a.ToString();
        }
        /// <summary>
        /// Funkcja wypełnia textboxy po podwójnym kliknięciu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
  

            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            comboBox1.SelectedText = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

          if (dataGridView1.SelectedRows[0].Cells[3].Value.ToString() =="Zażywam" )
            {
             comboBox1.Text = "Tak";
        }
          else
           {
              comboBox1.Text = "Nie" ;
           }
           

        }
        /// <summary>
        /// Klasa wyszukiwania leku po jego opisie
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-BQITBQR\\SQLEXPRESS;Initial Catalog=MedkitDB;Integrated Security=True");
            string sqlquery = "SELECT * FROM [MedkitDB].[dbo].[Medicaments] WHERE Opis like '" +textBox1.Text + "%'";
            con.Open();
            SqlCommand sqlcomm = new SqlCommand(sqlquery, con);
            SqlDataAdapter sdr = new SqlDataAdapter(sqlcomm);
            DataTable dt = new DataTable();
            sdr.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
