﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncInn.Models
{
    public class NotFoundOrigin
    {
        public string Origin { get; }

        public NotFoundOrigin(string origin)
        {
            Origin = origin;
        }
    }
}
