using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace st10397913_PROG_ICETASK1
{
    public class Customer
    {
        decimal balance;
        string email, phone, name;
        DateTime lastPurchase;

        public Customer(string name, string email, string phone, decimal balance, DateTime lastPurchase)
        {
            this.name = name;
            this.email = email;
            this.phone = phone;
            this.balance = balance;
            this.lastPurchase = lastPurchase;
        }

        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return this.name;
                else if (index == 1)
                    return this.email;
                else if (index == 2)
                    return this.phone;
                else if (index == 3)
                    return this.balance;
                else if (index == 4)
                    return this.lastPurchase;
                return null;

            }
            set
            {

                if (index == 0)
                    this.name = (string)value;
                else if (index == 1)
                    this.email = (string)value;
                if (index == 2)
                    this.phone = (string)value;
                else if (index == 3)
                    this.balance = (decimal)value;
                if (index == 4)
                    this.lastPurchase = (DateTime)value;
            }
        }


        public object this[string attrName]
        {
            get
            {
                if (attrName.ToLower().Equals("empnumber"))
                    return this.name;
                if (attrName.ToLower().Equals("jobtitle"))
                    return this.email;
                if (attrName.ToLower().Equals("name"))
                    return this.phone;
                if (attrName.ToLower().Equals("surname"))
                    return this.balance;
                if (attrName.ToLower().Equals("salary"))
                    return this.lastPurchase;
                return null;

            }
            set
            {

                if (attrName.ToLower().Equals("empnumber"))
                    this.name = (string)value;
                if (attrName.ToLower().Equals("jobtitle"))
                    this.email = (string)value;
                if (attrName.ToLower().Equals("name"))
                    this.phone = (string)value;
                if (attrName.ToLower().Equals("surname"))
                    this.balance = (decimal)value;
                if (attrName.ToLower().Equals("salary"))
                    this.lastPurchase = (DateTime)value;
            }
        }
    }
}
    

