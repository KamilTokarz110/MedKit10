using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.Data;

namespace MedKit10
{
    public class ShareSqlCom
    {
        public SqlConnection SqlCon { get; private set; }
        public ShareSqlCom()
        {
            SqlCon = new SqlConnection("Data Source=DESKTOP-BQITBQR\\SQLEXPRESS;Initial Catalog=MedkitDB;Integrated Security=True");
        }




        public bool IfMedExists(int Id)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select 1 From [Medicaments] WHERE [Id] ='" + Id + "'", SqlCon);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }
    }
}
