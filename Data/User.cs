using System.Diagnostics.Contracts;

namespace Handbook.Data
{
    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? CityNumber { get; set; }
        public string? LocalNumber { get; set; }
        public string? Department { get; set; }
        public string? Email { get; set; }
        public string? Login { get; set; }
        public string? PasswordWin { get; set; }
        public string? PasswordPsi { get; set; }
        public string? PasswordEmail{ get; set; }
        public string? AnotherInformation { get; set; }
       
        public DateTime? Created { get; set; } = DateTime.Now;

    }
}
