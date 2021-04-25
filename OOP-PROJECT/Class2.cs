using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using  System.Data.SqlClient;

namespace OOP_PROJECT
{

    class DataIns
    {
        public DataIns()
        {
                
        }
        SqlConnection con;

        public DataIns(string Connection)
        {
            this.con = new SqlConnection(Connection);
        }
        public  DataTable GetData(string query)
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

        public void Printdata()
        {
            
            DataTable dt = GetData("SELECT * FROM Table_1");
            Console.WriteLine("S.no" + "\t" + "Product" + "\t\t" + "Price");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Console.WriteLine("---------------------------------------------------------------------------------");
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    Console.Write(dt.Rows[i][j].ToString() + "  \t ");


                }
                Console.WriteLine();
            }
        }


        public static void Insert(string a, double b)
        {
            
            Program obj = new Program("Data Source=DESKTOP-TFUSAKG;Initial Catalog=PizzaHub;Integrated Security=True");
            string abc = "";
            abc = "INSERT INTO Table_1 VALUES('" + a + "','" + b + "')";
            int check = obj.RunQuery(abc);
        }
        public void Delete()
        {
            string Del = "Delete Table_1";
            RunQuery(Del);
        }

       
    }
    
                                                  // ye calculatons hain 

    public class Total1
    {
        public static double Totalbill ;
        
        public virtual void Calculation(double S, int size)
        {
            string a;
            double sum = 0, b = 0;
            for (int i = 1; i <= S; i++)
            {
                Console.WriteLine("Select Flavour For Pizza : " + i);
                int num = Convert.ToInt32(Console.ReadLine());
                if (size == 1)
                {
                    b = 299;
                    a = "Small Pizza ";
                    DataIns.Insert(a, b);

                }
                else if (size == 2)
                {
                    b = 499;
                    a = "Medium Pizza ";
                    DataIns.Insert(a, b);
                }
                else if (size == 3)
                {
                    b = 599;
                    a = "Large Pizza ";
                    DataIns.Insert(a, b);
                }

            }
            sum = b * S;
            Console.WriteLine("Your Current Bill For Pizza is  "+sum);
            Totalbill = sum + Totalbill;
            
        }
        
    }
    public class Total2 : Total1
    {
        public override void Calculation(double free, int seq)
        {
            string a;
            double sum = 0, b = 0;
            for (int i = 1; i <= seq; i++)
            {
                Console.WriteLine("Select Flavour For Sandwich : " + i);
                int num = Convert.ToInt32(Console.ReadLine());
                if (num == 1)
                {
                    b = 300;
                    a = "Maxican SandWich ";
                    DataIns.Insert(a,b);
                }
                else if (num == 2)
                {
                    b = 400;
                    a = "Club SandWich ";
                    DataIns.Insert(a, b);
                }
                else if (num == 3)
                {
                    b = 500;
                    a = "Grilled Club SandWich ";
                    DataIns.Insert(a, b);
                }
                sum = sum + b;

            }
            Console.WriteLine("Your Current Billfor Sandwich is : "+sum);
            Totalbill = Totalbill + sum;
        
            Console.ReadKey();
        }
    }
    public class Total3 : Total2
    {
        public override void Calculation(double fee, int seq)
        {
            string ab;
            double sum = 0, b = 0;
            for (int i = 1; i <= seq; i++)
            {
                Console.WriteLine("Select Your Drink : " + i);
                int num = Convert.ToInt32(Console.ReadLine());
                if (num == 1)
                {
                    b = 50;
                    ab = " Mineral Water";
                    DataIns.Insert(ab, b);
                }
                else if (num == 2)
                {
                    b = 80;
                    ab = " Soft Drink";
                    DataIns.Insert(ab, b);
                }
                sum = sum + b;

            }
            Console.WriteLine("Your Bill For Beverages : " + sum);
            Totalbill = Totalbill + sum;
            Console.ReadKey();
        }

    }
    public class Total4 : Total3
    {
        public override void Calculation(double ree, int dealq)
        {
            string a;
            double sum = 0, b = 0;
            for (int i = 1; i <= dealq; i++)
            {
                Console.Write("Enter deal number you want to buy :> " );
                int num = Convert.ToInt32(Console.ReadLine());
                if (num == 1)
                {
                    b = 1299;
                    a = "Deal 1";
                    DataIns.Insert(a, b);
                    
                    
                }
                else if (num == 2)
                {
                    b = 1799;
                    a = "Deal 2";
                    DataIns.Insert(a, b);
                    
                }
                else if (num == 3)
                {
                    b = 1299;
                    a = "Deal 3";
                    DataIns.Insert(a, b);
                }
                else if (num == 4)
                {
                    b = 749;
                    a = "Deal 4";
                    DataIns.Insert(a, b);
                }
                else if (num == 5)
                {
                    b = 1099;
                    a = "Deal 5";
                    DataIns.Insert(a, b);
                }
                else if (num == 6)
                {
                    b = 1349;
                    a = "Deal 6";
                    DataIns.Insert(a, b);
                }
                sum = sum + b;


            }
            Console.WriteLine("\nYour current Bill For deals is : "+sum);
            Totalbill = Totalbill + sum;
            
            Console.ReadKey();
        }
    }

                                                        //ye menu hain 

    public class MENU :Head
    {
        public static void Deals()
        {

            Console.Clear();
            Console.WriteLine("\n\t\t\t\t\t\tBest Deals\n");
            Console.WriteLine("Deal 1 ");
            Console.WriteLine("\t2 large pizza & 1 litre soft drink\t(Rs1,299)\n");
            Console.WriteLine("Deal 2");
            Console.WriteLine("\t3 large pizza & 1.5 litre soft drink\t(Rs1,799)\n");
            Console.WriteLine("Deal 3 ");
            Console.WriteLine("\t3 Regular pizza & 1.5 litre soft drink\t(Rs1,299)\n");
            Console.WriteLine("Deal 4 ");
            Console.WriteLine("\t3 small pizza & 1 litre soft drink\t(Rs749)\n");
            Console.WriteLine("Deal 5 ");
            Console.WriteLine("\t2 Regular pizza & 1 litre soft drink\t(Rs1,099)\n");
            Console.WriteLine("Deal 6");
            Console.WriteLine("\tLarge pizza, regular pizza, small pizza with 1.5 litre soft drink\t(Rs1,349)\n");
            Console.WriteLine("\n");
            Console.WriteLine("Please press the deal number you want to select");
            Console.Write(":>");
        }
        public static void Nmenu()
        {
            Console.Clear();
            Console.WriteLine("1\tPizza");
            Console.WriteLine("2\tSandwich");
            Console.WriteLine("3\tBeverages");
            Console.WriteLine("Please select the number what you want to add in order");
            Console.Write(":>");

        }
        public static void PizzaFlavourMenu()
        {
            Console.WriteLine("\t\t\t\tpizza flavours\n\n");
            Console.WriteLine("1> Pizza Hub Special");
            Console.WriteLine("\tOur expert secret ingredients & recipe will bring you a mouth watering taste\n");
            Console.WriteLine("2> Pizza Hub Creamy Hot");
            Console.WriteLine("\tOur expert secret ingredients & recipe will bring you a mouth watering taste\n");
            Console.WriteLine("3> Chicken Tikka Pizza");
            Console.WriteLine("\tPizza sauce, cheese, tikka meat & onion\n");
            Console.WriteLine("4> Malai Tikka Pizza");
            Console.WriteLine("\tCreamy sauce, extra cheese & tikka meal\n");
            Console.WriteLine("5> Afghani Feast Pizza");
            Console.WriteLine("\tCreamy sauce, cheese, afghani meat, onion & mushrooms\n");
            Console.WriteLine("6> Pepperoni Lover Pizza");
            Console.WriteLine("\tPizza sauce, cheese & lots of cheese\n");
            Console.WriteLine("7> Cheesy Hub Pizza");
            Console.WriteLine("\tPizza sauce & lots of cheese\n");
            Console.WriteLine("8> Chicken Fajita Pizza");
            Console.WriteLine("\tPizza sauce, cheese, fajita meat, green pepper & onion\n");
            Console.WriteLine("9> Shawarma Feast Pizza");
            Console.WriteLine("\tCreamy sauce, cheese, shawarma meat, onion, mushroom & jalapeno\n");
            Console.WriteLine("10> Italian Delight Pizza");
            Console.WriteLine("\tMushroom sauce, black olives, green pepper, smoke chicken & cheese\n");
        }
       
                                      // ye sari checking or select ho kr upper Totel me bhej raha ha
       
        public void main()
        {
            header();
            bool lop = true;

            while (lop == true)
            {

                Console.Clear();

                string a;
                Console.Clear();
                base.header();
                Console.WriteLine(" PRESS 1 FOR DEALS \n PRESS 2 FOR NORMAL ORDERS");
                a = Console.ReadLine();
                if (a == "1" || a == "2")
                {
                    switch (a)
                    {
                        case "1":
                            header();
                            Deals();
                            Console.Write("How many deals you want to order  :> ");
                            int DELquantity = Convert.ToInt32(Console.ReadLine());
                            double ree = 0;

                            Total4 t4 = new Total4();
                            t4.Calculation(ree, DELquantity);

                            break;
                        case "2":
                            header();
                            Nmenu();
                            int s;
                            s = Convert.ToInt32(Console.ReadLine());
                            if (s == 1 || s == 2 || s == 3)
                            {
                                switch (s)
                                {
                                    case 1:            // pizza k size or flavour print ho rahy hain or 
                                                      // totel ki over loaded class call ho rahi ha
                                        Console.Clear();
                                        base.header();
                                        Console.WriteLine("Please select pizza size");
                                        Console.WriteLine("press 1 Small  RS 299 ");
                                        Console.WriteLine("press 2 Medium RS 499");
                                        Console.WriteLine("press 3 large RS 599");
                                        int sel;
                                        Console.WriteLine("Select the pizza size ");
                                        sel = Convert.ToInt32(Console.ReadLine());
                                        Console.Clear();
                                        if (sel == 1 || sel == 2 || sel == 3)
                                        {
                                            PizzaFlavourMenu();
                                            Console.Write("how many Pizza you want to order  :> ");
                                            double Pquantity = Convert.ToDouble(Console.ReadLine());

                                            Total1 t1 = new Total1();
                                            t1.Calculation(Pquantity, sel);

                                        }
                                        break;
                                    case 2:                  // sandwitch k table print ho raha ha
                                        Console.Clear();
                                        base.header();
                                        Console.WriteLine("SANDWITCH");
                                        Console.WriteLine("1\t Mexican Sandwich \t(Rs300)\n");
                                        Console.WriteLine("2\t  club Sandwitch\t(Rs400)\n");
                                        Console.WriteLine("3\t Grilled club Sandwitch\t(Rs500)\n");

                                        Console.Write("how many sandwiches you want to order  :> ");
                                        int Squantity = Convert.ToInt32(Console.ReadLine());
                                        double free = 0;

                                        Total2 t2 = new Total2();
                                        t2.Calculation(free, Squantity);

                                        break;
                                    case 3:
                                        Console.Clear();
                                        base.header();
                                        Console.WriteLine("1\tMineral Water\t( Rs50)\n");
                                        Console.WriteLine("2 \tSoft Drink  345ml\t(Rs80)\n");
                                        Console.Write("How many drinks you want to order  :> ");
                                        int Dquantity = Convert.ToInt32(Console.ReadLine());
                                        double fee = 0;

                                        Total3 t3 = new Total3();
                                        t3.Calculation(fee, Dquantity);
                                        break;
                                }
                            }
                            break;
                    }


                }



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

            base.header();

           
            string tb = "Total Bill";
            DataIns.Insert(tb, Total1.Totalbill);
            DataIns DI = new DataIns("Data Source=DESKTOP-TFUSAKG;Initial Catalog=PizzaHub;Integrated Security=True");
            DI.Printdata();
            DI.Delete();
            
        }

    }
}
