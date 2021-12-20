using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemIOWindowsFormApp
{
    public class Personnel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public string Country { get; set; }


        public override string ToString()
        {
            return this.Name + " " + this.Surname;
        }

        public string GetPersonnelInformationDetails()
        {
            string details = string.Empty;
            details = $"Details belongs to {Name} {Surname} are listed.\nCompany : {Company}\nContact : {Email}";
            return details;
        }
    }

}
