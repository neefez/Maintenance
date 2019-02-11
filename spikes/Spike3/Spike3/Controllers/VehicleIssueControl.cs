using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spike3.DBObjects;
using AccessAssistant;

namespace Spike3.Controllers
{
   public static class VehicleIssueControl
   {


      public static bool AddIssue(VehicleIssue vI)
      { 
         try
         {
            DBController.Save(vI, DBObject.SaveTypes.Insert);
         }
         catch(Exception e)
         {
            return false;
         }
         return true;
      }


   }
}
