using System.ComponentModel.DataAnnotations;

namespace HjAbpProject.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}