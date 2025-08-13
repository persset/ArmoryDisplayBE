namespace ArmoryDisplayBE.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Nickname { get; set; }
        public string? Password { get; set; }
        public string Email { get; set; } = "";
        public int ServerId { get; set; }
    }
}
