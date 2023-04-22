using System.ComponentModel.DataAnnotations;

namespace StudyWork.Models
{
    public class Profile
    {
        [Display(Name = "Введите имя")]
        [Required(ErrorMessage = "Вам нужно ввести имя!")]
        public string CheckNamePr { get; set; }

        [Display(Name = "Введите фамилию")]
        [Required(ErrorMessage = "Вам нужно ввести фамилию!")]
        public string CheckSurnamePr { get; set; }

        [Display(Name = "Введите отчество")]
        [Required(ErrorMessage = "Вам нужно ввести отчество!")]
        public string CheckOtchPr { get; set; }

        [Display(Name = "Введите название компании")]
        [Required(ErrorMessage = "Вам нужно ввести название компании!")]
        public string CheckNameCompPr { get; set; }

    }
}
