using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication2.ServiceReference1;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;

namespace MvcApplication2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {




            return View();
        }
        [HttpPost]
        public ActionResult Index(FormCollection s)
        {

            Service2Client scv = new Service2Client();

            string s1 = s["text1"].ToString();
            string s2 = s["methode"].ToString();
            int size = s1.Length;
            if (size > 10)
            {
                size = s1.Length - 1;
                int size2 = size - 9;
                
                s1 = s1.Substring(5, size2);
                switch (s2)
                {
                    case "1": ViewBag.Message = scv.Inverse(s1); break;
                    case "2": ViewBag.Message = scv.Inverse2By2(s1); break;
                    case "3": ViewBag.Message = scv.RemoveVowels(s1); break;
                }
               
                s1 = s["methode"].Insert(0, s1);
                int taille = s1.Length - 1;
                s1 = s1.Insert(taille, s["text1"].ToString());


                string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;" +
                                             @"Data Source=C:\Users\bob\Desktop\semlex.mdb;" +
                                             @"User Id=;Password=;";


                // pay attention about primary and foreign key while inserting do not try to insert duplicate value
                string queryString = "INSERT into lignes (idligne,idtext,ligne) VALUES (11, 11,@lignes)";

                using (OleDbConnection connection = new OleDbConnection(connectionString))
                {
                    connection.Open();

                    OleDbCommand command = new OleDbCommand(queryString, connection);
                    command.Parameters.AddWithValue("@ligne", ViewBag.Message );
                    try
                    {
                        command.ExecuteNonQuery();
                        OleDbDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            Console.WriteLine(reader[0].ToString());
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

            }

            return View();
        }
        

        public ActionResult About()
        {
            ViewBag.Message = "";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "";

            return View();
        }
    }
}
