using System.ComponentModel.DataAnnotations;

namespace TrainingRegistration.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}