using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Spike3.Controllers;
using Spike3.DBObjects;

namespace CarRentalSystem
{
   public partial class Spike3Form : Form
   {
      public Spike3Form()
      {
         InitializeComponent();
         Vehicle v1 = VehicleControl.FindVehicle("0");
         pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
      }
   }
}
