﻿using System;
using System.Collections.Generic;

namespace Planten2021.Domain.Models
{
    public partial class TfgsvVariant
    {
        public long VariantId { get; set; }
        public long SoortSoortid { get; set; }
        public string Variantnaam { get; set; }
        public string NlNaam { get; set; }
    }
}
