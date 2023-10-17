using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Laboratorium3___App.Models
{
    public class Contact
    {
        [HiddenInput]
        public int Id { get; set; }
        [Required(ErrorMessage = "You must specify the name!")]
        [StringLength(maximumLength: 50, ErrorMessage = "Too long name, max 50 chars")]
        public string Name { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public string? Phone { get; set; }
        public DateTime? Birth { get; set; }
    }
}
