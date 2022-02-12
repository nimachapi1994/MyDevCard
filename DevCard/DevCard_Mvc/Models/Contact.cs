using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_Mvc.Models
{
    public class Contact
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="وارد کردن عبارت نام الزامی می باشد"),MaxLength(100,ErrorMessage ="حداکثر طول نام باید 100 کاراکتر باشد")
            ,MinLength(3,ErrorMessage ="حداقل طول نام باید 3 کاراکتر باشد")]
        public string Name { get; set; }
        [Required(ErrorMessage ="وارد کردن ایمیل الزامی می باشد"),EmailAddress(ErrorMessage ="عبارت ایمیل صحیح نیست")]
        public string Email { get; set; }
        [Required(ErrorMessage = "وارد کردن نوع سرویس اجباری می باشد")]
        public string Service { get; set; }
        [Required(ErrorMessage ="وارد کردن پیغام اجباری می باشد")]
        public string Message { get; set; }
    }
}
