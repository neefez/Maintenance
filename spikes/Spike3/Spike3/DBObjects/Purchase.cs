using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessAssistant;

namespace Spike3.DBObjects
{
   public class Purchase : DBObject
   {
      private int purchaseNo; // Actually used by DBObject Framework
      private DateTime purchaseDate;
      private int cost;
      private string pickUpLocation;
      private Customer customer;
      private Vehicle vehicle;

      [SchemaField(IsPrimaryKey = true)]
      public int PurchaseNo
      {
         get { return purchaseNo; }
      }

      [SchemaField()]
      public DateTime PurchaseDate
      {
         get { return purchaseDate; }
         set { purchaseDate = value; }
      }

      [SchemaField(IsForeignKey = true)]
      public int CustomerID
      {
         get { return customer.PrimaryKey; }
         set
         {
            customer = DBController.GetByPrimaryKey<Customer>(value);
         }
      }

      [SchemaField(IsForeignKey = true)]
      public int VehicleID
      {
         get { return vehicle.PrimaryKey; }
         set { vehicle = DBController.GetByPrimaryKey<Vehicle>(value); }
      }

      [SchemaField()]
      public string Location
      {
         get { return pickUpLocation; }
         set { pickUpLocation = value; }
      }

      [SchemaField()]
      public int Cost
      {
         get { return cost; }
         set { cost = value; }
      }

      public Purchase() { }

      public Purchase(DateTime setStartDate, string setStartLocation, Vehicle setVehicle, Customer setCustomer)
      {
         purchaseDate = setStartDate;
         pickUpLocation = setStartLocation;
         customer = setCustomer;
         vehicle = setVehicle;
      }
   }
}