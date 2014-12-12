using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RememberMyPass.Classes
{
    class DataBase : DataContext
    {
        public static string DBConnectionString = "Data Source ='isostore:Passwords.sdf'";

        public DataBase() : base(DBConnectionString) { }

        public Table<Passwords> Passwords
        {
            get
            {
                return this.GetTable<Passwords>();
            }
        }
    }
}
