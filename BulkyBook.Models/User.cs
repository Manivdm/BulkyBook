using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
       
        public string? UserName { get; set; }
        [Required]
        [ForeignKey("Name")]
        public string? Name { get; set; }
        [Required]
        public string? email { get; set; }
        [Required]
        public string? password { get; set; }
        [NotMapped]
        public string? Status { get; set; }

    }
}
