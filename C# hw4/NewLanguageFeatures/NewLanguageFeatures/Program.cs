﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace NewLanguageFeatures
{
    public delegate bool KeyValueFilter<K, V>(K key, V value);
    public static class Extensions
    {
        public static List<K> FilterBy<K, V>(
        this Dictionary<K, V> items,
        KeyValueFilter<K, V> filter)
        {
            var result = new List<K>();

            foreach (KeyValuePair<K, V> element in items)
            {
                if (filter(element.Key, element.Value))
                    result.Add(element.Key);
            }
            return result;
        }

        public static bool Compare(this Customer customer1, Customer customer2)
        {
            if (customer1.CustomerID == customer2.CustomerID &&
                customer1.Name == customer2.Name &&
                customer1.City == customer2.City)
            {
                return true;
            }

            return false;
        }
        public static List<T> Append<T>(this List<T> a, List<T> b)
        {
            var newList = new List<T>(a);
            newList.AddRange(b);
            return newList;
        }

    }

    public class Store
    {
        public string Name { get; set; }
        public string City { get; set; }

        public override string ToString()
        {
            return Name + "\t" + City;
        }
    }



    

    public class Customer
    {
        public int CustomerID { get; private set; }
        public string Name { get; set; }
        public string City { get; set; }

        public Customer(int ID)
        {
            CustomerID = ID;
        }


        public override string ToString()
        {
            return Name + "\t" + City + "\t" + CustomerID;
        }
    }


    class Program
    {
        static void VarTest()
        {
            var x = new[] { 1, 2, 3 };
        }

        static void Main(string[] args)
        {
            Query();

        }
        public static List<Customer> FindCustomersByCity(
        List<Customer> customers,
        string city)
            {
            return customers.FindAll(c => c.City == city);
        }


        static List<Customer> CreateCustomers()
        {
            return new List<Customer>
            {
                new Customer(1) { Name = "Maria Anders",     City = "Berlin"    },
                new Customer(2) { Name = "Laurence Lebihan", City = "Marseille" },
                new Customer(3) { Name = "Elizabeth Brown",  City = "London"    },
                new Customer(4) { Name = "Ann Devon",        City = "London"    },
                new Customer(5) { Name = "Paolo Accorti",    City = "Torino"    },
                new Customer(6) { Name = "Fran Wilson",      City = "Portland"  },
                new Customer(7) { Name = "Simon Crowther",   City = "London"    },
                new Customer(8) { Name = "Liz Nixon",        City = "Portland"  }
             };
        }

        static List<Store> CreateStores()
        {
            return new List<Store>
      {
        new Store { Name = "Jim’s Hardware",    City = "Berlin" },
        new Store { Name = "John’s Books",  City = "London" },
        new Store { Name = "Lisa’s Flowers",    City = "Torino" },
        new Store { Name = "Dana’s Hardware",   City = "London" },
        new Store { Name = "Tim’s Pets",    City = "Portland" },
        new Store { Name = "Scott’s Books",     City = "London" },
        new Store { Name = "Paula’s Cafe",  City = "Marseille" },
      };
        }
        static void Query()
        {
            var results = from c in CreateCustomers()
                          select new
                          {
                              c.CustomerID,
                              c.City,
                              CustomerName = c.Name,
                              Stores = CreateStores().Where(s => s.City == c.City)
                          };

            foreach (var result in results)
            {
                Console.WriteLine("{0}\t{1}", result.City, result.CustomerName);
                foreach (var store in result.Stores)
                    Console.WriteLine("\t<{0}>", store.Name);
            }

        }
    }
}
