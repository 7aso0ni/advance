namespace Rental.Models
{
    public class SignInViewModel
    {
        public string Username { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public string? Message { get; set; }
        public string? ErrorMessage { get; set; }
    }
}
