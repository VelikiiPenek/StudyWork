using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace StudyWork.Models
{
    public class Registration
    {
        [Display(Name = "Введите ФИО")]
        //если мы хотим чтобы поле было обязательным для заполнения
        [Required(ErrorMessage = "Вам нужно ввести ФИО!")]
        public string FIO { get; set; }

        [Display(Name = "Введите логин")]
        //если мы хотим чтобы поле было обязательным для заполнения
        [Required(ErrorMessage = "Вам нужно ввести логин!")]
        public string Login { get; set; }

        [Display(Name = "Введите пароль")]
        //если мы хотим чтобы поле было обязательным для заполнения
        [Required(ErrorMessage = "Вам нужно ввести пароль!")]
        public string PassSt { get; set; }

        [Display(Name = "Повторите пароль ")]
        //если мы хотим чтобы поле было обязательным для заполнения
        [Required(ErrorMessage = "Вам нужно повторить пароль!")]
        public string PassSt2 { get; set; }

        [Display(Name = "Введите почту")]
        //если мы хотим чтобы поле было обязательным для заполнения
        [Required(ErrorMessage = "Вам нужно ввести почту!")]
        public string Email { get; set; }


        [Display(Name = "Введите языки программирования, на которых программируете")]
        //если мы хотим чтобы поле было обязательным для заполнения
        [Required(ErrorMessage = "Вам нужно ввести языки программирования!")]
        public string ProgLanguages { get; set; }


}
}
