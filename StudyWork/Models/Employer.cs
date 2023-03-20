using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace StudyWork.Models
{
    public class Employer
    {
        [Display(Name = "Введите ФИО ")]
        //если мы хотим чтобы поле было обязательным для заполнения
        [Required(ErrorMessage = "Вам нужно ввести ФИО!")]
        public string FIO { get; set; }

        [Display(Name = "Введите название компании")]
        [Required(ErrorMessage = "Вам нужно ввести название компании!")]
        public string Company { get; set; }

        [Display(Name = "Введите логин")]
        [Required(ErrorMessage = "Вам нужно ввести логин!")]
        public string LoginEm { get; set; }

        [Display(Name = "Придумайте пароль пароль")]
        [Required(ErrorMessage = "Вам нужно придумать пароль!")]
        public string PassEm { get; set; }

        [Display(Name = "Повторите пароль")]
        [Required(ErrorMessage = "Вам нужно повторить пароль!")]
        public string PassEm2 { get; set; }


    }
}
