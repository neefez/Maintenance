using System;
using AccessAssistant;

namespace Spike3.DBObjects
{
   public class Rental : DBObject
   {
      private int rentalNo; // Actually used by DBObject Framework
      private DateTime startDate;
      private DateTime endDate;
      private int cost;
      private string pickUpLocation;
      private string dropOffLocation;
      private Customer customer;
      private Vehicle vehicle;
      public int feeAmt { get; set; }
      private const int BABYSEATAMOUNT = 50;
      private const int NAVIGATIONSYSTEMAMOUNT = 100;
      private bool active;

      [SchemaField(IsPrimaryKey = true)]
      public int RentalNo
      {
         get { return rentalNo; }
      }

      [SchemaField()]
      public DateTime StartDate
      {
         get { return startDate; }
         set { startDate = value; }
      }

      [SchemaField()]
      public DateTime EndDate
      {
         get { return endDate; }
         set { endDate = value; }
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
      public string PickUpLocation
      {
         get { return pickUpLocation; }
         set { pickUpLocation = value; }
      }

      [SchemaField()]
      public string DropOffLocation
      {
         get { return dropOffLocation; }
         set { dropOffLocation = value; }
      }

      [SchemaField()]
      public int Cost
      {
         get { return cost; }
         set { cost = value; }
      }

      [SchemaField()]
      public bool Active
      {
         get { return active; }
         set { active = value; }
      }

      public Rental() { }

      public Rental(DateTime setStartDate, DateTime setEndDate, string setStartLocation, string setEndLocation, Vehicle setVehicle, Customer setCustomer)
      {
         startDate = setStartDate;
         endDate = setEndDate;
         pickUpLocation = setStartLocation;
         dropOffLocation = setEndLocation;
         customer = setCustomer;
         vehicle = setVehicle;
         active = false;
      }
   }
}
