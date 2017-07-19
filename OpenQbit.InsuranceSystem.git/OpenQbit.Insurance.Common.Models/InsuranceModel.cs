using System;

namespace OpenQbit.Insurance.Common.Models
{
    public class InsuranceModel
    {

        public enum InsuranceTypes
        {
            LIFE_INSURANCE,
            RE_INSURANCE,
            MOTOR_INSURANCE,
            MARINE_INSURANCE,
            FIRE_INSURANCE
        }

        public int ID { get; set; }
        public int AgentID { get; set; }
        public int ClientID { get; set; }
        public InsuranceTypes InsuranceType { get; set; }
        public DateTime Joining_Date { get; set; }
        public DateTime End_Date { get; set; }
        public Decimal Total_Value { get; set; }
    }
}