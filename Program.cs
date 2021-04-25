using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MenuTab;

namespace OOP_PROJECT
{
    class Program
    {
        
        SqlConnection con;

        public Program(string Connection)
        {
            this.con = new SqlConnection(Connection);
        }
        private DataTable GetData(string query)
        {
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adp = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            con.Open();
            adp.Fill(dt);
            con.Close();
            return dt;
        }



        public int RunQuery(string query)
        {
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            int a = cmd.ExecuteNonQuery();
            con.Close();
            return a;
        }

        static void Main(string[] args)
        {

            Program obj = new Program("Data Source=DESKTOP-TFUSAKG;Initial Catalog=PizzaHub;Integrated Security=True");
            Head H = new Head();
            bool lop = true;

            
           
            while (lop == true)
            {
                
                char bs = Class1.FP();
                string abc = "0";
                if (bs == 'R' || bs == 'r')
                {

                    H.header();
                    Console.WriteLine("IF You want to register yourself please enter your valid information  ");


                    Console.WriteLine("\n");
                    Console.Write("Enter your Name : ");
                    string name = Console.ReadLine();

                    Console.Write("Enter your Contact Number : ");
                    string contact = Console.ReadLine();

                    Console.Write("Enter your CNIC NO : ");
                    string cnic = Console.ReadLine();

                    Console.Write("Set your Password : ");
                    string password = Console.ReadLine();




                    abc = "INSERT INTO Waiter VALUES('" + name + "','" + contact + "','" + cnic + "','" + password + "')";
                    int check = obj.RunQuery(abc);

                  

                    
                    if (check > 0)
                    {

                        Console.WriteLine("You havebeen registered in this system  ");
                        Console.WriteLine("please restart the program and login from the login  page");
                        
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
                else if (bs == 'S' || bs == 's')
                {
                    H.header();
                    Console.WriteLine("\n\t\t\t\t\t Welcome to the login page\n ");
                    Console.WriteLine("Please enter your login name and password\n");
                    Console.Write("Enter Name : ");
                    string name = Console.ReadLine();
                    Console.Write("Enter your password : ");
                    string pass = Console.ReadLine();

                    


                    SqlConnection con = new SqlConnection("Data Source=DESKTOP-TFUSAKG;Initial Catalog=PizzaHub;Integrated Security=True");

                    con.Open();

                    
 
                    string query="select * from Waiter Where Name ='" + name+"' and Password ='"+pass+"'"; 

                    SqlCommand cmd = new SqlCommand(query, con);

                    //adopter is a bridge to connect from data base

                    SqlDataAdapter bridge = new SqlDataAdapter(cmd);

                    DataTable dt = new DataTable();

                    bridge.Fill(dt);


                    if (dt.Rows.Count > 0)
                    {
                        Console.WriteLine("Login Sucessfully you are in");
                        MENU m1 = new MENU();
                        m1.main();


                    }
                    else
                    {
                        Console.WriteLine("Invalid info out");
                    }
                    Console.ReadKey();

                  
                   int value = Class1.end();

                    if (value == 1)
                    {
                        lop = true;
                        Console.Clear();
                    }
                    else if (value == 2)
                    {
                        Console.Clear();
                        lop = false;
                    }
                }
            }
        }
    }
}



