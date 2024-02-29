using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillogoGomb
{
    internal class VillogoGomb : Button
    {
        
        public VillogoGomb()
        {
            System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
            BackColor = Color.Yellow;
            MouseEnter += VillogoGomb_MouseEnter;
            //MouseLeave += VillogoGomb_MouseLeave;
          
            


        }

       

        private void VillogoGomb_MouseLeave(object? sender, EventArgs e)
        {
            BackColor = SystemColors.ButtonFace;
        }

        private void VillogoGomb_MouseEnter(object? sender, EventArgs e)
        {
            BackColor = Color.Fuchsia;
        }
    }
}
