﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnePiece.Web.Models
{
    public class ListRequest
    {
        public int Skip { get; set; }

        public int Take { get; set; }
    }
}
