using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOdotnet
{
    class Drop
    {
        public static void droping()
        {
            string query = "drop table person";
            SqlConnection con = new SqlConnection(@"Data Source=.\SAPNA;Persist Security Info=True;User ID=sa;Password=123");
            con.Open();
            SqlCommand sc = new SqlCommand(query, con);
            sc.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("Drop the table");
        }
        static void Main(string[] args)
        {
            droping();
            Console.ReadKey();
        }
    }
}
