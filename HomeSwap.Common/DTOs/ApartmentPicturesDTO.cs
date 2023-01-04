using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSwap.Common.DTOs
{
    public class ApartmentPicturesDTO
    {
        public int Id { get; set; }
        public int ApartmentId { get; set; }
        public string Picture { get; set; } = "";
    }
}
