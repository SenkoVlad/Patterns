using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Singelton
{
    public class Database
    {
        private static object loker =  new object();
        private static Database connection;
        private Database()
        {

        }
        public static Database getConnection()
        {
            lock (loker)
            {
                if (connection == null)
                {
                    Database.connection = new Database();
                }
                return connection;
            } 
        }

        public void Querty(string sql)
        {
            Console.WriteLine(sql);
        }
    }
}
