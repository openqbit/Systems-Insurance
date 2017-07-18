using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenQbit.Insurance.Common.Models
{
    public class ClientModel
    {
        public enum Genders
        {
            MALE, FEMALE, OTHER
        }
        public enum BloodGroups
        {
            O_pos, O_neg, B_pos, B_neg, A_pos, A_neg, AB_pos, AB_neg
        }
        public int ID { get; set; }
        public string First_Name { get; set; }
        public string Middle_Name { get; set; }
        public string Last_Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public DateTime Date_of_Birth { get; set; }
        public Genders? Gender { get; set; }
        public string Nationality { get; set; }
        public string Religion { get; set; }
        public BloodGroups? BloodGroup { get; set; }
        public string Email { get; set; }
        public int Mobile { get; set; }
        public int Telephone { get; set; }

    }
}
