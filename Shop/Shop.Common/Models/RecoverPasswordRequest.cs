using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Shop.Common.Models
{
    public class RecoverPasswordRequest
    {
        [Required]
        public string Email { get; set; }
    }
}
