using Spike3.DBObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using AccessAssistant;

namespace Spike3.Controllers
{
   public static class UserControl
   {
      private static int numCustomer;

      public static User CurrentUser { get; set; }
      public static object Items { get; internal set; }

      public static void AddCustomer(Customer c)
      {
         DBController.Save(c, DBObject.SaveTypes.Insert);
      }

      public static void Blacklist(Customer c)
      {
         c.IsBlacklisted = true;
      }

        public static void NotBlacklist(Customer c)
        {
            c.IsBlacklisted = false;
        }

        public static User FindUser(string user)
      {
         Customer c = DBController.GetAllRecords<Customer>().Where(cust => cust.Username == user).FirstOrDefault();
         if (c != null)
            return c;
         Admin a = DBController.GetAllRecords<Admin>().Where(admin => admin.Username == user).FirstOrDefault();
         return a;
      }

      public static Customer FindCustomer(string customer)
      {
         Customer c = DBController.GetAllRecords<Customer>().Where(cust => cust.Username == customer).FirstOrDefault();
         return c;
      }

      public static void AddAdmin(Admin a)
      {
         DBController.Save(a, DBObject.SaveTypes.Insert);
      }

      public static List<Customer> GetAllCustomer()
      {
         List<Customer> c = DBController.GetAllRecords<Customer>();
         return c;
      }
      /*public static List<Customer> Filter(bool isblacked)
      {
         List<Customer> c = GetAllCustomer();
         if (isblacked)
            c = c.Where(Customer => Customer.IsBlacklisted == isblacked).ToList();
         else
            c = c.Where(Customer => Customer.IsBlacklisted != isblacked).ToList();
            return c;
      }
      */
      public static List<string> DisplayCustomerInfo(string id)
      {
         Customer c = FindCustomer(id);
         string firstName = c.FirstName.ToString();
         string lastName = c.LastName.ToString();
         string userName = c.Username.ToString();
         string password = c.Password.ToString();
         bool isblacklist = c.IsBlacklisted;
         List<string> list = new List<string>() { firstName, lastName, userName, password, isblacklist.ToString() };
         return list;
      }
   }
}
