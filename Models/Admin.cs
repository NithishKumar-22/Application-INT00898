using System.ComponentModel.DataAnnotations;

namespace Application.Models
{
    public class Admin
    {
        [Key]
        public int AdminID{get;set;}
        
        [Required]
        [StringLength(15,MinimumLength=8, ErrorMessage = "Password must in between 8-15")]
        [RegularExpression(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$",
        ErrorMessage = "Password must contains atleast 1 Uppercase, 1 specialcharacter and 1 Numeric value")]
        public string? AdminPassword{get; set;}

    }
}