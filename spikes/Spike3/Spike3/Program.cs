using Spike3;
using System;
using System.Windows.Forms;

namespace Spike3
{
   static class Program
   {
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main()
      {
         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);
         Application.Run(new CarRentalSystem.Spike3Form());
      }
   }
}
