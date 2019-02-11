using AccessAssistant;
using System;

namespace Spike3.DBObjects
{
   public class Customer : User
   {
      public const int VALID_CREDIT_SCORE = 675;

      private const int MIN_CREDIT_SCORE = 550;
      private const int MAX_CREDIT_SCORE = 850;

      private int customerID; // Actually used by DBObject Framework
      private bool isBlacklisted;
      private int creditScore;
      private Random creditScoreGenerator = new Random();

      [SchemaField(IsPrimaryKey = true)]
      public int CustomerID
      {
         get { return customerID; }
      }

      [SchemaField()]
      public bool IsBlacklisted
      {
         get { return isBlacklisted; }
         set { isBlacklisted = value; }
      }

      public int CreditScore
      {
         get { return creditScore; }
      }

      public Customer()
      {
         creditScore = creditScoreGenerator.Next(MIN_CREDIT_SCORE, MAX_CREDIT_SCORE);
      }

      public Customer(string newFirstName, string newLastName, string usrnm, string psswrd) : base(newFirstName, newLastName, usrnm, psswrd)
      {
         isBlacklisted = false;
         creditScore = creditScoreGenerator.Next(MIN_CREDIT_SCORE, MAX_CREDIT_SCORE);
      }

      public override string ToString()
      {
         return $"{FirstName} {LastName} {Username} isBlacklisted: {isBlacklisted}";
      }

      public bool HasValidCreditScore()
      {
         return CreditScore >= VALID_CREDIT_SCORE;
      }
   }
}
