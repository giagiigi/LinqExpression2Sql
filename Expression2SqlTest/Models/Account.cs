﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Expression2SqlTest
{
    class Account : BaseEntity
    {
        
        public int UserId { get; set; }
        public string Name { get; set; }
    }
}
