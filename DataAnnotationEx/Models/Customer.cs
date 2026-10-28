using System;
using System.ComponentModel.DataAnnotations;

namespace DataAnnotationEx.Models
{
    public class Customer
    {
        public Int64  CustomerID { get; set; }
        //  [DataType(DataType.DateTime)]
        [Display(Name ="Full Name of Customer")]
        public string CustomerName { get; set; }
        [Display(Name ="Current Address")]
        public string Address { get; set; }
        [Display(Name ="Creation Date")]
        public DateTime CreationDate { get; set; }

        [DataType(DataType.Password)] //helpers
        public string Password { get; set; }
        [DataType(DataType.EmailAddress)]
        [Display(Name ="Official Email ID")]
        public string   Email { get; set; }
    }
}
