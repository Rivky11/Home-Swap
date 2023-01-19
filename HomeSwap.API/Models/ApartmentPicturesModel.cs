namespace HomeSwap.API.Models
{
    public class ApartmentPicturesModel
    {
        public int Id { get; set; }
        public int apartmentId { get; set; }
        public string Picture { get; set; } = "";
    }
}
