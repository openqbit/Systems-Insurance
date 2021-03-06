﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Insurance.Common.Models
{
    public class DocumentModel
    {
        public int ID { get; set; }
        public int InsuranceID { get; set; }
        public bool Authuorization { get; set; }
        public byte[] Document { get; set; }
        public virtual ICollection<InsuranceModel> Insurance { get; set; }
    }
}
