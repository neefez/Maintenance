using AccessAssistant;

namespace Spike3.DBObjects
{
   public class Admin : User
   {
      private int adminID; // Actually used by DBObject Framework

      [SchemaField(IsPrimaryKey = true)]
      public int AdminID
      {
         get { return adminID; }
      }

      public Admin() { } // Default '[empty]' constructor needed for selecting all records

      public Admin(string newFirstName, string newLastName, string usrnm, string psswrd) : base(newFirstName, newLastName, usrnm, psswrd) { }
   }
}
