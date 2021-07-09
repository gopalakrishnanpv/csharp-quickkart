using System;
using System.Collections.Generic;
using QuickKart;

namespace QuickKartTestApp
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var userName = true;
            //Customer customer = new Customer();
            //customer.customerId = Convert.ToInt32(Console.ReadLine());
            ////{
            ////    //customerId = 123,
            ////    //customerName = "Krishna",
            ////    //address = "54 Test Address",
            ////    //emailId = "testemail@test.com",
            ////    //phoneNumber = 4978743984
            ////};
            //Console.WriteLine("Customer ID = " + customer.customerId);
            //Console.WriteLine("Customer Name = " + customer.customerName);
            //Console.WriteLine("Address = " + customer.address);
            //Console.WriteLine("Phone Number = " + customer.phoneNumber);
            //Console.WriteLine("Email ID = " + customer.emailId);
            //SortedList<int, string> SortedProductList = new SortedList<int, string>();
            //SortedProductList.Add(003, "John");
            //SortedProductList.Add(001, "Babu");
            //SortedProductList.Add(2, "Shankar");

            //foreach(KeyValuePair<int, string> pair in SortedProductList)
            //{
            //    Console.WriteLine(pair);
            //}

            object[] hemanth = new object[] { 2, "hemanth", 2.5 };
            foreach(var item in hemanth)
            {
                Console.WriteLine(item);
            }
        }
    }
}
