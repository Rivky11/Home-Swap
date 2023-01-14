using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSwap.Repositories.Entities
{
    public  class ApartmentPictures
    {
        public ApartmentPictures(int id, int apartmentId, string picture)
        {
            Id = id;
            ApartmentId = apartmentId;
            Picture = picture;
        }

        public int Id { get; set; }
        public int ApartmentId { get; set; }
        public string Picture { get; set; }


    }
}








