using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLibrary.Entities
{
    public class Town : BaseEntity
    {
        //One TO many relationship employee
        public List<Employee>? Employees { get; set; }
        //Many  to one relationship between city
        public City? City { get; set; }
        public int CityId { get; set; }

    }
}
