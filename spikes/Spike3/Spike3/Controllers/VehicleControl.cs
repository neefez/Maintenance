using Spike3.DBObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using AccessAssistant;

namespace Spike3.Controllers
{
   public static class VehicleControl
   {
      public static int PURCHASE_RATE = 100;

      public static void AddVehicle(Vehicle v)
      {
         DBController.Save(v, DBObject.SaveTypes.Insert);
      }

      public static Vehicle FindVehicle(string id)
      {
         int numID = Convert.ToInt32(id);
         Vehicle v = DBController.GetAllRecords<Vehicle>().Where(vehicle => vehicle.VehicleID == numID).FirstOrDefault();
         return v;
      }

      public static List<string> DisplayCarInfo(string id)
      {
         Vehicle v = FindVehicle(id);
         string carType = v.Type.ToString();
         string carColor = v.Color.ToString();
         string carYear = v.VehicleYear.ToString();
         string carModel = v.Model.ToString();
         string carMake = v.Make.ToString();
         bool rightHandControl = v.RightHandControlled;
         bool manualTransmission = v.ManualTransmission;
         string rate = v.Rate.ToString();
         List<string> list = new List<string>() { carType, carColor, carYear, carModel, carMake, rightHandControl.ToString(), manualTransmission.ToString() };
         return list;
      }

      public static bool RemoveVehicle(Vehicle v)
      {
         return DBController.Delete(v);
      }

      public static bool ModifyVehicle(Vehicle v)
      {
         return DBController.Save(v, DBObject.SaveTypes.Update);
      }

      public static List<Vehicle> GetAllVehicles()
      {
         List<Vehicle> v = DBController.GetAllRecords<Vehicle>();
         return v;
      }

      public static List<Vehicle> FilterCar(string carType, string carColor, string makeType, int carYearFirst, int carYearSecond, bool rightHand, bool manual, string location)
      {
         List<Vehicle> lv = GetAllVehicles();
         lv = lv.Where(vehicle => !vehicle.IsRented).ToList();
         if (carType != null && carType != "None")
            lv = lv.Where(vehicle => vehicle.Type == carType).ToList();
         if (carColor != null && carColor != "None")
            lv = lv.Where(vehicle => vehicle.Color == carColor).ToList();
         if (makeType != null && makeType != "None")
            lv = lv.Where(vehicle => vehicle.Make == makeType).ToList();
         if (location != null && location != "None")
            lv = lv.Where(vehicle => vehicle.CurrentLocation == location).ToList();
         
         lv = lv.Where(vehicle => vehicle.VehicleYear >= carYearFirst && vehicle.VehicleYear <= carYearSecond && vehicle.RightHandControlled == rightHand && vehicle.ManualTransmission == manual).ToList();
         return lv;
      }

      public static int DeterminePrice(Vehicle v)
      {
         return v.Rate * PURCHASE_RATE;
      }
   }
}
