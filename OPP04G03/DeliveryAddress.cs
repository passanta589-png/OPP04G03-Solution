using System;
using System.Collections.Generic;
using System.Text;

namespace OPP04G03
{
    internal class DeliveryAddress
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public DeliveryAddress(string street, string city, string state, string zipCode)
        {
            Street = street;
            City = city;
            State = state;
            ZipCode = zipCode;
        }

        internal object GetFullAddress()
        {
            throw new NotImplementedException();
        }
    }
}
