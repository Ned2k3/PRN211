using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Winform_ADO
{
    public class Customer
    {
        public string id {  get; set; }
        public string name { get; set; }
        public string dob { get; set; }
        public string gender { get; set; }
        public string address { get; set; }

        public Customer() { }
        public Customer(string id, string name, string dob, string gender, string address)
        {
            this.id = id;
            this.name = name;
            this.dob = dob;
            this.gender = gender;
            this.address = address;
        }
    }
}
