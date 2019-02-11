using CarRentalSystem.Forms;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace CarRentalSystem
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
         Application.Run(new ParentForm());
      }
   }
}
