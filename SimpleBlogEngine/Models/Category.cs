﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleBlogEngine.Models
{
    public class Category : IEntity
    {
        public int CategoryID { get; set; }
        public string Name { get; set; }
    }
}
