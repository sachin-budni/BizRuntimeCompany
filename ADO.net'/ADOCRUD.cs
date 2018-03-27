using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOdotnet
{
#pragma warning disable CS1587
    class ADOCRUD
    {
        static log4net.ILog log = log4net.LogManager.GetLogger(typeof(Program));

        /// <summary>
        /// create();
        /// this mehtod will create the table 
        /// table name person table 
        /// </summary>
        public static void create()
        {
            try
            {
                ///<summary>
                ///establish the connection between database and application 
                ///</summary>

                SqlConnection con = new SqlConnection(@"Data Source=.\SAPNA;Persist Security Info=True;User ID=sa;Password=123");
                con.Open();
                
                ///<summary>
                ///create the table query
                /// </summary>

                string s1 = "create table person(id int,name varchar(90),age int)";
                SqlCommand sc = new SqlCommand(s1, con);
                
                ///<summary>
                ///exceting that query with help of ExecuteNonQuery() method
                /// </summary>

                sc.ExecuteNonQuery();
                Console.WriteLine(" Person Table is created");
            }
            catch(Exception e)
            {
                log.Error(e);
                Console.WriteLine(e);
            }
        }
        /// <summary>
        /// inserting data to the database
        /// establishing the connection
        /// inserting the data help of insert query
        /// </summary>
        public static void insert()
        {
            int id;
            string name;
            int age;
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=.\SAPNA;Persist Security Info=True;User ID=sa;Password=123");
                con.Open();
                Console.WriteLine("Enter ID");
                id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Name");
                name = Console.ReadLine();
                Console.WriteLine("Enter age");
                age = Convert.ToInt32(Console.ReadLine());
                string query = "insert into person values(" + id + ",'" + name + "'," + age + ")";
                SqlCommand sc = new SqlCommand(query,con);
                sc.ExecuteNonQuery();
                con.Close();
                log.Info("added "+id);
                Console.WriteLine("data is inserted");
            }
            catch(Exception e)
            {
                log.Error(e);
                Console.WriteLine(e);
            }
        }
        /// <summary>
        /// deleting data from the database
        /// establish the connection
        /// with help of the delete query
        /// </summary>
        public static void delete()
        {
            try
            {
                Console.WriteLine("Enter Id");
                int id = Convert.ToInt32(Console.ReadLine());
                string query = "delete from person where id=" + id;
                SqlConnection con = new SqlConnection(@"Data Source=.\SAPNA;Persist Security Info=True;User ID=sa;Password=123");
                con.Open();
                SqlCommand sc = new SqlCommand(query, con);
                sc.ExecuteNonQuery();
                con.Close();
                log.Info("deleted "+id);
                Console.WriteLine("Deleted that data");
            }
            catch(Exception e)
            {
                log.Error(e);
                Console.WriteLine(e);
            }
        }
        /// <summary>
        /// update the data from the database
        /// using update query
        /// </summary>
        public static void update()
        {
            try
            {
                Console.WriteLine("Enter ID");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Name");
                string name = Console.ReadLine();
                string query = "update person name='" + name + " where id=" + id;
                SqlConnection con = new SqlConnection(@"Data Source=.\SAPNA;Persist Security Info=True;User ID=sa;Password=123");
                con.Open();
                SqlCommand sc = new SqlCommand(query, con);
                sc.ExecuteNonQuery();
                con.Close();
                log.Info("Update the id "+ id);
                Console.WriteLine("Update the data");
            }
            catch(Exception e)
            {
                log.Error(e);
                Console.WriteLine(e);
            }
        }
        /// <summary>
        /// read or retrive the data from database
        /// using select query
        /// </summary>
        public static void read()
        {
            try
            {
                string query = "select * from person";
                SqlConnection con = new SqlConnection(@"Data Source=.\SAPNA;Persist Security Info=True;User ID=sa;Password=123");
                con.Open();
                SqlCommand sc = new SqlCommand(query, con);
                SqlDataReader adr = sc.ExecuteReader();
                for(int i=0; i<adr.FieldCount; i++)
                {
                    log.Info(adr.GetName(i) + "\t");
                    Console.Write(adr.GetName(i)+"\t");
                }
                Console.WriteLine();
                Console.WriteLine("-------------------------------------");
                while(adr.Read())
                {
                    log.Info(adr["id"] + "\t" + adr["name"] + "\t" + adr["age"]);
                    Console.WriteLine(adr["id"]+"\t"+adr["name"]+"\t"+adr["age"]);
                }
                con.Close();
            }
            catch(Exception e)
            {
                log.Error(e);
                Console.WriteLine(e);
            }
        }
        /// <summary>
        /// main method it calls the all static method
        /// by the help of the swicth cases
        /// create(),insert(),delete(),update() and read() method
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Inserting data = create");
            Console.WriteLine("Inserting data = insert");
            Console.WriteLine("Deleting data = delete");
            Console.WriteLine("Updating data = update");
            Console.WriteLine("Reading data = read");
            string s1 = Console.ReadLine();
            switch(s1.ToUpper())
            {
                case "CREATE":
                    create();
                    break;
                case "INSERT":
                    insert();
                    break;
                case "DELETE":
                    delete();
                    break;
                case "UPDATE":
                    update();
                    break;
                case "READ":
                    read();
                    break;
                default:
                    Console.WriteLine("write properly");
                    Main(args);
                    break;
            }
            Console.WriteLine();
            Console.WriteLine("operation Complete");
            Console.WriteLine("if u want to continue? pls enter yes or no");
            string s2=Console.ReadLine();
            if((s2.ToUpper()).Equals("YES"))
            {
                Main(args);
            }
            Console.ReadKey();
        }
    }
}
