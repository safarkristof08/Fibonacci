using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kigyosjatek
{

    
    internal class KígyóElem : PictureBox
    {
        public static int Méret = 20;
        int Hossz = 10;
        public KígyóElem()
        {
            Width = KígyóElem.Méret;
            Height = KígyóElem.Méret;
            BackColor = Color.Fuchsia;


        }
    }
    
    
}

