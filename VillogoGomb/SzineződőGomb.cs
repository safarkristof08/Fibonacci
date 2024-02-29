using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace VillogoGomb
{
    internal class SzineződőGomb : Button
    {
        int méret = 40;
        public SzineződőGomb()
        {
            Click += SzineződőGomb_Click;
           



        }

       

       

        private void SzineződőGomb_Click(object? sender, EventArgs e)
        {
            BackColor = Color.Fuchsia;
            

        }
    }
}
