﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ramos14.Models
{
    public class Compra
    {
        public int CompraId { get; set; }
        public string Cliente { get; set; }
        public string Total { get; set; }
        public string Vendedor { get; set; }
    }
}
