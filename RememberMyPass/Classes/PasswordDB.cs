using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RememberMyPass.Classes
{
    class PasswordDB
    {
        private static DataBase getDataBase()
        {
            DataBase db = new DataBase();
            if (db.DatabaseExists() == false)
            {
                db.CreateDatabase();
            }
            return db;
        }
        //Consulta
        public static List<Passwords> GetPass()
        {
            DataBase db = getDataBase();
            var query = from p in db.Passwords orderby p.idPass select p;
            List<Passwords> pw = new List<Passwords>(query.AsEnumerable());
            return pw;
        }
        //Salva
        public static void SalvarPW(Passwords pw)
        {
            DataBase db = getDataBase();
            db.Passwords.InsertOnSubmit(pw);
            db.SubmitChanges();
        }
        //Deletar
        public static void DeletarPW(Passwords pw)
        {
            DataBase db = getDataBase();
            var query = from p in db.Passwords where p.idPass == pw.idPass select p;
            db.Passwords.DeleteOnSubmit(query.ToList()[0]);
            db.SubmitChanges();
        }
    }
}
