using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace StudyWork.Models
{
    public class Study
    {
        [Display(Name = "Введите ФИО")]
        //если мы хотим чтобы поле было обязательным для заполнения
        [Required(ErrorMessage = "Вам нужно ввести Имя, Фамилию и Отчество!")]
        public string FIO { get; set; }

        [Display(Name = "Введите название группы")]
        [Required(ErrorMessage = "Вам нужно ввести название группы!")]
        public string Gr { get; set; }

        [Display(Name = "Введите Сапециальность")]
        [Required(ErrorMessage = "Вам нужно ввести специальность!")]
        public string Specialization { get; set; }

        [Display(Name = "Введите почту")]
        [Required(ErrorMessage = "Вам нужно ввести почту!")]
        public string Email { get; set; }

        [Display(Name = "Введите языки прогаммирования")]
        [Required(ErrorMessage = "Вам нужно ввести языки программировния!")]
        public string ProgLenguages { get; set; }
    }
}
