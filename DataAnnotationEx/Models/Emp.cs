using System;
using System.ComponentModel.DataAnnotations;

namespace DataAnnotationEx.Models
{
    public class Emp
    {
        public Int64    EmpID { get; set; }
        [Required(ErrorMessage ="Emp Name Required")]
        public string EmpName { get; set; }
        
        [Required(ErrorMessage ="Address Required")]
        [StringLength(10,MinimumLength =5,ErrorMessage ="Invalid Address Length")]
        public string Address { get; set; }

        [Required(ErrorMessage ="Email ID Required")]
        [EmailAddress(ErrorMessage ="Invalid Email ID")]
        public string EmailID { get; set; }

        [Required(ErrorMessage ="Mobile No Required")]
        [RegularExpression(@"^\d{10}$",ErrorMessage ="10 Digits Required")]
        public string MobileNo { get; set; }
        [Required(ErrorMessage ="Salary Required")]
        [Range(1000,10000,ErrorMessage ="Invalid Salary Range!")]
        public decimal Salary { get; set; }

        [Required(ErrorMessage ="Password Required")]
        [Compare("ConfirmPassword",ErrorMessage ="Password and Confirm Password are not Same!")]
        public string Password { get; set; }

        [Required(ErrorMessage ="Confirm Password Required")]
        public string ConfirmPassword { get; set; }

    }
}
