using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework.Data
{
    class Vacation
    {
        public int VacationID { get; set; }

        public int EmployeeID { get; set; }
       public Employee Employee { get; set; }
        public string Startdate { get; set; }
        public string EndDate { get; set; }
        public string VacationType { get; set; }
        public DateTime Date { get; set; }
    }
}
