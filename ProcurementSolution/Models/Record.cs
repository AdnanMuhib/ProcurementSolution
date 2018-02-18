﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProcurementSolution.Models
{
    class Record
    {
        public static List<Accessory> accessories = new List<Accessory>();
        public static List<IssueAccessory> issued_accessories = new List<Models.IssueAccessory>();
        public static List<Employee> employees = new List<Employee>();
        public static List<Category> categories = new List<Category>();

        public static void UpdateStock(Accessory accessory)
        {
            // condition to check if accessory is there
            // then only update the quantity
            // otherwise add as new product
            accessories.Add(accessory);
        }

        public static void printAvailableAccessories()
        {
            // Print all accessories
            Console.WriteLine(accessories.ToString());
        }

        public static List<Accessory> getAvailableAccessories()
        {
            return accessories;
        }
        


        public static void IssueAccessory(IssueAccessory acc)
        {
            issued_accessories.Add(acc);
        }


        public static void AddEmployee(Employee emp)
        {
            employees.Add(emp);
        }

        public static List<Employee> GetEmployees()
        {
            return employees;
        }

        public static void AddCategory(Category cat)
        {
            categories.Add(cat);
        }
    }
}
