using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.Insurance.Presentation.Web.Models.API
{
    public class ApiDocumentModel
    {
        public int ID { get; set; }
        public int InsuranceID { get; set; }
        public bool Authuorization { get; set; }
        public byte[] Document { get; set; }
    }
}