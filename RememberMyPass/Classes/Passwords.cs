using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RememberMyPass.Classes
{
    [Table(Name="Passwords")]
    public class Passwords
    {
        [Column(IsPrimaryKey=true ,IsDbGenerated=true)]
        public int idPass {get; set;}
        [Column(CanBeNull=false)]
        public string descricao {get; set;}
        [Column(CanBeNull=false)]
        public string password {get; set;}

    }
}
