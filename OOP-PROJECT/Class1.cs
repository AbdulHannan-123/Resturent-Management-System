using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace OOP_PROJECT
{
    class Class1
    {
        public static char FP()
        {
            Console.WriteLine("If Its Hot & Fresh Its Pizza Hub Delicious, Affordable, Hygienic We use the finest ingredients in our recipes.The pizza is fabulous and the prices are excellent.We also offer Gluten-Free, Whole Wheat and thin crust pizzas");
            Console.Write("\n\nPress S for signin as Waiter  OR  Press R for register new waiter\n:>");
            char login = Convert.ToChar(Console.ReadLine());
            Console.Clear();
            return login;

            
        }
        public static int end()
        {
            //end k opyions k lia hay

            string nd; int ab;
            Console.WriteLine();
            Console.WriteLine("Do you want to 'CheckOut / End' the software");
            Console.WriteLine("Press (Y) For Yes \nPess (N) To Continue");
            while (true)
            {
                nd = Console.ReadLine();
                if (nd == "n" || nd == "N" || nd == "y" || nd == "Y")
                {
                    if (nd == "n" || nd == "N")
                    {
                        ab = 1;

                        return (ab);
                    }
                    else if (nd == "y" || nd == "Y")
                    {
                        ab = 2;
                        return (ab);
                    }
                }
                else

                Console.WriteLine("invalid input");
                Console.WriteLine("Pess N to continue else press Y to end");

            }
        }
    }

    public class Head
    {
        public void header()
        {
            for (int b = 1; b <= 55; b++)
            {
                Console.Write("***");
            }
            Console.WriteLine();

            Console.WriteLine("\t\t\t\t\t\t\t\t\t\t ## PIZZA HUB ### ");
            for (int b = 1; b <= 55; b++)
            {
                Console.Write("***");
            }
            Console.WriteLine();
        }
    }



 
}
