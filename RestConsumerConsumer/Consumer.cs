﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestConsumerConsumer
{
    class Customer
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Year { get; set; }

        public Customer(int id, string first, string last, int year)
        {
            Id = id;
            FirstName = first;
            LastName = last;
            Year = year;


        }

        public Customer()
        {

        }

    }
}
