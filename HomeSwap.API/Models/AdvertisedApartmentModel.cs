namespace HomeSwap.API.Models
{
    public class AdvertisedApartmentModel
    {
        public int Id { get; set; }
        public int ApartmentId { get; set; }
        public DateTime DateAdd { get; set; }
        public DateTime fromDate { get; set; }
        public DateTime toDate { get; set; }
        public bool status { get; set; }
    }
}
