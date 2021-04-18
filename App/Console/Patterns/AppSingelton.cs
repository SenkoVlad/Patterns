using Patterns.Singelton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.App.Console.Patterns
{
    public class AppSingelton
    {
        public void Execute()
        {
            Database connection = Database.getConnection();
            connection.Querty("SELECT");

            Database connection2 = Database.getConnection();
            connection2.Querty("INSERT");
        }
    }
}
