﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{

    public class LookUp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Parent { get; set; }
        public string? Description { get; set; }


    }
}
