
using System.Xml.Linq;
using System.ComponentModel.DataAnnotations;

namespace StudyWork.Models
{
    public class Authorization
    {

        [Display(Name = "Введите логин")]
        [Required(ErrorMessage = "Вам нужно ввести логин!")]
        public string CheckLogin { get; set; }

        [Display(Name = "Введите пароль")]
        [Required(ErrorMessage = "Вам нужно ввести пароль!")]
        public string СheckPass { get; set; }

            
    }
}
