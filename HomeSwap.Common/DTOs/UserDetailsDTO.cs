using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSwap.Common.DTOs
{
    public enum ETypeDTO
    {
        Old,
            New
    }
    public enum EMigzarDTO
    {
        religious,
        secular,

    }
    public class UserDetailsDTO
    {
        public int userId { get; set; }
        public EMigzarDTO Migzar { get; set; }
        public ETypeDTO Type { get; set; }
        public bool Status { get; set; }
    }
}