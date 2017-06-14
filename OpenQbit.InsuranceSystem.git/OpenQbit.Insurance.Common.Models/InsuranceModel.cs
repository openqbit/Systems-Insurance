using System;

namespace OpenQbit.Insurance.Common.Models
{
    public class InsuranceModel
    {
        public int ID { get; set; }
        public int AgentID { get; set; }
        public int ClientID { get; set; }
        public DateTime Joining_Date { get; set; }
        public DateTime End_Date { get; set; }
        public Decimal Total_Value { get; set; }
        public virtual DocumentModel document { get; set; }
    }
}