using AccessAssistant;

namespace Spike3.DBObjects
{
   public abstract class User : DBObject
   {
      private string firstName;
      private string lastName;
      private string username;
      private string password;

      [SchemaField()]
      public string FirstName { get { return firstName; } set { firstName = value; } }
      [SchemaField()]
      public string LastName { get { return lastName; } set { lastName = value; } }
      [SchemaField()]
      public string Username { get { return username; } set { username = value; } }
      [SchemaField()]
      public string Password { get { return password; } set { password = value; } }

      public User() { }

      public User(string newFirstName, string newLastName, string usrnm, string psswrd)
      {
         firstName = newFirstName;
         LastName = newLastName;
         password = psswrd;
         username = usrnm;
      }
   }
}
