using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSwap.Common.DTOs
{
    public class AdveretisedApartmentDTO
    {
        public int Id { get; set; }
        public int ApartmentId { get; set; }
        public DateTime DateAdd { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public bool status { get; set; }
    }
}
