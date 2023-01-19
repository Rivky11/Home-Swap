namespace HomeSwap.API.Models
{
    public class ApartmentRatingModel
    {
        public int Id { get; set; }
        public int GuessId { get; set; }
        public int ApartmentId { get; set; }
        public int Clean { get; set; }
        public string Discreption { get; set; } = "";
    }
}
