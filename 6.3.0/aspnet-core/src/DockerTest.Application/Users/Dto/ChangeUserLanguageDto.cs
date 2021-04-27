using System.ComponentModel.DataAnnotations;

namespace DockerTest.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}