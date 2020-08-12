using System;
using System.ComponentModel.DataAnnotations;

namespace ASP_MVC.Models
{
    public class ContactListEntry
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]
        public ContactType ContactType { get; set;  }

        [Required]
        [StringLength(60)]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        public DateTime? DateOfBorth { get; set; }

        [StringLength(30)]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }

        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public enum ContactType
    {
        Person = 0,
        Company
    }
}
