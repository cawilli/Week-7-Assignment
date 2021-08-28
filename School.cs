using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_7_Assignment
{
    class School
    {
        // {get; set;} are auto-properties are helpful for encapsulation to your project 
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }

        private string _twitterAddress;
        public string TwitterAddress
            {
                //making sure the twitter address starts with @ symbol
                //needed to create a backing variable string _twitterAddress 
                get { return _twitterAddress; }
                set
                {
                    if (value.StartsWith("@"))
                    {
                        _twitterAddress = value;
                    }
                    else
                    {
                        throw new Exception("The twitter address must begin with @.");
                    }

                }
            }

    }
}
