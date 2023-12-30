using Data.Entities;
using Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel.DataAnnotations;

namespace Laboratorium3___Employee.Models
{
    public class Position
    {
        [HiddenInput]
        public int Id { get; set; }

        public string Name { get; set; }

        public int Salary { get; set; }
    }
}
