using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeSwap.Repositories.Entities
{

    public class ApartmentRating
    {
        public int Id { get; set; }
        public int GuessId { get; set; }
        public int ApartmentId { get; set; }
        public int Clean { get; set; }
        public string Discreption { get; set; }
    }
}
