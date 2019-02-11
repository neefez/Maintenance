using AccessAssistant;
using System.Drawing;

namespace Spike3.DBObjects
{
   public class Vehicle : DBObject
   {
      private int vehicleID; // Actually used by DBObject Framework
      private string type;
      private string color;
      private string make;
      private string model;
      private string currentLocation;
      private int year;
      private bool isRightHandControlled;
      private bool isManualTransmission;
      private bool isDamaged;
      private string vehicleImage;
      private bool isRented;
      private int rate;

      #region VehicleProperties

      [SchemaField(IsPrimaryKey = true)]
      public int VehicleID
      {
         get { return vehicleID; }
      }

      [SchemaField()]
      public string Type
      {
         get { return type; }
         set { type = value; }
      }

      [SchemaField()]
      public string Color
      {
         get { return color; }
         set { color = value; }
      }

      [SchemaField()]
      public string Make
      {
         get { return make; }
         set { make = value; }
      }

      [SchemaField()]
      public string Model
      {
         get { return model; }
         set { model = value; }
      }

      [SchemaField()]
      public int VehicleYear
      {
         get { return year; }
         set { year = value; }
      }

      [SchemaField()]
      public bool IsDamaged
      {
         get { return isDamaged; }
         set { isDamaged = value; }
      }

      [SchemaField()]
      public bool IsRented
      {
         get { return isRented; }
         set { isRented = value; }
      }

      [SchemaField()]
      public int Rate
      {
         get { return rate; }
         set { rate = value; }
      }


      [SchemaField()]
      public bool RightHandControlled
      {
         get { return isRightHandControlled; }
         set { isRightHandControlled = value; }
      }


      [SchemaField()]
      public bool ManualTransmission
      {
         get { return isManualTransmission; }
         set { isManualTransmission = value; }
      }

      [SchemaField()]
      public string CurrentLocation
      {
         get { return currentLocation; }
         set { currentLocation = value; }
      }

      [SchemaField()]
      public string VehicleImage
      {
         get { return vehicleImage; }
         set { vehicleImage = value; }
      }


      #endregion

      public Vehicle()
      {
         type = "DEFAULT";
         color = "DEFAULT";
         make = "DEFAULT";
         model = "DEFAULT";
         year = 0;
         currentLocation = "DEFAULT";
         isRightHandControlled = false;
         isManualTransmission = false;
         isDamaged = false;
         isRented = false;
         rate = 0;
      }

      public Vehicle(string carType, string carColor, int carYear, string carModel, string carMake,
          bool rightHandControl, bool manualTrans, int carRate, string curntLocation, string vehicleimage)
      {
         type = carType;
         color = carColor;
         make = carMake;
         model = carModel;
         year = carYear;
         currentLocation = curntLocation;
         isRightHandControlled = rightHandControl;
         isManualTransmission = manualTrans;
         isDamaged = false;
         isRented = false;
         rate = carRate;
         vehicleImage = vehicleimage;
      }


      public override string ToString()
      {
         return $"{VehicleYear} {Color} {Make} {Model} {Type} ${Rate}/day";
      }

   }
}
