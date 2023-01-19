namespace HomeSwap.API.Models
{
    public enum EType
    {
        Old,
        New
    }
    public enum EMigzar
    {
        religious,
        secular,

    }
    public class UserDetailsModel
    {
        public int userId { get; set; }
        public EMigzar Migzar { get; set; }
        public EType Type { get; set; }
        public bool Status { get; set; }
    }
}
