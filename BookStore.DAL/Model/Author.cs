using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookStore.DAL.Model
{
    public class Author
    {
        public int Id { get; set; }

        [Display (Name = "Фамилия*")]
        [Required(ErrorMessage = "Поле должно быть установлено")]
        public string LastName { get; set; }

        [Display(Name = "Имя*")]
        [Required(ErrorMessage = "Поле должно быть установлено")]
        public string FirstName { get; set; }

        [Display(Name = "Отчество")]
        public string FathersName { get; set; }

        [Display(Name = "Год рождения*")]
        [Required(ErrorMessage = "Поле должно быть установлено")]
        public int Birthday { get; set; }
    }
}
