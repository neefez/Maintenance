using System;
using System.Linq;
using AccessAssistant;
using Spike3.DBObjects;
using System.Collections.Generic;

namespace Spike3.Controllers
{
   public static class RentalControl
   {
      private static int numRentedOut = 0;
      private static int totalRentals = 0;
      public const int FEES = 50;

      public static DateTime StartDate { get; set; }
      public static DateTime EndDate { get; set; }
      public static string PickUpLocation { get; set; }
      public static string DropOffLocation { get; set; }
      public static Vehicle SelectedVehicle { get; set; }

      public static bool AddRental(Rental r)
      {
         List<Rental> r1 = DBController.GetAllRecords<Rental>().Where(rental => rental.CustomerID == r.CustomerID || rental.VehicleID == r.VehicleID).ToList();
         bool noneActive = true;
         foreach(Rental item in r1)
         {
            if (item.Active)
               noneActive = false;
         }
         if (r1 == null || noneActive)
         {
            r.Active = true;
            Vehicle v = DBController.GetAllRecords<Vehicle>().Where(vehicle => vehicle.VehicleID == r.VehicleID).FirstOrDefault();
            v.IsRented = true;
            DBController.Save(r, DBObject.SaveTypes.Insert);
            VehicleControl.ModifyVehicle(v);
            return true;
         }
         return false;
      }

      public static void CompleteRental(Rental r)
      {
         r.Active = false;
         DBController.Save(r, DBObject.SaveTypes.Update);
      }

      public static void DetermineCost(Rental r, bool babySeat, bool navigationSystem)
      {
         int vehicleId = r.VehicleID;
         Vehicle v = DBController.GetAllRecords<Vehicle>().Where(vehicle => vehicle.VehicleID == vehicleId).FirstOrDefault();
         int vehicleRate = v.Rate;
         int rentDate = r.EndDate.DayOfYear - r.StartDate.DayOfYear + 1;
         int accFee = AccessoryFee(r, babySeat, navigationSystem);
         int totalCost = vehicleRate * rentDate + accFee;
         r.Cost = totalCost;
      }

      public static Rental findRental()
      {
         Customer c1 = (Customer)UserControl.CurrentUser;
         Rental r1 = DBController.GetAllRecords<Rental>().Where(rental => rental.CustomerID == c1.CustomerID && rental.Active).FirstOrDefault();
         return r1;
      }

      public static int AccessoryFee(Rental r, bool baby, bool satnav)
      {
         int amount = 0;
         if (baby)
            amount += FEES;
         if (satnav)
            amount += FEES;
         r.feeAmt = amount;
         return amount;
      }
   }
}