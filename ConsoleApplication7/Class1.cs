using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace ConsoleApplication7
{
    public class Context
    {
        private OleDbConnection conn;

        public Context(string DbConnString)
        {
        conn=new OleDbConnection(DbConnString);
        }

        public OleDbConnection ConnectDb
        {
            get { return conn; }

        }


    }
}
