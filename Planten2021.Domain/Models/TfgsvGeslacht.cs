﻿using System;
using System.Collections.Generic;

namespace Planten2021.Domain.Models
{
    public partial class TfgsvGeslacht
    {
        public long GeslachtId { get; set; }
        public long FamilieFamileId { get; set; }
        public string Geslachtnaam { get; set; }
        public string NlNaam { get; set; }
    }
}
