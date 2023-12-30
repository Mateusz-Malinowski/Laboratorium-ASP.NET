using Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    [Table("positions")]
    public class PositionEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Salary { get; set; }

        public ISet<EmployeeEntity> Employees { get; set; }
    }
}
