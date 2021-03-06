﻿using System;
using System.Collections.Generic;

namespace Planten2021.Domain.Models
{
    public partial class TfgsvType
    {
        public TfgsvType()
        {
            TfgsvFamilie = new HashSet<TfgsvFamilie>();
        }

        public long Planttypeid { get; set; }
        public string Planttypenaam { get; set; }

        public virtual ICollection<TfgsvFamilie> TfgsvFamilie { get; set; }
    }
}
