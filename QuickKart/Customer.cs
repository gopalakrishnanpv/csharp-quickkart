using System;
namespace QuickKart
{
    public class Customer
    {
        public int customerId;
        public string customerName;
        public string address;
        public long phoneNumber;
        public string emailId;

        public Customer()
        {
            customerName = "Not Assigned";
            address = "Not Assigned";
            phoneNumber = 0;
            emailId = "Not Assigned";
        }

    }
}
