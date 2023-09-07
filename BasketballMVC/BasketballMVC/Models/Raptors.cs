using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BasketballMVC.Models
{
	public class Raptors
	{
		public int Id { get; set; }

		[Display(Name = "Player Number")]
		public int PlayerNum {  get; set; }

		[Display(Name = "Player Name")]
		public string PlayerName { get; set; }

		[Display(Name = "Position")]
		public string PlayerPosition { get; set; }

		[Display(Name = "Salary")]
		//[Column(TypeName ="double(18,2)")]
		public double PlayerSalary {  get; set; }
		[Display(Name = "College")]
		public string PlayerCollege { get; set; }
	}
}
