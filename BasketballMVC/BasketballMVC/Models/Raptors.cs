using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BasketballMVC.Models
{
	public class Raptors
	{
		public int Id { get; set; }

		[Range(0,100)]
		[Required]
		[Display(Name = "Player Number")]
		public int PlayerNum {  get; set; }

		[StringLength(60,MinimumLength = 2)]
		[Required]
		[Display(Name = "Player Name")]
		public string PlayerName { get; set; }

        [StringLength(15, MinimumLength = 2)]
        [Required]
		[Display(Name = "Position")]
		public string PlayerPosition { get; set; }

		[Range(1,900000000)]
		[DataType(DataType.Currency)]
		[Required]
		[Display(Name = "Salary")]
		public double PlayerSalary {  get; set; }

        [StringLength(60, MinimumLength = 2)]
        [Required]
		[Display(Name = "College")]
		public string PlayerCollege { get; set; }
	}
}
