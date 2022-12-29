using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSwap.Repositories.Entities
{
    public  enum EType
    {
        Old,
        New
    }
    public enum EMigzar
    {
        religious,
        secular,
        
    }

    public  class UserDetails
    {
        public int userId { get; set; }
        public EMigzar Migzar { get; set; }
        public EType Type { get; set; }
        public bool Status { get; set; }





    }
}
