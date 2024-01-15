using System.ComponentModel.DataAnnotations;

namespace Project_MVC.Models
{
	public class Contact
	{
		[Required(ErrorMessage ="وارد کردن نام الزامی است")]
		[MinLength(3,ErrorMessage ="حداقل طول کاراکتر 3")]
		[MaxLength(100, ErrorMessage ="حداکثر طول کاراکتر 100")]
		public string Name { get; set; }

		[EmailAddress(ErrorMessage ="ایمیل وارد شده صحیح نمی باشد")]
		[Required(ErrorMessage ="وارد کردن ایمیل الزامی است")]
		public string Email { get; set; }
		public string Service { get; set; }
		public string Message { get; set; }
	}
}
