using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesCh12.Models
{
    public class DepartmentLocation
    {
        // Composite Primary key and foreign key for Department
        public int DepartmentID { get; set; }
        // Composite Primary key and foreign key for location
        public int LocationID { get; set; }

        // navigation properties
        public Department Department { get; set; }
        public Location Location { get; set; }
    }
}
