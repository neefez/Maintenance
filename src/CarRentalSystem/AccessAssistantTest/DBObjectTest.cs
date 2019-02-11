using System;
using AccessAssistant;
using CarRentalSystem.DBObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AccessAssistantTest
{
   [TestClass]
   public class DBObjectTest
   {
      [TestMethod]
      public void TestConstructor()
      {
         DBObject dbObject = new Admin();
         Assert.IsNotNull(dbObject);
      }

      [TestMethod]
      public void TestGetPrimaryKey()
      {
         Admin admin = new Admin("fName", "lName", "uName", "pWord");
         Assert.AreEqual(admin.PrimaryKey, 0);
         DBController.Save(admin, DBObject.SaveTypes.Insert);
         Assert.AreNotEqual(admin.PrimaryKey, 0);
      }

      [TestMethod]
      [ExpectedException(typeof(NotImplementedException))]
      public void TestMissingPrimaryKeySchemaField()
      {
         ClassMissingPrimaryKeySchemaField badGuy = new ClassMissingPrimaryKeySchemaField();
         int expectedPrimaryKey = badGuy.PrimaryKey;
      }

      private sealed class ClassMissingPrimaryKeySchemaField : DBObject
      {
         [SchemaField()]
         public int DummyProperty { get; set; }
      }

   }
}
