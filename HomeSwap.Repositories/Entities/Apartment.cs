using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSwap.Repositories.Entities
{
    public  class Apartment
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public int NumBeds { get; set; }
        public int NumRooms { get; set; }
        public int Area { get; set; }
        public int Floor { get; set; }
        public bool IsConditioned { get; set; }
        public bool IsMMD { get; set; }
        public bool IsAccessForDisabled { get; set; }
        public bool IsElevators { get; set; }
        public bool IsKosherkitchen { get; set; }
        public bool IsRenovated { get; set; }
        public bool IsBars { get; set; }
        public bool IsForSleepingOnly { get; set; }


    }
}