using System.ComponentModel.DataAnnotations;
using System.Configuration;

namespace temembadding.Models
{
    public class UserProduct
    {
        [Key]
        public int id { get; set; }
        public string ProductName { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int price { get; set; }
        [Required]
        public string Quality { get; set; }
        [RegularExpression("^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}")]
        public string Email { get; set; }
        [RegularExpression ("^[+]*[(]{0,1}[0-9]{1,4}[)]{0,1}[-\\s\\./0-9]*$")]
        public int ContactNumber { get; set; }
        [Required]
        public string Address { get; set; }
    }
}
