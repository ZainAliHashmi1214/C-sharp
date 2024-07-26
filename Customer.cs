//Properties Part 1 

//using System;

//namespace MyNamespace
//{
//    public enum Days
//    {
//        Monday = 1,Tuesday = 22,Wednesday = 33,Thursday = 44,Friday = 55
//    }
//    class Program
//    {
//        public static Days MeetingDate { get; set; } = Days.Monday;
//        static void Main(string[] args)
//        {
//            MeetingDate = Days.Tuesday;
//            Console.WriteLine(" the meeting held on " + MeetingDate);
//            Console.ReadLine();
//        }
//    }
//}

//Properties Part 2

// File 1: Customer.cs
using System;
using Enum_Types;
using MyNamespace;

namespace MyNamespace
{
    public class Customer
    {
        int _custid;
        bool _status;
        string _cname;
        double _balance;
        Cities _City;

        public Customer(int custid, bool status, string cname, double balance, Cities City)
        {
            _custid = custid;
            _status = status;
            _cname = cname;
            _balance = balance;
            _City = City;
        }

        public int custid
        {
            get { return _custid; }
        }

        public bool status
        {
            get { return _status; }
            set { _status = value; }
        }

        public string cname
        {
            get { return _cname; }
            set { _cname = value; }
        }

        public Cities City
        {
            get { return _City; }
            set { _City = value; }
        }


    }
}


