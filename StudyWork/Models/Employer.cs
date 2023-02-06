using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace StudyWork.Models
{
    public class Employer
    {
        [Display(Name = "Введите имя")]
        //если мы хотим чтобы поле было обязательным для заполнения
        [Required(ErrorMessage = "Вам нужно ввести имя!")]


        public string Name { get; set; }

        [Display(Name = "Введите фамилию")]
        [Required(ErrorMessage = "Вам нужно ввести фамилию!")]
        public string Surname { get; set; }
    }
}
