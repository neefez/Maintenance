using System;

namespace AccessAssistant
{

   [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
   public class SchemaField : Attribute
   {
      public bool IsPrimaryKey { get; set; } = false;
      public bool IsForeignKey { get; set; } = false;
   }

}
