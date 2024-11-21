using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLibrary.Entities
{
    public class Country :BaseEntity
    {
        //one to many relationshop with city
        public List<City>? cities {  get; set; }
    }

}
