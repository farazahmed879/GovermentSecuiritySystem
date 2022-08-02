using System.ComponentModel.DataAnnotations;

namespace GovermentSecuritySystemApp.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}