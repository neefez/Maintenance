using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.DBHelpers
{
   [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
   public class SchemaField : Attribute
   {
      public bool IsPrimaryKey { get; set; } = false;
   }
}
