using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OpenQbit.Insurance.Service.WebApi.Models.API
{
    public class ApiDocumentModel
    {
        public int ID { get; set; }
        public int InsuranceID { get; set; }
        public String Authuerisation { get; set; }
        public int Copy { get; set; }
    }
}