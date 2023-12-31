using Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    [Table("departments")]
    public class DepartmentEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }

        public Address Address { get; set; }

        public ISet<EmployeeEntity> Employees { get; set; }
    }
}
