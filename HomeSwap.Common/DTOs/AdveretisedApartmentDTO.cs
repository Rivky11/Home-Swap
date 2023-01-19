using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSwap.Common.DTOs
{
    public class AdveretisedApartmentDTO
    {
        public AdveretisedApartmentDTO() { }
        public AdveretisedApartmentDTO(int id, int apartmentId, DateTime dateAdd, DateTime fromDate, DateTime toDate, bool status)
        {
            Id = id;
            ApartmentId = apartmentId;
            DateAdd = dateAdd;
            FromDate = fromDate;
            ToDate = toDate;
            Status = status;
        }

        public int Id { get; set; }
        public int ApartmentId { get; set; }
        public DateTime DateAdd { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public bool Status { get; set; }
    }
}
