using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace EntityFramework.Data
{
    public class Employee
    {
        [Key]
        public int EmpolyeeId { get; set; }
        public string FullName { get; set; }
        
    }
}
