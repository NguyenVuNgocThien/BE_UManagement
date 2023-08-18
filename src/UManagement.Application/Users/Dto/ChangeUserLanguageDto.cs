using System.ComponentModel.DataAnnotations;

namespace UManagement.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}