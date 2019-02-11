using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spike3.DBObjects;
using AccessAssistant;

namespace Spike3.Controllers
{
   public class PurchaseControl
   {
      public static int PURCHASE_RATE = 100;
      public static DateTime StartDate { get; set; }
      public static string PickUpLocation { get; set; }
      public static Vehicle SelectedVehicle { get; set; }

      public static void AddPurchase(Purchase p)
      {
         Vehicle v = DBController.GetAllRecords<Vehicle>().Where(vehicle => vehicle.VehicleID == p.VehicleID).FirstOrDefault();
         v.IsRented = true;
         DBController.Save(p, DBObject.SaveTypes.Insert);
         VehicleControl.ModifyVehicle(v);
      }

      public static void DeterminePurchaseCost(Purchase p)
      {
         int vehicleId = p.VehicleID;
         Vehicle v = DBController.GetAllRecords<Vehicle>().Where(vehicle => vehicle.VehicleID == vehicleId).FirstOrDefault();
         int totalCost = VehicleControl.DeterminePrice(v);
         p.Cost = totalCost;
      }
   }
}
