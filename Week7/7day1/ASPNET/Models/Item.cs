using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASPNET.Models
{
	public class Item
	{
		[Key]
		public int ItemId;
		
		[Required]
		[StringLength]
	}
}