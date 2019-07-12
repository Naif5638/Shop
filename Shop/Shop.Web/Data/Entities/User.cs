using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Web.Data.Entities
{
    public class User : IdentityUser
    {
        [Required]
        [Display(Name ="First Name")]
        [MaxLength(50, ErrorMessage = "The fiel {0} only can contain {1} characters length.")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [MaxLength(50, ErrorMessage = "The fiel {0} only can contain {1} characters length.")]
        public string LastName { get; set; }

        [MaxLength(100,ErrorMessage ="The fiel {0} only can contain {1} characters length.")]
        public string Address { get; set; }

        public int CityId { get; set; }
        public City City { get; set; }

        [Display(Name = "Phone Number")]
        public override string PhoneNumber { get => base.PhoneNumber; set => base.PhoneNumber = value; }

        [Display(Name = "Full Name")]
        public string Fullname { get{ return $"{this.FirstName} {this.LastName}"; }  }

        [NotMapped]
        [Display(Name = "is Admin?")]
        public bool IsAdmin { get; set; }
    }
}
