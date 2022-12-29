using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSwap.Repositories.Entities
{
    public class AdveretisedApartment
    {
        public AdveretisedApartment(int id, int apartmentId, DateTime dateAdd, DateTime fromDate, DateTime toDate, bool status)
        {
            Id = id;
            ApartmentId = apartmentId;
            DateAdd = dateAdd;
            this.fromDate = fromDate;
            this.toDate = toDate;
            this.status = status;
        }

        public int Id { get; set; }
        public int ApartmentId { get; set; }
        public DateTime DateAdd { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public bool status { get; set; }
        

    }
}
