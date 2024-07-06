using System.ComponentModel.DataAnnotations;

namespace temembadding.Models
{
	public class Products
	{
		[Key]
	    public int id { get; set; }
		[Required]
		public string Description { get; set; }
		[Required ]
		public int price { get; set; }
		[Required]
		public string Quality { get; set; }
	}
}
