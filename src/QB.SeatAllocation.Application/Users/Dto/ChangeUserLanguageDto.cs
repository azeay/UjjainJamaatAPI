using System.ComponentModel.DataAnnotations;

namespace QB.SeatAllocation.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}