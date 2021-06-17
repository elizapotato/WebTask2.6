using System.ComponentModel.DataAnnotations;

namespace Web._931803.Chegodaeva.Lab6.Models
{
    public class ForumCategory
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
    }
}