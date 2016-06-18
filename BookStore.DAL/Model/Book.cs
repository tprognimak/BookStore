using System.ComponentModel.DataAnnotations;

namespace BookStore.DAL.Model
{
    public class Book
    {
        public int Id { get; set; }

        [Display(Name = "Название*")]
        [Required(ErrorMessage = " Поле должно быть установлено")]
        public string Name { get; set; }

        public int AuthorId { get; set; }

        [Display(Name = "Жанр")]
        public string Genre { get; set; }

        [Display(Name = "Количество страниц")]
        public int BookLenght { get; set; }
    }
}
