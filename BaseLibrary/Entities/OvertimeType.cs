﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLibrary.Entities
{
    public class OverTimeType :BaseEntity
    {
        //many one to one relationship with Vacation
        public List<Overtime>? Overtime { get; set; }
    }
}