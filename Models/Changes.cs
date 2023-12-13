using System.ComponentModel.DataAnnotations;
namespace Application.Models
{
     public class Changes
    {
        [Key]
        public int UserID{get; set;}        
        [StringLength(15,MinimumLength=8, ErrorMessage = "Password must in between 8-15")]
        [RegularExpression(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$",
        ErrorMessage = "Password must contains atleast 1 Uppercase, 1 specialcharacter and 1 Numeric value")]
        public string? NewPassword{get;set;}

        public string? ConfirmNewPassword{get;set;}
    }
}