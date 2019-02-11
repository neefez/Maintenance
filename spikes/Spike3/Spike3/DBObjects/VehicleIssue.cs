using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessAssistant;

namespace Spike3.DBObjects
{
   public class VehicleIssue : DBObject
   {
      private int issueID;
      private string issue;
      private DateTime issueDate;
      private Vehicle vehicle;
      private bool isFixed;

      [SchemaField(IsPrimaryKey = true)]
      public int IssueID
      {
         get { return issueID; }
      }

      [SchemaField()]
      public DateTime IssueDate
      {
         get { return issueDate; }
         set { issueDate = value; }
      }

      [SchemaField()]
      public String Issue
      {
         get { return issue; }
         set { issue = value; }
      }

      [SchemaField(IsForeignKey = true)]
      public int VehicleID
      {
         get { return vehicle.PrimaryKey; }
         set { vehicle = DBController.GetByPrimaryKey<Vehicle>(value); }
      }

      [SchemaField()]
      public bool IsFixed
      {
         get { return isFixed; }
         set { isFixed = value; }
      }

      public VehicleIssue() { }

      public VehicleIssue(DateTime date,string problem,Vehicle v1)
      {
         issueDate = date;
         issue = problem;
         vehicle = v1;
         isFixed = false;
      }



   }
}
