using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static readonly string AppPach = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
        static readonly string DbPach = Path.Combine(AppPach, "Data", "Product.accdb");
        static readonly string DbConnString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + DbPach + "';Persist Security Info=False;";
        static void Main(string[] args)
        {

            Context context = new Context(DbConnString);

            context.ConnectDb.Open();

            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = context.ConnectDb;
            cmd.CommandText = "SELECT * FROM Table1";

            OleDbDataReader reader = cmd.ExecuteReader();


            
            object[] arr = new object[500];

            List<Table1> tList = new List<Table1>();






            while (reader.Read())
            {
                var name = reader.GetString(1);

                //Console.WriteLine(name);


                //Console.WriteLine("Класс Табл1");
                Table1 pers = new Table1();



                pers.ID = reader.GetInt32(0);
                pers.name = reader.GetString(1);
                pers.salary = reader.GetInt32(2);

                tList.Add(pers);
                //Console.WriteLine(pers.ID+ " " + pers.name + " " + pers.salary);

                //Console.WriteLine(pers.ID +" "+ pers.name + " "+ pers.salary);






                //Console.WriteLine(pers.name);
                //Console.WriteLine(pers.salary);

            }


            



           




            Console.ReadLine();


        }
    }
}
